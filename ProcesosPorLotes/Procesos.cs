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
        private int tr;
        private int tt;
        private int tl; // Tiempo de llegada
        private int tret; // Tiempo de retorno
        private int tresp; // Tiempo de respuesta
        private int tesp; // Tiempo de espera
        private int ts; // Tiempo de servicio
        private string res;

        public int Numpro { get => numpro; set => numpro = value; }
        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 { get => num2; set => num2 = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Tiempo { get => tiempo; set => tiempo = value; }

        public int TiempoR { get => tr; set => tr = value; }
        public int TiempoT { get => tt; set => tt = value; }
        public int TiempoLlegada { get => tl; set => tl = value; }
        public int TiempoRetorno { get => tret; set => tret = value; }
        public int TiempoRespuesta { get => tresp; set => tresp = value; }
        public int TiempoEspera { get => tesp; set => tesp = value; }
        public int TiempoServicio { get => ts; set => ts = value; }
        public int TiempoFin { get => ts; set => ts = value; }
        public string Resultado { get => res; set => res = value; }

        public Procesos() { }
        public Procesos(int numProceso, string nombre, int tiempo, double num1, double num2, string operacion, int aidi)
        {
            Numpro = numProceso;
            Num1 = num1;
            Num2 = num2;
            Tiempo = tiempo;
            Operacion = operacion;
            Id = aidi;
            Nombre = nombre;
            TiempoR = 0;
            TiempoT = 0;

            
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

            return Cola.Peek();
        }

        public T Ejecutar()
        {
            return Cola.Dequeue();
        }

        public bool EsVacia()
        {
            return Cola.Count == 0;

        }

        public int Tam()
        {
            return Cola.Count;
        }
    }

    public class Lotes<T> : Queue<AlmacenProcesos<Procesos>>
    {
        private Queue<AlmacenProcesos<Procesos>> cola;

        public Queue<AlmacenProcesos<Procesos>> Cola { get => cola; set => cola = value; }

        public Lotes()
        {
            Cola = new Queue<AlmacenProcesos<Procesos>>();
        }

        public void ProcesosPorLotes(AlmacenProcesos<Procesos> qu)
        {
            int i = 1;

            AlmacenProcesos<Procesos> Lote = new AlmacenProcesos<Procesos>();
            foreach (Procesos p in qu.Cola)
            {
                Procesos proceso = new Procesos(p.Id, p.Nombre, p.Tiempo, p.Num1, p.Num2, p.Operacion, p.Id);

                
                Lote.Cola.Enqueue(proceso);

                if (i % 3 == 0)
                {
                    AlmacenProcesos<Procesos> LoteNuevo = new AlmacenProcesos<Procesos>();
                    
                    while (!Lote.EsVacia())
                    {
                        LoteNuevo.Cola.Enqueue(Lote.Ejecutar());
                    }
                    Cola.Enqueue(LoteNuevo);

                    i = 0;
                    
                }
                i++;

            }

            if(i > 1)
            {
                AlmacenProcesos<Procesos> LoteNuevo = new AlmacenProcesos<Procesos>();

                while (!Lote.EsVacia())
                {
                    LoteNuevo.Cola.Enqueue(Lote.Ejecutar());
                }
                Cola.Enqueue(LoteNuevo);
            }

        }
    }
}
