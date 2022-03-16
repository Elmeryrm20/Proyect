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
            consultas.D_Insertar_Trabajador(txtDocumento.Text ,( txtNombre.Text).ToUpper(),(txtApellido.Text).ToUpper(), dtpFecha_Nacimiento.Value.ToString("yyyy-MM-dd"), txtCorreo.Text, txtTelefono.Text, cmbTipoDocumento.SelectedIndex + 1, cmb_Cargo.SelectedIndex + 1);
            MessageBox.Show("Datos Ingresados Correctamente.", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
