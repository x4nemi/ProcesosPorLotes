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

        public Form3()
        {
            InitializeComponent();
            //AlmacenarProcesos();
            EnProceso();
        }

        private void limpiarLabels()
        {
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
        }

        AlmacenProcesos<Procesos> q = new AlmacenProcesos<Procesos>();

        AlmacenProcesos<Procesos> Terminados = new AlmacenProcesos<Procesos>();


        private void AlmacenarProcesos()
        {
            Procesos pc = new Procesos(1, "Ximena", Int32.Parse("3"), Double.Parse("3"),
                    Double.Parse("3"), "Resta", Int32.Parse("1"));

            q.Agregar(pc);

            Procesos pc1 = new Procesos(1, "Jorge", Int32.Parse("2"), Double.Parse("3"),
                    Double.Parse("3"), "Resta", Int32.Parse("1"));

            q.Agregar(pc1);
            Procesos pc2 = new Procesos(1, "Kevin", Int32.Parse("1"), Double.Parse("3"),
                    Double.Parse("3"), "Resta", Int32.Parse("1"));

            q.Agregar(pc2);

            //Procesos pc3 = new Procesos(1, "POtax", Int32.Parse("6"), Double.Parse("3"),
            //        Double.Parse("3"), "Resta", Int32.Parse("1"));

            //q.Agregar(pc3);

            //Procesos pc4 = new Procesos(1, "Kiki", Int32.Parse("2"), Double.Parse("3"),
            //        Double.Parse("3"), "Resta", Int32.Parse("1"));

            //q.Agregar(pc4);


            //Procesos pc5 = new Procesos(1, "Conie", Int32.Parse("2"), Double.Parse("3"),
            //        Double.Parse("3"), "Resta", Int32.Parse("1"));

            //q.Agregar(pc5);

        }

        private void AgregarItemsListBox()
        {
            int procesosNumero = q.Cola.Count % 3 == 0 ? q.Cola.Count / 3 : q.Cola.Count / 3 + 1;
 
            for(int i = 1; i <= procesosNumero ; i++)
            {
                listBox1.Items.Add("Lote " + i.ToString());
            }
        }

        int seconds;
        
        private async void EnProceso()
        {
            AgregarItemsListBox();
            int i = 1, j = 1;
            foreach (Procesos p in q.Cola)
            {
                seconds = p.Tiempo;
                timer1.Start();
                label6.Text = Resultado(p.Num1, p.Num2, p.Operacion).ToString();
                label5.Text = i.ToString();
                label4.Text = p.Nombre;

                
                await Task.Delay(seconds * 1000 + 1000);


                if(i % 3 == 0)
                {
                    listBox1.Items.Remove("Lote " + j);
                    listBox2.Items.Add("Lote " + j);
                    i = 0;
                    j++;
                }    
                i++;
            }

            if(i != 1)
            {
                listBox1.Items.Remove("Lote " + j);
                listBox2.Items.Add("Lote " + j);
            }

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
            label6.Text = seconds--.ToString();
            if (seconds < 0)
            {
                timer1.Stop();
                //txtSeconds.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //seconds = Convert.ToInt32("5");
            ////txtSeconds.Enabled = false;
            //timer1.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
