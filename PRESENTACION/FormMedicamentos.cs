using DATOS;
using System;
using System.Data;
using System.Windows.Forms;

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
            Almacen_Filtrar();

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
            cmbTipo.ValueMember = "tip_descripcion";
            cmbTipo.DataSource = consultas.tipo();
        }
        void Almacen_Filtrar()
        {
            cmb_Almacen.DisplayMember = "Alm_Descripcion";
            cmb_Almacen.ValueMember = "Alm_Descripcion";
            cmb_Almacen.DataSource = consultas.P_AlmMedicamento();
        }
        void Actualizar()
        {
            Rellenartabla();
            txb_Buscar.Clear();
            valor_ID = 1;
            cmbTipo.Text = "Seleccione Tipo";
            cmb_Almacen.Text = "Seleccione Caja";
        }
        #endregion

        #region Sin Usar
        private void FormMedicamentos_Load(object sender, EventArgs e)
        {
            cmbTipo.Text = "Seleccione Tipo";
            cmb_Almacen.Text = "Seleccione Caja";

        }
       
        #endregion

        #region Búsqueda,Filtro y obtener ID
        //Búsqueda Dinámica
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable dt = consultas.D_Consulta_Dinamica(txb_Buscar.Text);
            dgb_Medicamentos.DataSource = dt;
            cmbTipo.Text = "Seleccione Tipo";
            cmb_Almacen.Text = "Seleccione Caja";
        }

        //Botón Actualizar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        int valor_ID = 1;

        private void dgb_Medicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Botón Filtrar
        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                string Tipo = cmbTipo.SelectedValue.ToString();
                string Almacen = cmb_Almacen.SelectedValue.ToString();

                if (cmbTipo.Text != "Seleccione Tipo" && cmb_Almacen.Text != "Seleccione Caja")
                {
                    label4.Text = Tipo + " " + Almacen;
                    dgb_Medicamentos.DataSource = consultas.SP_Medicamento_Filtrado_Ambos(Almacen, Tipo);
                }
                else if (cmbTipo.Text != "Seleccione Tipo" && cmb_Almacen.Text == "Seleccione Caja")
                {
                    label4.Text = Tipo;
                    dgb_Medicamentos.DataSource = consultas.SP_Consulta_Medicamento_Filtrado(Tipo);
                }
                else if (cmbTipo.Text == "Seleccione Tipo" && cmb_Almacen.Text != "Seleccione Caja")
                {
                    label4.Text = Almacen;
                    dgb_Medicamentos.DataSource = consultas.SP_Medicamento_Filtrado_Almacen(Almacen);
                }
                else
                {
                    label4.Text = "NADA";
                }
                txb_Buscar.Clear();
            }
            catch (Exception)
            {

                label4.Text = "Error";
            }
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
            AddOwnedForm(frm4);
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

        private void cmb_Almacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
