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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            label5.Text = "#" + counter.ToString();
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
