using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DATOS;

namespace PRESENTACION
{
    public partial class FormMedicamentos : Form
    {
        Consultas consultas = new Consultas();
        public FormMedicamentos()
        {
            InitializeComponent();
            rellenartabla();
            
           
        }
        void rellenartabla()
        {
            dgb_Medicamentos.DataSource = consultas.ConsultaMed();
            dgb_Medicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
       
       
        private void FormMedicamentos_Load(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable dt = consultas.D_Consulta_Dinamica(txb_Buscar.Text);
            dgb_Medicamentos.DataSource = dt;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
