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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DgvHistorialEgreso.DataSource = du.Sp_Filtro_Fecha_HE(dtp_FechaI.Value.ToString("yyyy-MM-dd"), dtp_FechaF.Value.ToString("yyyy-MM-dd"));
            DgvHistorialEgreso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
