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

        List<int> tiempoBloqueado = new List<int>();

        int TiempoGlobal;
        bool running;

        int quantum;

        public Form6(AlmacenProcesos<Procesos> N, AlmacenProcesos<Procesos> L, AlmacenProcesos<Procesos> T, List<Procesos> Bloqueado, Procesos p, int tiempoGlob, bool r, List<int> tiempoB, int quantumValue)
        {
            InitializeComponent();
            Nuevos = N;
            Listos = L;
            Terminados = T;
            Bloqueados = Bloqueado;
            ProcesoEnEjecucion = p;
            TiempoGlobal = tiempoGlob;
            running = r;
            tiempoBloqueado = tiempoB;
            quantum = quantumValue;

            label1.Text = "Tiempo Global: " + (tiempoGlob-1).ToString() + "s";
            QuantumLabel.Text = "Valor de Quantum: " + quantum.ToString();

            if (running) AgregarEnEjecucionLista();
            if (!Nuevos.EsVacia()) AgregarNuevosLista();
            if (!Listos.EsVacia()) AgregarListosLista();
            if (Bloqueados.Count > 0) AgregarBloqueadosLista();
            if(!Terminados.EsVacia()) AgregarTerminadosLista();

            this.KeyPreview = true;


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
        
        private void AgregarBloqueadosLista()
        {
            foreach(Procesos p in Bloqueados)
            {
                dataGridView1.Rows.Add(FormatoBloqueados(p));
            }
        }

        //Retorno El tiempo de finalización - llegada(cuenta el de bloqueados)
        private string[] FormatoTerminados(Procesos p)
        {
            p.TiempoRetorno = p.TiempoFin - p.TiempoLlegada;
            p.TiempoEspera = p.TiempoRetorno - p.TiempoServicio;
            //              ID                  Estado            Operación                                                               Resultado       TME                     Llegada              Finalización                //Retorno                       //Espera                   //Respuesta                 //Tiempo de Servicio //Tiempo restante
            string[] row = { p.Id.ToString(), "Terminado", p.Num1.ToString() + " " + operador(p.Operacion) + " " + p.Num2.ToString(), p.Resultado, p.Tiempo.ToString(), p.TiempoLlegada.ToString(), p.TiempoFin.ToString(), p.TiempoRetorno.ToString(), p.TiempoEspera.ToString(), p.TiempoRespuesta.ToString(), p.TiempoServicio.ToString(), "0"};
            return row;
        }
        
        private string[] FormatoListos(Procesos p)
        {
            //p.TiempoEspera = p.TiempoRetorno - p.TiempoServicio - 1;
            p.TiempoRetorno = TiempoGlobal - p.TiempoLlegada - 1;
            string tiempoServicio = p.TiempoT == 0 ? "0" : (p.TiempoT-1).ToString();
            p.TiempoEspera = (TiempoGlobal - p.TiempoLlegada -1) - Int32.Parse(tiempoServicio);
            string tiempoRespuesta = p.TiempoRespuesta == -1 ? "Null" : p.TiempoRespuesta.ToString() ;
            string tiempoRestante = (p.Tiempo - Int32.Parse(tiempoServicio)).ToString();

            //              ID                  Operación                                                                     Resultado       TME                     Llegada        Finalización  //Retorno           //Espera             //Respuesta   //Tiempo de Servicio    //Tiempo restante
            string[] row = { p.Id.ToString(), "Listo", p.Num1.ToString() + " " + operador(p.Operacion) + " " + p.Num2.ToString(), "Null", p.Tiempo.ToString(), p.TiempoLlegada.ToString(), "Null", "Null", p.TiempoEspera.ToString(), tiempoRespuesta, tiempoServicio, tiempoRestante, "Null" };
            return row;
        }
        
        private string[] FormatoNuevos(Procesos p)
        {
            //              ID                  Operación                                                               Resultado               TME         Llegada/Finalización//Retorno//Espera//Respuesta//Tiempo de Servicio//Tiempo restante
            
            string[] row = { p.Id.ToString(), "Nuevo", p.Num1.ToString() + " " + operador(p.Operacion) + " " + p.Num2.ToString(), "Null", p.Tiempo.ToString(), "Null", "Null", "Null",       "0", "Null", "Null", p.Tiempo.ToString(), "Null" };
            return row;
        }
        
        private string[] FormatoEnEjecucion(Procesos p)
        {
            string tiempoServicio = (p.TiempoT-1).ToString() == "-1" ? "0" : (p.TiempoT - 1).ToString();
            p.TiempoEspera = (TiempoGlobal - p.TiempoLlegada - 1) - Int32.Parse(tiempoServicio);
            string tiempoRespuesta = p.TiempoRespuesta == -1 ? "Null" : p.TiempoRespuesta.ToString();
            string tiempoRestante = (p.Tiempo - Int32.Parse(tiempoServicio)).ToString();
            //              ID                  Operación                                                                     Resultado       TME                     Llegada        Finalización  //Retorno           //Espera             //Respuesta   //Tiempo de Servicio    //Tiempo restante
            string[] row = { p.Id.ToString(), "En ejecución", p.Num1.ToString() + " " + operador(p.Operacion) + " " + p.Num2.ToString(), "Null", p.Tiempo.ToString(), p.TiempoLlegada.ToString(), "Null", "Null", p.TiempoEspera.ToString(), tiempoRespuesta, tiempoServicio, tiempoRestante, "Null" };
            return row;
        }

        private string[] FormatoBloqueados(Procesos p)
        {
            string tiempoServicio = (p.TiempoT - 1).ToString();
            p.TiempoEspera = (TiempoGlobal - p.TiempoLlegada - 1) - Int32.Parse(tiempoServicio);
            string tiempoRespuesta = p.TiempoRespuesta == -1 ? "Null" : p.TiempoRespuesta.ToString();
            string tiempoRestante = (p.Tiempo - Int32.Parse(tiempoServicio)).ToString();
            //              ID                  Operación                                                                     Resultado       TME                     Llegada        Finalización  //Retorno           //Espera             //Respuesta   //Tiempo de Servicio    //Tiempo restante //Tiempo en bloqueado
            string[] row = { p.Id.ToString(), "Bloqueado", p.Num1.ToString() + " " + operador(p.Operacion) + " " + p.Num2.ToString(), "Null", p.Tiempo.ToString(), p.TiempoLlegada.ToString(), "Null", "Null", p.TiempoEspera.ToString(), tiempoRespuesta, tiempoServicio, tiempoRestante, tiempoBloqueado[p.Id - 1].ToString() };
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

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
            {
                this.Close();
            }
        }
    }
}
