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
            dtpFecha_Nacimiento.MaxDate = DateTime.Now;
            dtpFecha_Nacimiento.Value = DateTime.Now;
        }
    }
}
