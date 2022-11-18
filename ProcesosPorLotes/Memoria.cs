using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesosPorLotes
{
    public class Marco {
        
        private string estado = "Disponible";
        private int ocupados = 0;
        private int procesoID = -1;

        public string Estado { get => estado; set => estado = value; }

        public int Ocupados { get => ocupados; set => ocupados = value; }

        public int ProcesoID { get => procesoID; set => procesoID = value; }

        public Marco()
        {
            
        }

        public Marco(string estado, int ocupados, int id)
        {
            this.estado = estado;
            this.ocupados = ocupados;
            procesoID = id;
        }

    }

    public class Memoria<T> : List<Marco>
    {
        private List<Marco> lista = new List<Marco>();
        
        public List<Marco> Lista { get => lista; set => lista = value; }

        public Memoria()
        {
            for(int i = 0; i < 44; i++)
            {
                if(i < 40)
                {
                    Marco m = new();
                    lista.Add(m);
                }
                else
                {
                    Marco m = new("SO", 5, -1);
                    lista.Add(m);
                }
            }
        }

        public void AgregarProceso(Procesos p)
        {
            int tam = p.Tamanio;
            foreach(Marco m in lista)
            {   
                if(m.Ocupados == 0)
                {
                    
                    if(tam > 0)
                    {
                        m.ProcesoID = p.Id;
                        m.Estado = "Listo";
                        m.Ocupados = (tam > 5 ? 5 : tam);

                        tam -= 5;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        
        public void LiberarMarco(int id)
        {
            foreach(Marco m in lista)
            {
                if(m.ProcesoID == id)
                {
                    m.Estado = "Disponible";
                    m.Ocupados = 0;
                    m.ProcesoID = -1;
                }
            }
        }

        public void MarcoBlockListoProceso(int id, string estado)
        {
            foreach (Marco m in lista)
            {
                if (m.ProcesoID == id)
                {
                    m.Estado = estado;
                }
            }
        }

        public int Disponibles()
        {
            int dis = 0;
            foreach(Marco m in lista)
            {
                if (m.Ocupados == 0) dis++;
            }

            return dis;
        }
        
    }
}
