namespace ProcesosPorLotes
{
    public partial class Form1 : Form
    {

        static AlmacenProcesos<Procesos> qu = new AlmacenProcesos<Procesos>();

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
            else if (Int32.Parse(dato) < 10)
            {
                MessageBox.Show("Solo puedes ingresar numeros mayores a 10");
                text1.Text = "";
            }
            else
            {
                AgregarProcesosRandom(Int32.Parse(text1.Text));
                //Form2 form2 = new Form2(text1.Text);
                //form2.Show();
                Form3 form3 = new Form3(qu);
                form3.Show();
                text1.Enabled = false;

            }
        }

        
        private void AgregarProcesosRandom(int procesos)
        {

            string[] operaciones = { "Suma", "Resta", "División", "Multiplicación", "Residuo", "Potencia" };
            
            
            for (int i = 0; i < procesos; i++)
            {
                int id = i + 1;
                string nombre = "Proceso " + i.ToString();
                int tiempo = new Random().Next(6, 16);
                int index = new Random().Next(0, 5);
                string operacion = operaciones[index];
                double num1;
                double num2;
                if( index == 5)
                {
                    num1 = new Random().Next(1, 20);
                    num2 = new Random().Next(1, 20);
                }
                else
                {
                    num2 = new Random().Next(1, 100);
                    num1 = new Random().Next(1, 100);
                }


                Procesos p = new Procesos(id, nombre, tiempo, num1, num2, operacion, id );
                qu.Agregar(p);
            }
            
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