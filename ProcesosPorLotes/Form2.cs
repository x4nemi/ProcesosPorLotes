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
        private int counter;
        public Form2( string counter_text)
        {
         
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 182, 193);
            this.CenterToScreen();
            counter = Int32.Parse(counter_text);
            label5.Text = "#" + counter.ToString();
            //Queue<Procesos> q = new Queue<Procesos>(Int32.Parse(cajita.Text));
            
        }

        AlmacenProcesos<Procesos> q = new AlmacenProcesos<Procesos>();
       
        private void button1_Click(object sender, EventArgs e)
        {
            Procesos pc = new Procesos(1, cajita2.Text, Int32.Parse(cajita3.Text),Double.Parse(cajita4.Text),
                Double.Parse(cajita5.Text), "Resta", Int32.Parse(cajita6.Text));
            q.Agregar(pc);

            nombre.Text = q.Cola.Dequeue().Nombre.ToString();
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cajita_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
