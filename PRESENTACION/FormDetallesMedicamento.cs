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
    public partial class FormDetallesMedicamento : Form
    {
        Consultas consultas = new Consultas();
        public FormDetallesMedicamento()
        {
            InitializeComponent();
           
        }
        public FormDetallesMedicamento(int valor)
        {
            InitializeComponent();
            Medicamentos_Detallados(valor);
        }
        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void Medicamentos_Detallados(int valor )
        {
            dgb_detalles_M.DataSource = consultas.D_Medicamento_Detallado(valor);
            dgb_detalles_M.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

     
    }
}
