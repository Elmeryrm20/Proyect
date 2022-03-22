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
    public partial class FormControldeEntradas : Form
    {
        public FormControldeEntradas()
        {
            InitializeComponent();
            RellenarDataGridView();
        }

        Consultas du = new Consultas();

        private void RellenarDataGridView()
        {
            DgvHistorialIngreso.DataSource = du.D_HistorialIngreso();
            dgb_Control_Entradas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void PibActualizar_Click(object sender, EventArgs e)
        {
            RellenarDataGridView();

        }
    }
}
