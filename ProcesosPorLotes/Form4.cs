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
    public partial class Form4 : Form
    {

        AlmacenProcesos<Procesos> q = new AlmacenProcesos<Procesos>();
        int quantum;
        public Form4(AlmacenProcesos<Procesos> qu, int quantumValue)
        {
            InitializeComponent();
            q = qu;
            quantum = quantumValue;
            AgregarLista();
        }


        private void AgregarLista()
        {
            foreach (Procesos p in q.Cola)
            {
                dataGridView1.Rows.Add(Formato(p));
            }
        }
        //Retorno El tiempo de finalización - llegada(cuenta el de bloqueados)
        private string[] Formato(Procesos p)
        {
            p.TiempoRetorno = p.TiempoFin - p.TiempoLlegada;
            p.TiempoEspera = p.TiempoRetorno - p.TiempoServicio - 1;
            //              ID                  Operación                                                               Resultado       TME                     Llegada              Finalización                //Retorno                       //Espera                   //Respuesta                 //Tiempo de Servicio
            string[] row = { p.Id.ToString(), p.Num1.ToString() + " " + operador(p.Operacion) + " " + p.Num2.ToString(), p.Resultado, p.Tiempo.ToString(), p.TiempoLlegada.ToString(), p.TiempoFin.ToString(), p.TiempoRetorno.ToString(), p.TiempoEspera.ToString(), p.TiempoRespuesta.ToString(), p.TiempoServicio.ToString() };
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
