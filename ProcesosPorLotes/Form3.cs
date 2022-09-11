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



namespace ProcesosPorLotes
{
    public partial class Form3 : Form

    {
        AlmacenProcesos<Procesos> q = new AlmacenProcesos<Procesos>();
        Lotes<AlmacenProcesos<Procesos>> lo = new Lotes<AlmacenProcesos<Procesos>>();

        public Form3(AlmacenProcesos<Procesos> qu)
        {
            InitializeComponent();
            q = qu;

            this.KeyPreview = true;
            EnProceso();
        }

        private void limpiarLabels()
        {
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label12.Text = "Lote en proceso: ";
        }

     
        private void AgregarItemsListBox(int numLotes)
        {
            //int procesosNumero = q.Cola.Count % 3 == 0 ? q.Cola.Count / 3 : q.Cola.Count / 3 + 1;
 
            //for(int i = 1; i <= procesosNumero ; i++)
            //{
            //    listBox1.Items.Add("Lote " + i.ToString());
            //}

            for(int i = 1; i <= numLotes; i++)
            {
                listBox1.Items.Add("Lote " + i.ToString());
            }
        }

        private void AgregarEnProceso(int lote)
        {
            int i = (lote - 1) * 3;
            int limit = i > q.Cola.Count ? q.Cola.Count : i + 3;
            int j = 0;

            listBox2.Items.Add("Lote " + lote);
            label12.Text = "Lote en proceso: " + lote;
            
            foreach (Procesos p in q.Cola)
            {

                if(j >= i && j < limit)
                {
                    listBox3.Items.Add( "ID: " + p.Id.ToString() + "\t" + "Tiempo: " + p.Tiempo.ToString());
                }

                j++;

             }
        }

        private void LoteEnProceso(AlmacenProcesos<Procesos> Lote)
        {
            listBox3.Items.Clear();
            foreach(Procesos p in Lote.Cola)
            {
                listBox3.Items.Add("ID: " + p.Id.ToString() + "\t" + "Tiempo: " + p.Tiempo.ToString());
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

        int seconds;
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
                listBox1.Items.Remove("Lote " + i.ToString());
                label12.Text = "Lote en proceso: " + i;

                while (!AP.EsVacia())
                {
                    Procesos p = new Procesos(1, "", 1, 1, 1, "", 1);
                    p = AP.Ejecutar();

                    listBox3.Items.Remove("ID: " + p.Id.ToString() + "\t" + "Tiempo: " + p.Tiempo.ToString());

                    seconds = p.TiempoR == -1 ? p.Tiempo : p.TiempoR;
                    TR = p.TiempoT == -1 ? 0 : p.TiempoT;
                    timer1.Start();

                    label10.Text = "ID: " + p.Id.ToString();
                    label5.Text = "";
                    label4.Text = "";
                    //label5.Text = "Resultado:  " + Resultado(p.Num1, p.Num2, p.Operacion).ToString("#0.00");
                    ////label4.Text = "Nombre: " + p.Nombre;
                    label9.Text = "Operación: " + p.Num1.ToString() + operador(p.Operacion) + p.Num2.ToString();


                    int k = 0;
                    while (k <= p.Tiempo + 1)
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
                            p.TiempoR = seconds;
                            p.TiempoT = TR;
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
                        label14.Text = "";

                        listBox2.Items.Add("ID: " + p.Id.ToString() + "\t" + "Resultado:  " + res);

                        listBox3.Items.Remove(p.Nombre + "\t" + "ID: " + p.Id.ToString());
                    }



                }

                i++;
                    
                listBox2.Items.Add("---------------------");
               
            }
                
            // ------------------------------------------

            //AgregarItemsListBox();
            //int i = 1, j = 1;
            //int procesosNumero = q.Cola.Count % 3 == 0 ? q.Cola.Count / 3 : q.Cola.Count / 3 + 1;

            
            //AgregarEnProceso(1);
            //foreach (Procesos p in q.Cola)
            //{
            //    seconds = p.Tiempo;
            //    TR = 0;
            //    timer1.Start();
            //    label10.Text = "ID: " + p.Id.ToString();
            //    label5.Text = "Resultado:  " + Resultado(p.Num1, p.Num2, p.Operacion).ToString("#0.00");
            //    label4.Text = "Nombre: " + p.Nombre;
            //    label9.Text = "Operación: " + p.Num1.ToString() + operador(p.Operacion) + p.Num2.ToString();

            //    int k = 0;
            //    while (k <= p.Tiempo + 1)
            //    {
            //        if (pause)
            //        {
            //            timer1.Stop();
            //            timer2.Stop();
            //            while (pause)
            //            {
            //                await Task.Delay(1000);
            //            }
            //            timer1.Start();
            //            timer2.Start();
            //        }
            //        else
            //        {
            //            Task delay = Task.Delay(1000);
            //            await delay;
            //            k++;
            //        }
            //    }

            //    string res = error ? "Error" : Resultado(p.Num1, p.Num2, p.Operacion).ToString("#0.00");

            //    error = false;
            //    label14.Text = "";

            //    listBox2.Items.Add("ID: " + p.Id.ToString() + "\t" + "Resultado:  " + res);

            //    listBox3.Items.Remove(p.Nombre + "\t" + "ID: " + p.Id.ToString());
            //    if (i % 3 == 0)
            //    {
            //        listBox1.Items.Remove("Lote " + j);
            //        listBox2.Items.Add("---------------------");
            //        i = 0;
            //        j++;
            //        if (j <= procesosNumero)
            //        {
            //            AgregarEnProceso(j);
            //        }

            //    }
            //    i++;
            //}

            //if(i != 1)
            //{
            //    listBox1.Items.Remove("Lote " + j);
            //}
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
            label6.Text = "Tiempo Restante: " + seconds--.ToString();
            label8.Text = "Tiempo Total: " + TR++.ToString();
            
            if (seconds < 0)
            {
                timer1.Stop();
            }
        }
     
        private void timer2_Tick(object sender, EventArgs e)
        {
            label11.Text = "Tiempo Global: " +TiempoGlob++.ToString();
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

            label13.Text = "Se presionó " + e.KeyCode;

            if(pause && e.KeyCode == Keys.C)
            {
                pause = false;
                label14.Text = "Continuar";
            }
            
            if(!pause)
            {
                if (e.KeyCode == Keys.P)
                {
                    label14.Text = "Pause";
                    pause = true;
                }
                if (e.KeyCode == Keys.E)
                {
                    label14.Text = "Interrupción";
                    interrupcion = true;
                }

                if (e.KeyCode == Keys.W)
                {
                    label14.Text = "Error";
                    error = true;
                }
            }         
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
