using DATOS;
using System;
using System.Data;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormEgreso : Form
    {
        Consultas consultas = new Consultas();
        public FormEgreso()
        {
            InitializeComponent();


        }

        public FormEgreso(int valor, string DNI)
        {
            InitializeComponent();
            this.valor = valor;
            this.DNI = DNI;
            ObtenerIngresoEgreso();
        }
        readonly int valor;
        readonly string DNI;
        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int Ingreso = 0;
        int Egreso = 0;
        void ObtenerIngresoEgreso()
        {
            DataTable dt = new DataTable();
            dt = consultas.D_Medicamento_Detallado(valor);
            //lbl_Nombre.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["COMPOSICIÒN"].ToString();
            //int Ingreso = (int)consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL INGRESADO"];
            //int Egreso = (int)consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL EGRESADO"];
            lbl_Nombre.Text = dt.Rows[0][0].ToString();
            Ingreso = (int)dt.Rows[0][1];
            Egreso = (int)dt.Rows[0][2];

            LblStock.Text = (Ingreso - Egreso).ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (txtCantidad.Text.Length != 0)
            {

                try
                {
                    //int Ingreso = (int)consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL INGRESADO"];
                    //int Egreso = (int)consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL EGRESADO"];

                    int Existencias = Ingreso - Egreso;
                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    if (Convert.ToInt32(txtCantidad.Text) <= Existencias)
                    {
                        consultas.SP_Agregar_Egreso_Medicamento(valor, cantidad);
                        consultas.SP_Agregar_Detalle_Egreso(valor, cantidad, DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH-mm-ss"), DNI, 4);
                        MessageBox.Show("Actualizacion Exitosa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Ingreso = 0;
                        Egreso = 0;
                        FormMedicamentos FrmMed = Owner as FormMedicamentos;
                        FrmMed.Rellenartabla();
                        FrmMed.dgb_Medicamentos.CurrentCell = FrmMed.dgb_Medicamentos.Rows[valor - 1].Cells[0];
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Los productos exeden al stock del mediacamento", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Ingrese Campo", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }


    }
}
