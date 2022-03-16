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
            
            BorrarMss();
            if (ValidarDoc())
            {
                MessageBox.Show("Datos Ingresados Correctamente.", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                consultas.D_Insertar_Trabajador(txtDocumento.Text, (txtNombre.Text).ToUpper(), (txtApellido.Text).ToUpper(), dtpFecha_Nacimiento.Value.ToString("yyyy-MM-dd"), txtCorreo.Text, txtTelefono.Text, cmbTipoDocumento.SelectedIndex + 1, cmb_Cargo.SelectedIndex + 1);
            }
            
            
            
           
        }

        /*private void ValidarDoc()
        {
            while (txtDocumento.Text == "")
            {
                errorProvider1.SetError(txtDocumento, "Ingresar Documento");
                txtDocumento.Text = "";
            }
            while (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingresar Nombre");
            }
            while (txtApellido.Text == "")
            {
                errorProvider1.SetError(txtDocumento, "Ingresar Apellido");
            }
            while (txtDocumento.Text == "")
            {
                errorProvider1.SetError(txtDocumento, "Ingresar Documento");
            }
        }*/


        private bool ValidarDoc()
        {
            bool doc = true;
            if (txtDocumento.Text == "")
            {
                doc = false;
                errorProvider1.SetError(txtDocumento, "Ingresar Documento");
            }
            if (txtNombre.Text == "")
            {
                doc = false;
                errorProvider1.SetError(txtNombre, "Ingresar Nombre");
            }
            if (txtApellido.Text == "")
            {
                doc = false;
                errorProvider1.SetError(txtApellido, "Ingresar Apellido");
            }
            if (cmb_Cargo.Text == "")
            {
                doc = false;
                errorProvider1.SetError(cmb_Cargo, "Datos correctos");
            }
            
            if (cmbTipoDocumento.Text == "")
            {
                doc = false;
                errorProvider1.SetError(cmbTipoDocumento, "Ingresar Datos correctos");
            }
            else
            {

            }
            return doc;
        }
        private void BorrarMss()
        {
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtDocumento, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(cmbTipoDocumento, "");
            errorProvider1.SetError(cmb_Cargo, "");
        }

        private void dtpFecha_Nacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
