using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesosPorLotes
{
    
    public class Procesos
    {
        private int numpro;
        private int tiempo;
        private double num1;
        private double num2;
        private string operacion;
        private int id;
        private string nombre;

        public int Numpro { get => numpro; set => numpro = value; }
        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 { get => num2; set => num2 = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Tiempo { get => tiempo; set => tiempo = value; }

        public Procesos(int np, string nm,int tm, double n1, double n2, string op, int aidi)
        {
            Numpro = np;
            Num1 = n1;
            Num2 = n2;
            Tiempo = tm;
            Operacion = op;
            Id = aidi;
            Nombre = nm;
        }
    }

    public class AlmacenProcesos<T>
    {
        private Queue<T> cola;
        private int i;

        public Queue<T> Cola { get => cola; set => cola = value; }
        public int I { get => i; set => i = value; }

        public AlmacenProcesos()
        {
            Cola = new Queue<T>();
        }
        public void Agregar(T obj)
        {
            Cola.Enqueue(obj);
            I++;
        }

        public T Regresar()
        {
            return Cola.Dequeue();
        }
    }
}
