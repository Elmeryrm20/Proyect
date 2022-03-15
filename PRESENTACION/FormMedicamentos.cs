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

        int valor_ID = 0;
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

        private void dgb_Medicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            valor_ID =(int)dgb_Medicamentos.CurrentRow.Cells[0].Value;
            label2.Text = valor_ID.ToString();
        }

        private void btn_Detalles_Click(object sender, EventArgs e)
        {
            FormDetallesMedicamento frm = new FormDetallesMedicamento(valor_ID);
            frm.ShowDialog();
        }
    }
}
