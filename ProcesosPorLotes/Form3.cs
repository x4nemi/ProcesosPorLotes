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
        Lotes<AlmacenProcesos<Procesos>> lo = new Lotes<AlmacenProcesos<Procesos>>();

        AlmacenProcesos<Procesos> Listos = new AlmacenProcesos<Procesos>();
        AlmacenProcesos<Procesos> Bloqueados = new AlmacenProcesos<Procesos>();

        public Form3(AlmacenProcesos<Procesos> qu)
        {
            InitializeComponent();
            q = qu;

            this.KeyPreview = true;
            EnProceso();
        }

        private void limpiarLabels()
        {
            TRLabel.Text = "";
            TTLabel.Text = "";
            OperacionLabel.Text = "";
            IDLabel.Text = "";
            LoteEPLabel.Text = "Lote en proceso: ";
        }

     
        private void AgregarItemsListBox(int numLotes)
        {
            for(int i = 1; i <= numLotes; i++)
            {
                procesosListosList.Items.Add("Lote " + i.ToString());
            }
        }


        private void LoteEnProceso(AlmacenProcesos<Procesos> Lote)
        {
            bloqueadosList.Items.Clear();
            foreach(Procesos p in Lote.Cola)
            {
                bloqueadosList.Items.Add("ID: " + p.Id.ToString() + "\t" + "Tiempo: " + p.Tiempo.ToString());
            }

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

        private async void EnProceso()
        {
            TiempoGlob = 0;
            timer2.Start();

            lo.ProcesosPorLotes(q);

            AgregarItemsListBox(lo.Cola.Count);

            int i = 1;


            foreach (AlmacenProcesos<Procesos> AP in lo.Cola)
            {
                LoteEnProceso(AP);
                procesosListosList.Items.Remove("Lote " + i.ToString());
                LoteEPLabel.Text = "Lote en proceso: " + i;

                while (!AP.EsVacia())
                {
                    Procesos p = new Procesos(1, "", 1, 1, 1, "", 1);
                    p = AP.Ejecutar();

                    bloqueadosList.Items.Remove("ID: " + p.Id.ToString() + "\t" + "Tiempo: " + p.Tiempo.ToString());

                    TR = p.TiempoR == -1 ? p.Tiempo : p.TiempoR;
                    TT = p.TiempoT == -1 ? 0 : p.TiempoT;
                    timer1.Start();
                    await Task.Delay(1000);
                    IDLabel.Text = "ID: " + p.Id.ToString();
                    OperacionLabel.Text = "Operación: " + p.Num1.ToString() + operador(p.Operacion) + p.Num2.ToString();

                    int tiempoWhile = p.TiempoR == -1 ? p.Tiempo : p.TiempoR;

                    int k = 0;
                    while (k <= tiempoWhile )
                    {
                        if (pause)
                        {
                            timer1.Stop();
                            timer2.Stop();
                            while (pause)
                            {
                                await Task.Delay(1000);
                            }
                            timer1.Start();
                            timer2.Start();
                        } else if (interrupcion)
                        {
                            timer1.Stop();
                            p.TiempoR = TR;
                            p.TiempoT = TT;
                            AP.Agregar(p);
                            break;
                        }
                        else
                        {
                            Task delay = Task.Delay(1000);
                            await delay;
                            k++;
                        }
                    }

                    

                    if (interrupcion) {
                        interrupcion = false;
                        LoteEnProceso(AP);
                    }
                    else
                    {
                        string res = error ? "Error" : Resultado(p.Num1, p.Num2, p.Operacion).ToString("#0.00");
                        error = false;
                        TeclaAccionLabel.Text = "";

                        terminadosList.Items.Add("ID: " + p.Id.ToString() + "\t" + "Resultado:  " + res);

                        bloqueadosList.Items.Remove(p.Nombre + "\t" + "ID: " + p.Id.ToString());
                    }



                }

                i++;
                    
                terminadosList.Items.Add("---------------------");
               
            }
                
           
            timer2.Stop();

            limpiarLabels();
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


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if(!interrupcion)
            {
                TRLabel.Text = "Tiempo Restante: " + TR--.ToString();
                TTLabel.Text = "Tiempo Transcurrido: " + TT++.ToString();

            }
            
            if (TR < 0)
            {
                timer1.Stop();
            }
        }
     
        private void timer2_Tick(object sender, EventArgs e)
        {
            TiempoGlobalLabel.Text = "Tiempo Global: " +TiempoGlob++.ToString();
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
                if (e.KeyCode == Keys.P)
                {
                    TeclaAccionLabel.Text = "Pause";
                    pause = true;
                }
                if (e.KeyCode == Keys.E)
                {
                    TeclaAccionLabel.Text = "Interrupción";
                    interrupcion = true;
                }

                if (e.KeyCode == Keys.W)
                {
                    TeclaAccionLabel.Text = "Error";
                    error = true;
                }
            }         
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

    }
}
