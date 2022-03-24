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

        }
        public FormAgregarUsuario(string DNI)
        {
            InitializeComponent();
            this.DNI = DNI;
            ObtenerCaja();
            ObtenerCargoTra();
        }

        string DNI;
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
            string Existencia = consultas.SP_Existencia_T(txtDocumento.Text).Rows[0]["Tra_DNI"].ToString();
            BorrarMss();
            if (ValidarDoc())
            {
                if (Existencia ==null)
                {
                    consultas.D_Insertar_Trabajador(txtDocumento.Text, (txtNombre.Text).ToUpper(), (txtApellido.Text).ToUpper(), dtpFecha_Nacimiento.Value.ToString("yyyy-MM-dd"), txtCorreo.Text, txtTelefono.Text, cmbTipoDocumento.SelectedIndex + 1, cmb_Cargo.SelectedIndex + 1);
                    MessageBox.Show("Datos Ingresados Correctamente.", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                   
                }
                else
                {
                    DialogResult result = MessageBox.Show("El usuario " + Existencia + " estubo registrado desea activarle la cuenta", "Excelente!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        consultas.SP_Eliminar_U(Existencia, 1);
                        consultas.SP_Restablecer_C(Existencia);
                        MessageBox.Show("Usuario restaurado", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                       
                    }
                }
            }
        }

        

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
            if (dtpFecha_Nacimiento.Text == DateTime.Now.ToString("d"))
            {
                errorProvider1.SetError(dtpFecha_Nacimiento, "Por favor, ingrese una fecha");
                doc = false;
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
            errorProvider1.SetError(dtpFecha_Nacimiento, "");
        }

        private void dtpFecha_Nacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
