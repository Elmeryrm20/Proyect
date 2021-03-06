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

        public FormEgreso(int Med_Codigo, string MedNombre, string DNI, string Almacen, string Tipo)
        {
            InitializeComponent();
            this.Med_Codigo = Med_Codigo;
            this.MedNombre = MedNombre;
            this.Almacen = Almacen;
            this.Tipo = Tipo;
            this.DNI = DNI;
            ObtenerIngresoEgreso();
        }

        Consultas consultas = new Consultas();

        int Med_Codigo;
        string MedNombre;
        string Almacen;
        string Tipo;
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

        //Boton Confirmar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Length != 0)
            {
                int Existencias = Ingreso - Egreso;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                if (cantidad <= Existencias)
                {
                    Ingreso = 0;
                    Egreso = 0;
                    FormMedicamentos FrmMedicamentos = Owner as FormMedicamentos;
                    FrmMedicamentos.EnviarEgreso(Med_Codigo, MedNombre, int.Parse(txtCantidad.Text),Almacen,Tipo);

                    Close();

                    //    //consultas.SP_Agregar_Egreso_Medicamento(Med_Codigo, cantidad);
                    //    consultas.D_ActualizarEgreso(Med_Codigo, cantidad);

                    //    consultas.SP_Agregar_Detalle_Egreso(Med_Codigo, cantidad, DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH-mm-ss"), DNI, 4);
                    //    MessageBox.Show("Actualización Exitosa");

                    //    FormMedicamentos FrmMed = Owner as FormMedicamentos;
                    //    FrmMed.Rellenartabla();
                    //    FrmMed.dgb_Medicamentos.CurrentCell = FrmMed.dgb_Medicamentos.Rows[Med_Codigo - 1].Cells[0];
                    //    Close();
                }
                else
                {
                    MessageBox.Show("La cantidad supera el Stock.", "Advertencia");
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

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.BotonFormConfirmar04;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.BotonFormConfirmar03;
        }

        private void btnSerrar_MouseEnter(object sender, EventArgs e)
        {
            btnSerrar.Image = Properties.Resources.BotonFormCancelar06;

        }

        private void btnSerrar_MouseLeave(object sender, EventArgs e)
        {
            btnSerrar.Image = Properties.Resources.BotonFormCancelar05;

        }
    }
}
