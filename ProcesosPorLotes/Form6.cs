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
    public partial class Form6 : Form
    {
        AlmacenProcesos<Procesos> Nuevos = new AlmacenProcesos<Procesos>();
        AlmacenProcesos<Procesos> Listos = new AlmacenProcesos<Procesos>();
        AlmacenProcesos<Procesos> Terminados = new AlmacenProcesos<Procesos>();
        List<Procesos> Bloqueados = new List<Procesos>();
        Procesos ProcesoEnEjecucion = new Procesos();

        public Form6(AlmacenProcesos<Procesos> N, AlmacenProcesos<Procesos> L, AlmacenProcesos<Procesos> T, List<Procesos> Bloqueado, Procesos p)
        {
            InitializeComponent();
            Nuevos = N;
            Listos = L;
            Terminados = T;
            Bloqueados = Bloqueado;
            ProcesoEnEjecucion = p;

            if(!Terminados.EsVacia()) AgregarTerminadosLista();
            if (!Listos.EsVacia()) AgregarListosLista();
            if (!Nuevos.EsVacia()) AgregarNuevosLista();
            
        }
        
        private void AgregarTerminadosLista()
        {
            foreach (Procesos p in Terminados.Cola)
            {
                dataGridView1.Rows.Add(FormatoTerminados(p));
            }
        }

        private void AgregarEnEjecucionLista()
        {
            dataGridView1.Rows.Add(FormatoEnEjecucion(ProcesoEnEjecucion));
        }

        private void AgregarListosLista()
        {
            foreach (Procesos p in Listos.Cola)
            {
                dataGridView1.Rows.Add(FormatoListos(p));
            }
        }
        private void AgregarNuevosLista()
        {
            foreach (Procesos p in Nuevos.Cola)
            {
                dataGridView1.Rows.Add(FormatoNuevos(p));
            }
        }

        //Retorno El tiempo de finalización - llegada(cuenta el de bloqueados)
        private string[] FormatoTerminados(Procesos p)
        {
            p.TiempoRetorno = p.TiempoFin - p.TiempoLlegada;
            p.TiempoEspera = p.TiempoRetorno - p.TiempoServicio - 1;
            //              ID                  Estado            Operación                                                               Resultado       TME                     Llegada              Finalización                //Retorno                       //Espera                   //Respuesta                 //Tiempo de Servicio //Tiempo restante
            string[] row = { p.Id.ToString(), "Terminados", p.Num1.ToString() + " " + operador(p.Operacion) + " " + p.Num2.ToString(), p.Resultado, p.Tiempo.ToString(), p.TiempoLlegada.ToString(), p.TiempoFin.ToString(), p.TiempoRetorno.ToString(), p.TiempoEspera.ToString(), p.TiempoRespuesta.ToString(), p.TiempoServicio.ToString(), "Null"};
            return row;
        }
        
        private string[] FormatoListos(Procesos p)
        {
            p.TiempoRetorno = p.TiempoFin - p.TiempoLlegada;
            p.TiempoEspera = p.TiempoRetorno - p.TiempoServicio - 1;
            //              ID                  Operación                                                                     Resultado       TME                     Llegada        Finalización  //Retorno           //Espera             //Respuesta                 //Tiempo de Servicio    //Tiempo restante
            string[] row = { p.Id.ToString(), "Listos", p.Num1.ToString() + " " + operador(p.Operacion) + " " + p.Num2.ToString(), "Null", p.Tiempo.ToString(), p.TiempoLlegada.ToString(), "Null", "Null", p.TiempoEspera.ToString(), p.TiempoRespuesta.ToString(), p.TiempoServicio.ToString(), "Null" };
            return row;
        }
        
        private string[] FormatoNuevos(Procesos p)
        {
            //              ID                  Operación                                                               Resultado               TME         Llegada/Finalización//Retorno//Espera//Respuesta//Tiempo de Servicio//Tiempo restante
            string[] row = { p.Id.ToString(), "Nuevos", p.Num1.ToString() + " " + operador(p.Operacion) + " " + p.Num2.ToString(), "Null", p.Tiempo.ToString(), "Null", "Null", "Null",       "Null", "Null", "Null", "Null" };
            return row;
        }
        
        private string[] FormatoEnEjecucion(Procesos p)
        {
            //              ID                  Operación                                                               Resultado               TME         Llegada/Finalización//Retorno//Espera//Respuesta//Tiempo de Servicio//Tiempo restante
            string[] row = { p.Id.ToString(), "Nuevos", p.Num1.ToString() + " " + operador(p.Operacion) + " " + p.Num2.ToString(), "Null", p.Tiempo.ToString(), "Null", "Null", "Null",       "Null", "Null", "Null", "Null" };
            return row;
        }

        private string operador(string op)
        {
            string res = "";
            switch (op)
            {
                case "Suma":
                    res = "+";
                    break;
                case "Resta":
                    res = "-";
                    break;
                case "Multiplicación":
                    res = "*";
                    break;
                case "División":
                    res = "/";
                    break;
                case "Residuo":
                    res = "%";
                    break;
                case "Potencia":
                    res = "^";
                    break;
            }
            return res;
        }


        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
