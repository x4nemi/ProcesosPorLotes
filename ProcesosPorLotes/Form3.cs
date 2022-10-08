using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



/*
    Nombres de Labels
        IDLabel
        OperacionLabel
        TiempoTLabel (Transcurrido)
        TiempoRLabel (Restante)
        LoteEPLabel (Lote en proceso en el panel rosa)
        TiempoGLabel (Global)
        TeclaPresionadaLabel (izquierda abajo)
        TeclaAccionLabel (derecha abajo)
        ProcesosNuevosLabel
 */

/*
    Nombres de listBoxes
        procesosListossList
            Los items de esta lista van como 
            "ID: " + ID.toString() + "TME: " + TME.toString() + "\t" + "Tiempo T: " tt.toString()
        terminadosList
            Los items de esta lista van como
            "ID: " + IDdelProceso.ToString() + "\t" + "Resultado:  " + resultadoOperacion
        bloqueadosList
            Los items de esta lista van como
            "ID: " + IDdelProceso.ToString() + "\t" + "Tiempo: " + tiempoDelProceso.ToString()
            
 */

/*
    Timers
        timer1 : es para el tiempo transcurrido y el restante
        timer2 : es para el global
 */


namespace ProcesosPorLotes
{
    public partial class Form3 : Form

    {
        AlmacenProcesos<Procesos> q = new AlmacenProcesos<Procesos>();

        AlmacenProcesos<Procesos> Listos = new AlmacenProcesos<Procesos>();
        List<Procesos> Bloqueado = new List<Procesos>();
        AlmacenProcesos<Procesos> Nuevos = new AlmacenProcesos<Procesos>();
        AlmacenProcesos<Procesos> Terminados = new AlmacenProcesos<Procesos>();
        Procesos Proceso = new Procesos();

        public Form3(AlmacenProcesos<Procesos> qu)
        {
            InitializeComponent();
            q = qu;
            Nuevos = qu;

            this.KeyPreview = true;
            //EnProceso();

            LlenarTiemposBlocked();
            DividirListosNuevos();

            TiempoGlob = 0;
            timer2.Start();
            FirstComeFirstServer();
        }



        private void limpiarLabels()
        {
            TRLabel.Text = "Tiempo Restante: 0 segundos";
            TTLabel.Text = "Tiempo Transcurrido: 0 segundos";
            OperacionLabel.Text = "Operación: ";
            IDLabel.Text = "ID: ";
            tmeLabel.Text = "TME: ";
        }
      

        private string operador (string op)
        {
            string res = "";
            switch (op)
            {
                case "Suma":
                    res = "+";
                    break;
                case "Resta":
                    res = "-";
                    break;
                case "Multiplicación":
                    res = "*";
                    break;
                case "División":
                    res = "/";
                    break;
                case "Residuo":
                    res = "%";
                    break;
                case "Potencia":
                    res = "^";
                    break;
            }
            return res;
        }

        int TT;
        int TR;
        int TiempoGlob;

        bool error = false;
        bool pause = false;
        bool interrupcion = false;

        bool running = false;

        List<bool> visitados = new List<bool>();
        List<int> tiempoBlocked = new List<int>();
        
        private void LlenarTiemposBlocked()
        {
            for (int i = 0; i < 100; i++)
            {
                tiempoBlocked.Add(-1);
                visitados.Add(false);
            }      
        }

        private void DividirListosNuevos()
        //Es para dividir los procesos que estan en la lista de procesos listos en 'lotes'
        {
            int unProceso = running ? 1 : 0;
            while (Listos.Tam() + Bloqueado.Count + unProceso < 3 && !Nuevos.EsVacia() )
            {
                Procesos p = new();
                p = Nuevos.Ejecutar();
                visitados[p.Id - 1] = true;
                p.TiempoLlegada = TiempoGlob;
                Listos.Agregar(p);
            }
        }
        
        private void AgregarListosList()
        {
            procesosListosList.Items.Clear();
            foreach (Procesos p in Listos.Cola)
            {
                procesosListosList.Items.Add(FormatoListos(p));
            }
            ProcesosNuevosLabel.Text = "Procesos nuevos: " + Nuevos.Tam().ToString();
        }


        private void AgregarTerminadosList(Procesos p)
        {
            p.TiempoFin = TiempoGlob;
            p.TiempoServicio = TT - 1;
            Terminados.Agregar(p);
            terminadosList.Items.Add(FormatoTerminados(p));
        }

        private void AgregarBloqueadosList()
        {
            bloqueadosList.Items.Clear();

            int i = 0;

            while(Bloqueado.Count != 0 && i < Bloqueado.Count)
            {
                Procesos p = new(1, "", 1, 1, 1, "", 1);
                p = Bloqueado[i];

                if (tiempoBlocked[p.Id - 1] == -1)
                {
                    Bloqueado.Remove(p);
                    Listos.Agregar(p);
                    AgregarListosList();
                    if (!running) FirstComeFirstServer();

                    i--;
                }
                else
                {
                    bloqueadosList.Items.Add(FormatoBloqueados(p.Id));
                }

                i++;
            }
        }
        
        private string FormatoListos(Procesos p)
        {
            return ("ID: " + p.Id.ToString() + "\t" + "TME: " + p.Tiempo.ToString() + "\t" + "TT: " + p.TiempoT.ToString());
        }
        
        private string FormatoTerminados(Procesos p)
        {
            return ("ID: " + p.Id.ToString() + "\t" + "Operación: " + p.Num1 + " " + operador(p.Operacion) + " " + p.Num2 + " = " + p.Resultado);
        }

        private string FormatoBloqueados(int id) 
        {
            return ("ID: " + id.ToString() + "\t" + "Tiempo Transcurrido: " + tiempoBlocked[id - 1].ToString());
        }

        //--Retorno El tiempo de finalización - llegada (cuenta el de bloqueados)
        //--Respuesta hasta que esté en ejecución 
        //--Espera el tiempo que no estuvo en ejecución (bloqueados y listos)
        //--Servicio TME o cuando termino por error (no calcula bloqueados)
        private async void FirstComeFirstServer()
        {
            running = true;

            while (!Listos.EsVacia())
            {
                //Procesos p = new(1, "", 1, 1, 1, "", 1);
                Proceso = Listos.Ejecutar();
                DividirListosNuevos();
                AgregarListosList();
                // Si es -1 significa que no se ha inicializado y si no, significa que ya se hizo y se tomará ese valor
                Proceso.TiempoRespuesta = Proceso.TiempoRespuesta == -1 ? TiempoGlob - Proceso.TiempoLlegada : Proceso.TiempoRespuesta;
                procesosListosList.Items.Remove(FormatoListos(Proceso));

                TR = Proceso.TiempoR == 0 ? Proceso.Tiempo : Proceso.TiempoR;
                TT = Proceso.TiempoT;
                timer1.Start();

                IDLabel.Text = "ID: " + Proceso.Id.ToString();
                OperacionLabel.Text = "Operación: " + Proceso.Num1.ToString() + operador(Proceso.Operacion) + Proceso.Num2.ToString();
                tmeLabel.Text = "TME: " + Proceso.Tiempo.ToString() + " segundos";
                
                int tiempoWhile = Proceso.TiempoR == 0 ? Proceso.Tiempo : Proceso.TiempoR;

                int k = 0;
                while (k <= tiempoWhile)
                {
                    if (pause)
                    {
                        timer1.Stop();
                        timer2.Stop();
                        if (!TerminoBloqueados()) timer3.Stop();
                        while (pause)
                        {
                            await Task.Delay(500);
                        }
                        timer1.Start();
                        timer2.Start();
                        if (!TerminoBloqueados()) timer3.Start();
                    }
                    else if (error)
                    {
                        timer1.Stop();
                        Proceso.TiempoR = TR;
                        Proceso.TiempoT = TT;
                        break;

                    }
                    else if (interrupcion)
                    {
                        timer1.Stop();
                        Proceso.TiempoR = TR;
                        Proceso.TiempoT = TT;

                        Bloqueado.Add(Proceso);
                        tiempoBlocked[Proceso.Id - 1] = 0;
                        timer3.Start();
                        break;
                    }
                    else
                    {
                        Task delay = Task.Delay(1000);
                        await delay;
                        k++;
                    }
                }

                TeclaAccionLabel.Text = "";
                AgregarListosList();
                DividirListosNuevos();
                if (interrupcion)
                {
                    interrupcion = false;
                }
                else
                { 
                    Proceso.Resultado = error ? "Error" : Resultado(Proceso.Num1, Proceso.Num2, Proceso.Operacion).ToString("#0.00");
                    error = false;
                    
                    AgregarTerminadosList(Proceso);
                    
                }
                
            }
            limpiarLabels();
            running = false;
        }

        private double Resultado (double num1, double num2, string op)
        {
            double resOp = 0;
            switch (op)
            {
                case "Suma":
                    resOp = num1 + num2;
                    break;
                case "Resta":
                    resOp = num1 - num2;
                    break;
                case "Multiplicación":
                    resOp = num1 * num2;
                    break;
                case "División":
                    resOp = num1 / num2;
                    break;
                case "Residuo":
                    resOp = num1 % num2;
                    break;
                case "Potencia":
                    resOp = Math.Pow(num1, num2);
                    break;
            }

            return resOp;
        }
       
        private bool TodoVacio()
        {
            return Bloqueado.Count == 0 && Listos.Tam() == 0 && Nuevos.Tam() == 0 && !running;
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TRLabel.Text = "Tiempo Restante: " + TR--.ToString() + " segundos";
            TTLabel.Text = "Tiempo Transcurrido: " + TT++.ToString() + " segundos";
            Proceso.TiempoT = TT;
            Proceso.TiempoR = TR;

            if (TR < 0)
            {
                timer1.Stop();
            }
        }
     
        private void timer2_Tick(object sender, EventArgs e)
        {
            TiempoGlobalLabel.Text = "Tiempo Global: " +TiempoGlob++.ToString();
            if (TodoVacio())
            {
                timer2.Stop();
                limpiarLabels();
                Form4 form4 = new Form4(Terminados);
                this.Close();
                form4.Show();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            AgregarBloqueadosList();
            for (int i = 0; i < tiempoBlocked.Count; i++)
            {
                if (tiempoBlocked[i] != -1) tiempoBlocked[i]++;

                if (tiempoBlocked[i] > 7)
                {
                    tiempoBlocked[i] = -1;
                    AgregarBloqueadosList();
                }
            }

            if (TerminoBloqueados())
            {
                timer3.Stop();
            }
        }

        private bool TerminoBloqueados()
        {
            foreach(int t in tiempoBlocked)
            {
                if (t != -1) return false;
            }

            return true;
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            //            E Interrupción
            //por entradasalida
            //El proceso que está en uso del procesador(ejecución) debe salir
            //de este e ir a la cola de los procesos del lote en ejecución(actual).
            //W Error El proceso que se esté ejecutando en ese momento terminara por
            //error, es decir saldrá del procesador y se mostrara en terminados,
            //para este caso como el proceso no termino normalmente se
            //desplegara error en lugar de un resultado.
            //P Pausa Detiene la ejecución de su programa momentáneamente, la
            //simulación se reanuda cuando se presione la tecla “C”.
            //C Continuar Al presionar esta tecla se reanudará el programa pausado
            //previamente con “P”.

            TeclaPresionadaLabel.Text = "Se presionó " + e.KeyCode;

            if(pause && e.KeyCode == Keys.C)
            {
                pause = false;
                TeclaAccionLabel.Text = "Continuar";
            }
            
            if(!pause)
            {
                switch (e.KeyCode)
                {
                    case Keys.E:
                        interrupcion = true;
                        TeclaAccionLabel.Text = "Interrupción";
                        break;
                    case Keys.W:
                        if (running) { 
                        error = true;
                        TeclaAccionLabel.Text = "Error";
                        }
                        break;
                    case Keys.P:
                        pause = true;
                        TeclaAccionLabel.Text = "Pausa";
                        break;
                    case Keys.N:
                        TeclaAccionLabel.Text = "Nuevo proceso creado";
                        AgregarProcesoNuevo();
                        DividirListosNuevos();
                        AgregarListosList();
                        if (!running)
                        {
                            FirstComeFirstServer();
                        }
                        break;
                    case Keys.B:
                        TeclaAccionLabel.Text = "Tabla de procesos";

                        //Proceso.TiempoBloqueado = tiempoBlocked[Proceso.Id - 1];

                        //El tiempo de servicio es el tiempo transcurrido
                        if (running)
                        {
                            Proceso.TiempoR = TR;
                            Proceso.TiempoT = TT;
                        }
                        pause = true;
                        this.Hide();
                        Form6 form6 = new Form6(Nuevos, Listos, Terminados, Bloqueado, Proceso, TiempoGlob, running);
                        form6.ShowDialog();
                        form6 = null;
                        this.Show();

                        pause = false;

                        break;
                }
            }         
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void AgregarProcesoNuevo()
        {
            string[] operaciones = { "Suma", "Resta", "División", "Multiplicación", "Residuo", "Potencia" };
            int id = Nuevos.EsVacia() ? ID() : Nuevos.Ultimo().Id + 1;
            string nombre = "Proceso " + id.ToString();
            int tiempo = new Random().Next(6, 15);
            int index = new Random().Next(0, 5);
            string operacion = operaciones[index];
            double num1;
            double num2;
            if (index == 5)
            {
                num1 = new Random().Next(1, 20);
                num2 = new Random().Next(1, 20);
            }
            else
            {
                num2 = new Random().Next(1, 100);
                num1 = new Random().Next(1, 100);
            }


            Procesos p = new Procesos(id, nombre, tiempo, num1, num2, operacion, id);
            Nuevos.Agregar(p);
        }

        
        private int ID()
        {
            for (int i = 0; i < visitados.Count; i++)
            {
                if (!visitados[i]) return i + 1;
            }
            return -1;
        }
    }
}
