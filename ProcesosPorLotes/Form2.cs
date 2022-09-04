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

            progressBar1.Value = counter - 1;
            progressBar1.Maximum = totalProcesos;
            progressBar1.Minimum = 0;

        }
            
        

        static AlmacenProcesos<Procesos> qu = new AlmacenProcesos<Procesos>();
        static List<int> lista = new List<int>();
        
        //Form4 form4 = new Form4(qu);
        public void Barra()
        {
            //totalProcesos = Int32.Parse(counter_text);
            label5.Text = "#" + counter.ToString() + " de " + totalProcesos;

            progressBar1.Value = counter-1;
            progressBar1.Maximum = totalProcesos;
            progressBar1.Minimum = 0;
        }

        private void LimpiarTextBoxes()
        {
            cajita6.Text = "";
            cajita3.Text = "";
            cajita2.Text = "";
            cajita4.Text = "";
            cajita5.Text = "";
            comboBox1.Text = "Selecciona uno...";
            label7.Text = "Esperando a elección de operación...";
            label8.Text = "";

            cajita4.Enabled = false;
            cajita5.Enabled = false;
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
                    string id = cajita6.Text;
                    int idm = Int32.Parse(id);
                    string tm = cajita3.Text;
                    int tm2 = Int32.Parse(tm);
                    string n1 = cajita4.Text;
                    string n2 = cajita5.Text;
                    Double nn1 = Double.Parse(n1);
                    Double nn2 = Double.Parse(n2);

                    int[] ids = lista.ToArray();
                    Procesos pc = new Procesos(counter, cajita2.Text, tm2, nn1, nn2, comboBox1.Text, idm);
                    bool existe = ids.Contains(idm);

                if (existe == true)
                {
                    MessageBox.Show("Este id ya existe");
                    cajita6.Text = "";
                    cajita6.Focus();
                }
                else if (tm2 <= 0)
                {
                    MessageBox.Show("El tiempo debe de mayor de cero");
                    cajita3.Text = "";
                    cajita3.Focus();
                }
                else
                {
                    qu.Agregar(pc);
                    //form4.tabla.Rows.Add(qu.Regresar().Id, qu.Regresar().Nombre, qu.Regresar().Num1, qu.Regresar().Num2,qu.Regresar().Operacion, qu.Regresar().Tiempo, qu.Regresar().Numpro);
                    //qu.Ejecutar();
                    counter++;
                    Barra();
                    LimpiarTextBoxes();
                    //form4.Show();
                    lista.Add(idm);
                    
                    if (counter > totalProcesos)
                    {
                        Form3 form3 = new Form3(qu);
                        form3.Show();
                        this.Close();
                    }
                }
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
                    label8.Text = "%";
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
            if (cajita5.Text == "0" && (comboBox1.Text == "División" || comboBox1.Text == "Residuo"))
            {
                MessageBox.Show("No se puede dividir entre 0");
                cajita5.Text = "";
            }
        }


        private void cajita3_TextChanged(object sender, EventArgs e)
        {
            if(cajita3.Text == "0")
            {
                MessageBox.Show("El tiempo tiene que ser mayor a 0");
                cajita3.Text = "";
            }
        }
    }
}
