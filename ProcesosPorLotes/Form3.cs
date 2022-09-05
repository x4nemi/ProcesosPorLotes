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

        public Form3(AlmacenProcesos<Procesos> qu)
        {
            InitializeComponent();
            q = qu;
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

     
        private void AgregarItemsListBox()
        {
            int procesosNumero = q.Cola.Count % 3 == 0 ? q.Cola.Count / 3 : q.Cola.Count / 3 + 1;
 
            for(int i = 1; i <= procesosNumero ; i++)
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
                    listBox3.Items.Add(p.Nombre+ "\t" + "ID: " + p.Id.ToString());
                }

                j++;

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
        
        private async void EnProceso()
        {
            AgregarItemsListBox();
            int i = 1, j = 1;
            int procesosNumero = q.Cola.Count % 3 == 0 ? q.Cola.Count / 3 : q.Cola.Count / 3 + 1;

            TiempoGlob = 0;
            timer2.Start();
            AgregarEnProceso(1);
            foreach (Procesos p in q.Cola)
            {
                seconds = p.Tiempo;
                TR = 0;
                timer1.Start();
                label10.Text = "ID: " + p.Id.ToString();
                label5.Text = "Resultado: " + Resultado(p.Num1, p.Num2, p.Operacion).ToString("#.00");
                label4.Text = "Nombre: "+p.Nombre;
                label9.Text = "Operación: " + p.Num1.ToString() + operador(p.Operacion) + p.Num2.ToString() ;

                await Task.Delay(seconds * 1000 + 1000);

                listBox2.Items.Add("Nombre: " + p.Nombre + "\t" + "ID: " + p.Id.ToString());

                listBox3.Items.Remove(p.Nombre + "\t" + "ID: " + p.Id.ToString());
                if(i % 3 == 0)
                {
                    listBox1.Items.Remove("Lote " + j);
                    listBox2.Items.Add("---------------------");
                    i = 0;
                    j++;
                    if(j <= procesosNumero)
                    {
                        AgregarEnProceso(j);
                    }
                    
                }    
                i++;
            }

            if(i != 1)
            {
                listBox1.Items.Remove("Lote " + j);
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
            label6.Text = "TR: " + seconds--.ToString();
            label8.Text = "TT: " + TR++.ToString();
            if (seconds < 0)
            {
                timer1.Stop();
            }
        }
     
        private void timer2_Tick(object sender, EventArgs e)
        {
            label11.Text = "Tiempo Global: " +TiempoGlob++.ToString();
        }
    }
}
