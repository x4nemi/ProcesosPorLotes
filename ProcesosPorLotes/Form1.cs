namespace ProcesosPorLotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Hola mundo");
            Form2 form2 = new Form2(textBox1.Text);
            form2.Show();
            
        }
    }
}