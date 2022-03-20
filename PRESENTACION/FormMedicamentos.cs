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
            
           
        }
        public FormMedicamentos(string DNI)
        {
            InitializeComponent();
            this.DNI = DNI;
            rellenartabla();
            Elementos_Filtrar();
           
        }
        readonly string DNI;
        void rellenartabla()
        {
            dgb_Medicamentos.DataSource = consultas.ConsultaMed();
            dgb_Medicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void Elementos_Filtrar()
        {
            cmbTipo.DisplayMember = "tip_descripcion";
            cmbTipo.DataSource = consultas.tipo();
        }
        int valor_ID = 1;
        private void FormMedicamentos_Load(object sender, EventArgs e)
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
            rellenartabla();
            txb_Buscar.Clear();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormIngreso frm = new FormIngreso(valor_ID, DNI);
            frm.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormEgreso frm = new FormEgreso(valor_ID,DNI);
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormEditarProducto frm = new FormEditarProducto(valor_ID);
            frm.ShowDialog();

        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            label4.Text= cmbTipo.SelectedText.ToString();
            dgb_Medicamentos.DataSource= consultas.SP_Consulta_Medicamento_Filtrado(cmbTipo.SelectedText.ToString());
        }
    }
}
