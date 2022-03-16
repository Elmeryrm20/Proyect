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
    public partial class FormAgregarUsuario : Form
    {
        Consultas consultas = new Consultas();
        public FormAgregarUsuario()
        {
            InitializeComponent();
            ObtenerCaja();
            ObtenerCargoTra();
        }
        void ObtenerCaja()
        {
            cmbTipoDocumento.DisplayMember = "Tid_Descripcion";
            cmbTipoDocumento.DataSource = consultas.D_TipoDNI();

        }
        void ObtenerCargoTra()
        {
            cmb_Cargo.DisplayMember = "Car_Descripcion";
            cmb_Cargo.DataSource = consultas.D_CargoTrabajador();

        }
        private void FormAgregarUsuario_Load(object sender, EventArgs e)
        {
            dtpFecha_Nacimiento.MaxDate = DateTime.Now.Date;
            dtpFecha_Nacimiento.Value = DateTime.Now.Date;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ValidarTipoDoc();
            ValidarDoc();
            ValidarNombre();
            ValidarApellido();
            ValidarCargo();
            
            consultas.D_Insertar_Trabajador(txtDocumento.Text ,( txtNombre.Text).ToUpper(),(txtApellido.Text).ToUpper(), dtpFecha_Nacimiento.Value.ToString("yyyy-MM-dd"), txtCorreo.Text, txtTelefono.Text, cmbTipoDocumento.SelectedIndex + 1, cmb_Cargo.SelectedIndex + 1);
            MessageBox.Show("Datos Ingresados Correctamente.", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private bool ValidarTipoDoc()
        {
            bool tipodoc = true;
            if (cmbTipoDocumento.Text == "")
            {
                tipodoc = false;
                errorProvider1.SetError(cmbTipoDocumento, "Ingresar Tipo de Documento");
                
            }
            else
            {
                errorProvider1.Clear();
            }
            return tipodoc;
        }

        private bool ValidarDoc()
        {
            bool doc = true;
            if (txtDocumento.Text == "")
            {
                doc = false;
                errorProvider1.SetError(txtDocumento, "Ingresar Documento");

            }
            else
            {
                errorProvider1.Clear();
            }
            return doc;
        }
        private bool ValidarNombre()
        {
            bool nombre = true;
            if (txtNombre.Text == "")
            {
                nombre = false;
                errorProvider1.SetError(txtNombre, "Ingresar Nombre");

            }
            else
            {
                errorProvider1.Clear();
            }
            return nombre;
        }
        private bool ValidarApellido()
        {
            bool apellido = true;
            if (txtApellido.Text == "")
            {
                apellido = false;
                errorProvider1.SetError(txtApellido, "Ingresar Apellido");

            }
            else
            {
                errorProvider1.Clear();
            }
            return apellido;
        }
        private bool ValidarCargo()
        {
            bool cargo = true;
            if (cmb_Cargo.Text == "")
            {
                cargo = false;
                errorProvider1.SetError(cmb_Cargo, "Ingresar Cargo");
            }
            else
            {
                errorProvider1.Clear();
            }
            return cargo;
        }
        


        private void dtpFecha_Nacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
