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
            AlmacenarProcesos();
            AgregarItemsListBox();
            EnProceso();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        AlmacenProcesos<Procesos> q = new AlmacenProcesos<Procesos>();

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

            Procesos pc3 = new Procesos(1, "POtax", Int32.Parse("6"), Double.Parse("3"),
                    Double.Parse("3"), "Resta", Int32.Parse("1"));

            q.Agregar(pc3);

            Procesos pc4 = new Procesos(1, "Kiki", Int32.Parse("2"), Double.Parse("3"),
                    Double.Parse("3"), "Resta", Int32.Parse("1"));

            q.Agregar(pc4);


        }

        private void AgregarItemsListBox()
        {
            foreach (Procesos p in q.Cola)
            {
                listBox1.Items.Add(p.Nombre + p.Tiempo);
            }
        }

        int seconds;
        
        private async void EnProceso()
        {
            foreach (Procesos p in q.Cola)
            {
                seconds = p.Tiempo;
                timer1.Start();
                label4.Text = p.Nombre;
                await Task.Delay(seconds * 1000 + 1000);

            }

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
    }
}
