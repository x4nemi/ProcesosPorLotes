using Sample;
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
    public partial class TablaDePaginas : Form
    {

        Memoria<Marco> Memoria;
        
        public TablaDePaginas(Memoria<Marco> m)
        {
            InitializeComponent();

            Memoria = m;

            this.KeyPreview = true;
        }

        private void TablaDePaginas_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Marco m in Memoria.Lista)
            {
                string[] row = { i.ToString(), m.ProcesoID.ToString(), m.Ocupados.ToString()+"/5", m.Estado };
                if(i % 2 == 0) {
                    dataGridView1.Rows.Add(row);
                    
                    
                }
                else
                {
                    dataGridView2.Rows.Add(row);
                }
                i++;
            }

            int j = 0;
            int index;
            foreach (Marco m in Memoria.Lista)
            {
                index = j % 2 == 0 ? j / 2 : (j-1) / 2;
                switch (m.Estado)
                {
                    case "Bloqueado":
                        if(j% 2 == 0)
                        {
                            dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            dataGridView2.Rows[index].Cells[2].Style.BackColor = Color.Red; 
                        }
                        break;
                    case "Disponible":
                        if (j % 2 == 0)
                        {
                            dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Green;
                        }
                        else
                        {
                            dataGridView2.Rows[index].Cells[2].Style.BackColor = Color.Green;
                        }
                        break;
                    case "SO":

                        if (j % 2 == 0)
                        {
                            dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Blue;
                        }
                        else
                        {
                            dataGridView2.Rows[index].Cells[2].Style.BackColor = Color.Blue;
                        }
                        break;
                    case "Listo":
                        if (j % 2 == 0)
                        {
                            dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            dataGridView2.Rows[index].Cells[2].Style.BackColor = Color.Yellow;
                        }
                        break;
                    case "En Proceso":
                        if (j % 2 == 0)
                        {
                            dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Orange;
                        }
                        else
                        {
                            dataGridView2.Rows[index].Cells[2].Style.BackColor = Color.Orange;
                        }
                        break;

                }
                j++;
            }
        }

        private void TablaDePaginas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.C)
            {
                this.Close();
            }
        }
    }
}
