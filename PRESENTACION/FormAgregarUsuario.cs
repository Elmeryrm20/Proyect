using DATOS;
using System;
using System.Windows.Forms;


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
            cmbTipoDocumento.Text = "Seleccione Documento ..";
            cmb_Cargo.Text = "Selecione Cargo..";
            dtpFecha_Nacimiento.MaxDate = DateTime.Now.Date;
            dtpFecha_Nacimiento.Value = DateTime.Now.Date;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BorrarMss();
            try
            {
                //En Caso no Devuelva nada se pasara al catch
                string Existencia = consultas.SP_Existencia_T(txtDocumento.Text).Rows[0]["Tra_DNI"].ToString();
                if (ValidarDoc())
                {
                    DialogResult result = MessageBox.Show("El usuario " + Existencia + " estubo registrado desea activarle la cuenta", "Información", MessageBoxButtons.YesNo);
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
            catch (Exception)
            {
                if (ValidarDoc())
                {
                    consultas.D_Insertar_Trabajador(txtDocumento.Text, (txtNombre.Text).ToUpper(), (txtApellido.Text).ToUpper(), dtpFecha_Nacimiento.Value.ToString("yyyy-MM-dd"), txtCorreo.Text, txtTelefono.Text, cmbTipoDocumento.SelectedIndex + 1, cmb_Cargo.SelectedIndex + 1);
                    MessageBox.Show("Datos Ingresados Correctamente.", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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
            if (cmb_Cargo.Text == "Selecione Cargo..")
            {
                doc = false;
                errorProvider1.SetError(cmb_Cargo, "Datos correctos");
            }

            if (cmbTipoDocumento.Text == "Seleccione Documento ..")
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

        private void PibAgregarUsuario_MouseEnter(object sender, EventArgs e)
        {
            PibAgregarUsuario.Image = Properties.Resources.BotonFormConfirmarNuevoUsu04;
        }

        private void PibAgregarUsuario_MouseLeave(object sender, EventArgs e)
        {
            PibAgregarUsuario.Image = Properties.Resources.BotonFormConfirmarNuevoUsu03;

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetterOrDigit(e.KeyChar)) e.Handled = false;
            else if (char.IsControl(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar("@"))e.Handled = false;
            else if (e.KeyChar == Convert.ToChar(".")) e.Handled = false;
            else if (e.KeyChar == Convert.ToChar("_")) e.Handled = false;
            else if (e.KeyChar == Convert.ToChar("-")) e.Handled = false;
            else if (char.IsLetterOrDigit(e.KeyChar)) e.Handled = false;
            else if (char.IsControl(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombres")
            {
                txtNombre.Text = "";
            }
        }

        private void txtDocumento_Click(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "N° Documento")
            {
                txtDocumento.Text = "";
            }
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellidos")
            {
                txtApellido.Text = "";
            }
        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
            }
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Teléfono")
            {
                txtTelefono.Text = "";
            }
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "")
            {
                txtDocumento.Text = "N° Documento";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombres";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellidos";
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Teléfono";
            }
        }
    }
}
