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
        #region Constructores
        public FormMedicamentos()
        {
            InitializeComponent();

        }
        public FormMedicamentos(string DNI)
        {
            InitializeComponent();
            this.DNI = DNI;
            Rellenartabla();
            Elementos_Filtrar();

        } 
        #endregion

        Consultas consultas = new Consultas();
        readonly string DNI;

        #region Métodos al cargar el formulario
        public void Rellenartabla()
        {
            dgb_Medicamentos.DataSource = consultas.ConsultaMed();
            dgb_Medicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void Elementos_Filtrar()
        {
            cmbTipo.DisplayMember = "tip_descripcion";
            cmbTipo.DataSource = consultas.tipo();
        } 
        #endregion

        #region Sin Usar
        private void FormMedicamentos_Load(object sender, EventArgs e)
        {


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        } 
        #endregion

        #region Búsqueda,Filtro y obtener ID
        //Búsqueda Dinámica
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable dt = consultas.D_Consulta_Dinamica(txb_Buscar.Text);
            dgb_Medicamentos.DataSource = dt;

        }

        //Botón Actualizar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Rellenartabla();
            txb_Buscar.Clear();
            valor_ID = 1;
        }

        int valor_ID = 1;

        private void dgb_Medicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //Botón Filtrar
        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            label4.Text= cmbTipo.SelectedText.ToString();
            dgb_Medicamentos.DataSource= consultas.SP_Consulta_Medicamento_Filtrado(cmbTipo.SelectedText.ToString());
        }
        #endregion

        #region Abrir Formularios
        //Abrir Formulario de Detalles
        private void btn_Detalles_Click(object sender, EventArgs e)
        {
            FormDetallesMedicamento frm1 = new FormDetallesMedicamento(valor_ID);
            frm1.ShowDialog();
        }

        //Abrir Formulario de Ingreso
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            FormIngreso frm2 = new FormIngreso(valor_ID, DNI);
            AddOwnedForm(frm2);
            frm2.ShowDialog();
        }

        //Abrir Formulario de Egreso
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormEgreso frm3 = new FormEgreso(valor_ID, DNI);
            AddOwnedForm(frm3);
            frm3.ShowDialog();
        }

        //Abrir Formulario de Editar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormEditarProducto frm4 = new FormEditarProducto(valor_ID);
            frm4.ShowDialog();

        }
        #endregion

        //Obtener Id del Medicamento
        private void dgb_Medicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valor_ID = (int)dgb_Medicamentos.CurrentRow.Cells[0].Value;
            LblIndice.Text = valor_ID.ToString();
        }

        private void PibDetalles_MouseEnter(object sender, EventArgs e)
        {
            PibDetalles.Image = Properties.Resources.BotonFormDetalles02;
        }

        private void PibIngreso_MouseEnter(object sender, EventArgs e)
        {
            PibIngreso.Image = Properties.Resources.BotonFormIngreso02;

        }

        private void PibDetalles_MouseLeave(object sender, EventArgs e)
        {
            PibDetalles.Image = Properties.Resources.BotonFormDetalles01;

        }

        private void PibIngreso_MouseLeave(object sender, EventArgs e)
        {
            PibIngreso.Image = Properties.Resources.BotonFormIngreso01;

        }

        private void PibSalida_MouseEnter(object sender, EventArgs e)
        {
            PibSalida.Image = Properties.Resources.BotonFormSalida02;

        }

        private void PibSalida_MouseLeave(object sender, EventArgs e)
        {
            PibSalida.Image = Properties.Resources.BotonFormSalida01;

        }

        private void PibEditar_MouseEnter(object sender, EventArgs e)
        {
            PibEditar.Image = Properties.Resources.BotonFormEditar02;

        }

        private void PibEditar_MouseLeave(object sender, EventArgs e)
        {
            PibEditar.Image = Properties.Resources.BotonFormEditar01;

        }

        private void PibActualizar_MouseEnter(object sender, EventArgs e)
        {
            PibActualizar.Image = Properties.Resources.BotonFormActualizar02;

        }

        private void PibActualizar_MouseLeave(object sender, EventArgs e)
        {
            PibActualizar.Image = Properties.Resources.BotonFormActualizar01;

        }

        private void Pib_Filtrar_MouseEnter(object sender, EventArgs e)
        {
            Pib_Filtrar.Image = Properties.Resources.BotonFormBusqueda02;

        }

        private void Pib_Filtrar_MouseLeave(object sender, EventArgs e)
        {
            Pib_Filtrar.Image = Properties.Resources.BotonFormBusqueda01;

        }
    }
}
