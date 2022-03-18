using DATOS;
using System;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormIngreso : Form
    {
        Consultas consultas = new Consultas();
        #region Constructores
        public FormIngreso()
        {
            InitializeComponent();
        }
        public FormIngreso(int valor, string DNI)
        {
            InitializeComponent();
            this.DNI = DNI;
            this.valor = valor;
            Ingreso();
        } 
        #endregion

        readonly int valor;
        readonly string DNI;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void Ingreso()
        {
            lbl_Nombre.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["COMPOSICIÒN"].ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                consultas.SP_Agregar_Ingreso_Medicamento(valor.ToString(), Txt_Cantidad.Text, dtp_FechaVencimiento.Value.ToString("yyyy-MM-dd"));
                consultas.SP_Agregar_Detalle_Ingreso(valor.ToString(), Txt_Cantidad.Text, DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH-mm-ss"), DNI, dtp_FechaVencimiento.Value.ToString("yyyy-MM-dd"));
                MessageBox.Show("Actualizacion Exitosa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Cagaste prro problemas de conexion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }
    }
}
