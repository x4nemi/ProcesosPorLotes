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
        AlmacenProcesos<Procesos> cola2 = new AlmacenProcesos<Procesos>();
        public Form4(AlmacenProcesos<Procesos> cola)
        {
            InitializeComponent();
            cola2 = cola;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabla.Rows.Add(cola2.Regresar().Id, cola2.Regresar().Nombre, cola2.Regresar().Num1, cola2.Regresar().Num2, cola2.Regresar().Operacion, cola2.Regresar().Tiempo, cola2.Regresar().Numpro);
            cola2.Ejecutar();
        }
    }
}
