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
    public partial class Form4 : Form
    {

        AlmacenProcesos<Procesos> q = new AlmacenProcesos<Procesos>();
        public Form4(AlmacenProcesos<Procesos> qu)
        {
            InitializeComponent();
            q = qu;
            AgregarLista();
        }


        private void AgregarLista()
        {
            foreach (Procesos p in q.Cola)
            {
                string[] row = { p.Id.ToString(), p.Num1.ToString() + " " + operador(p.Operacion) + " " + p.Num2.ToString(), p.Tiempo.ToString() };
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
