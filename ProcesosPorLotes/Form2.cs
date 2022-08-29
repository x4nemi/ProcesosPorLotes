using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesosPorLotes
{
    public partial class Form2 : Form
    {
        private int counter = 1;
        private int totalProcesos;
        public Form2( string counter_text)
        {
         
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 182, 193);
            this.CenterToScreen();
            totalProcesos = Int32.Parse(counter_text);
            label5.Text = "#" + counter.ToString() + " de " + totalProcesos;

            progressBar1.Value = counter;
            progressBar1.Maximum = totalProcesos;
            progressBar1.Minimum = 0;
            
        }

        static AlmacenProcesos<Procesos> q = new AlmacenProcesos<Procesos>();
       
        //TODO
        //private bool IDValido(string aidi)
        //{
        //    AlmacenProcesos<Procesos> auxiliar = q;

        //    while(auxiliar.Cola.)
        //    {
        //        Procesos pAux = auxiliar.Cola.Dequeue();
        //        if(aidi == pAux.Id)
        //        {

        //        }
        //    }
        //    return false;
        //}


        private void LimpiarTextBoxes()
        {
            cajita6.Text = "";
            cajita3.Text = "";
            cajita2.Text = "";
            cajita4.Text = "";
            cajita5.Text = "";

        }

        private bool ValidarLlenado()
        {
            
            if(cajita6.Text == ""|| cajita3.Text == ""||
            cajita2.Text == ""||
            cajita4.Text == ""||
            cajita5.Text == "")
            {
                MessageBox.Show("Falta por rellenar");
                return false;
            }
            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarLlenado())
            {
                LimpiarTextBoxes();
                // cajita2 = nombre
                // cajita3 = tme
                // cajita4 = num1
                // cajita5 = num2
                // cajita6 = id

                Procesos pc = new Procesos(1, cajita2.Text, Int32.Parse(cajita3.Text),Double.Parse(cajita4.Text),
                    Double.Parse(cajita5.Text), "Resta", Int32.Parse(cajita6.Text));
                q.Agregar(pc);
                counter++;
            }   


        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = comboBox1.Text;
            cajita5.Enabled = true;
            cajita4.Enabled = true;

            cajita5.Text = "";
            cajita4.Text = "";
            
            switch (comboBox1.Text)
            {
                case "Suma":
                    label8.Text = "+";
                    break;
                case "Resta":
                    label8.Text = "-";
                    break;
                case "Multiplicación":
                    label8.Text = "*";
                    break;
                case "División":
                    label8.Text = "/";
                   
                    break;
                case "Residuo":
                    label8.Text = "//";
                    break;
                case "Potencia":
                    label8.Text = "^";
                    break;
                default:
                    label8.Text = "";

                    cajita4.Enabled = false;
                    cajita5.Enabled = false;
                    break;

            }

        }

        private void cajita_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cajita6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puedes ingresar numeros");
                e.Handled = true;
                return;

            }
        }
        private void cajita3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puedes ingresar numeros");
                e.Handled = true;
                return;

            }
        }
        private void cajita4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puedes ingresar numeros");
                e.Handled = true;
                return;

            }
        }
        private void cajita5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {

                MessageBox.Show("Solo puedes ingresar numeros");
                e.Handled = true;

                return;

            }
        }

        private void cajita5_TextChanged(object sender, EventArgs e)
        {
            if (cajita5.Text == "0")
            {
                MessageBox.Show("No se puede dividir entre 0");
                cajita5.Text = "";
            }
        }
    }
}
