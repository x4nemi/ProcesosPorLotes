using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesosPorLotes
{
    public class Class1
    {

        public Boolean BuscarSiExiste(int[]arreglo, int num)
        {
            Boolean respuesta = false;
            for(int i = 0; i<arreglo.Length; i++)
            {
                if(arreglo[i] == num)
                {
                    respuesta = true;
                }
            }

            return respuesta;
        }
    }
}
