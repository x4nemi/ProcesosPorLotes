namespace ProcesosPorLotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 91, 116);
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dato = text1.Text;
            if (dato == "")
            {
                MessageBox.Show("ingresa un numero por favor");
            }
            else if (Int32.Parse(dato) < 2)
            {
                MessageBox.Show("Solo puedes ingresar numeros mayores a 10");
                text1.Text = "";
            }
            else
            {
                Form2 form2 = new Form2(text1.Text);
                form2.Show();
                //Form3 form3 = new Form3();
                //form3.Show();
                text1.Enabled = false;
               
                

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void text1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >=32 && e.KeyChar <= 47)||(e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puedes ingresar numeros");
                e.Handled = true;
                return;
            
            }
        }
    }
}