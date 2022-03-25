using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS;

namespace PRESENTACION
{
    public partial class FormControldeSalidas : Form
    {
        public FormControldeSalidas()
        {
            InitializeComponent();
            RellenarDataGridView();
        }


        Consultas du = new Consultas();

        private void RellenarDataGridView()
        {
            DgvHistorialEgreso.DataSource = du.D_HistorialEgreso();
            DgvHistorialEgreso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void PibActualizar_Click(object sender, EventArgs e)
        {
            RellenarDataGridView();
            txt_Texto.Clear();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dtp_FechaI.Value.Date <= dtp_FechaF.Value.Date)
            {
                DgvHistorialEgreso.DataSource = du.Sp_Filtro_Fecha_HE(dtp_FechaI.Value.ToString("yyyy-MM-dd"), dtp_FechaF.Value.ToString("yyyy-MM-dd"));
                DgvHistorialEgreso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                txt_Texto.Clear();
                txt_Error.Visible = false;
            }
            else
            {
                txt_Error.Visible = true;
            }
        }

        private void txt_Texto_KeyUp(object sender, KeyEventArgs e)
        {
            DgvHistorialEgreso.DataSource = du.Sp_Filtro_Dinamico_HE(txt_Texto.Text);

        }
    }
}
