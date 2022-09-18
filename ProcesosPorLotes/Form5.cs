using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static ProcesosPorLotes.AlmacenProcesos<T>;

namespace ProcesosPorLotes
{
    public partial class Form5 : Form
    {

        AlmacenProcesos<Procesos> q = new AlmacenProcesos<Procesos>();

        public Form5(AlmacenProcesos<Procesos> qu)
        {
            InitializeComponent();
            q = qu;
            AgregarLista();
        }

        private void AgregarLista()
        {
            foreach (Procesos p in q.Cola)
            {
                string[] row = {p.Id.ToString(), p.Num1.ToString() + " " + operador(p.Operacion) + " " + p.Num2.ToString(), p.Tiempo.ToString()};
                dataGridView1.Rows.Add(row);
            }
        }

        private string operador(string op)
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


        
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(q);
            form3.Show();
            button1.Enabled = false;
        }

        private void Form5_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }

        private void Form5_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}
