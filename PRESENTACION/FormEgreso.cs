using DATOS;
using System;
using System.Data;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormEgreso : Form
    {
        public FormEgreso()
        {
            InitializeComponent();
        }

        public FormEgreso(int Med_Codigo, string DNI)
        {
            InitializeComponent();
            this.Med_Codigo = Med_Codigo;
            this.DNI = DNI;
            ObtenerIngresoEgreso();
        }

        Consultas consultas = new Consultas();

        int Med_Codigo;
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
            dt = consultas.D_Medicamento_Detallado(Med_Codigo);
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
                //FormPrincipal Principal = (FormPrincipal)Owner;

                FormPrincipal Principal = Owner as FormPrincipal;

                //FormMedicamentos Secundario = (FormMedicamentos)Owner;
                //Secundario

                //FormPrincipal Principal = (FormPrincipal)Owner;

                Principal.SeleccionarBoton(9);
                Principal.AparecerFormulario<FormSalidaMedicamentos>();

                FormSalidaMedicamentos fr = new FormSalidaMedicamentos();
                int n = fr.DgvSalida.Rows.Add();

                //Colocamos la información
                fr.DgvSalida.Rows[n].Cells[0].Value = Med_Codigo;


                //int Existencias = Ingreso - Egreso;
                //int cantidad = Convert.ToInt32(txtCantidad.Text);
                //if (cantidad <= Existencias)
                //{
                //    //consultas.SP_Agregar_Egreso_Medicamento(Med_Codigo, cantidad);
                //    consultas.D_ActualizarEgreso(Med_Codigo, cantidad);

                //    consultas.SP_Agregar_Detalle_Egreso(Med_Codigo, cantidad, DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH-mm-ss"), DNI, 4);
                //    MessageBox.Show("Actualización Exitosa");
                //    Ingreso = 0;
                //    Egreso = 0;
                //    FormMedicamentos FrmMed = Owner as FormMedicamentos;
                //    FrmMed.Rellenartabla();
                //    FrmMed.dgb_Medicamentos.CurrentCell = FrmMed.dgb_Medicamentos.Rows[Med_Codigo - 1].Cells[0];
                //    Close();
                //}

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
