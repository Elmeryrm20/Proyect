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

        int valor;
        readonly string DNI;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Ingreso()
        {
            lbl_Nombre.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["COMPOSICIÒN"].ToString();
        }

        //Botone de Ingresar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(Txt_Cantidad.Text);
            try
            {
                consultas.SP_Agregar_Ingreso_Medicamento(valor, cantidad, dtp_FechaVencimiento.Value.ToString("yyyy-MM-dd"));
                consultas.SP_Agregar_Detalle_Ingreso(valor, cantidad, DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH-mm-ss"), DNI, dtp_FechaVencimiento.Value.ToString("yyyy-MM-dd"));
                MessageBox.Show("Actualizacion Exitosa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                FormMedicamentos FrmMed = Owner as FormMedicamentos;
                FrmMed.Rellenartabla();
                FrmMed.dgb_Medicamentos.CurrentCell = FrmMed.dgb_Medicamentos.Rows[valor-1].Cells[0];
                Close();
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
