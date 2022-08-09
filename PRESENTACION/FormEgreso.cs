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

        public FormEgreso(int Med_Codigo, string MedNombre, string DNI, string Almacen, string Tipo, byte CodigoFilial)
        {
            InitializeComponent();
            this.Med_Codigo = Med_Codigo;
            this.MedNombre = MedNombre;
            this.Almacen = Almacen;
            this.Tipo = Tipo;
            this.DNI = DNI;
            this.CodigoFilial = CodigoFilial;
            ObtenerIngresoEgreso();
        }

        Consultas consultas = new Consultas();

        int Med_Codigo;
        string MedNombre;
        string Almacen;
        string Tipo;
        readonly string DNI;
        readonly byte CodigoFilial;

        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int Ingreso = 0;
        int Egreso = 0;
        void ObtenerIngresoEgreso()
        {
            DataTable dt = new DataTable();
            dt = consultas.D_Detalles_Medicamento(Med_Codigo);
            //lbl_Nombre.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["COMPOSICIÒN"].ToString();
            //int Ingreso = (int)consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL INGRESADO"];
            //int Egreso = (int)consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL EGRESADO"];
            lbl_Nombre.Text = dt.Rows[0][0].ToString();
            Ingreso = (int)dt.Rows[0][1];
            Egreso = (int)dt.Rows[0][2];

            LblStock.Text = (Ingreso - Egreso).ToString();
        }

        private bool ValidacionStock()
        {
            if (txtCantidad.Text.Length != 0)
            {
                errorProvider1.SetError(txtCantidad, "Ingrese una cantidad.");
                return false;
            }
            if (int.Parse(txtCantidad.Text) == 0)
            {
                errorProvider1.SetError(txtCantidad, "Ingrese una cantidad.");
                return false;
            }
            if (int.Parse(DgvStock.Rows[fila].Cells[0].Value.ToString()) < int.Parse(txtCantidad.Text)) //Stock<Cantidad
            {
                errorProvider1.SetError(txtCantidad, "Ha superado el stock.");
                return false;
            }
            return true;
        }
        //Boton Confirmar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ValidacionStock())
            {

                int Existencias = Ingreso - Egreso;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                if (cantidad <= Existencias)
                {
                    Ingreso = 0;
                    Egreso = 0;
                    FormMedicamentos FrmMedicamentos = Owner as FormMedicamentos;
                    FrmMedicamentos.EnviarEgreso(Med_Codigo, MedNombre, int.Parse(txtCantidad.Text), Almacen, Tipo, int.Parse(DgvStock.Rows[fila].Cells[0].Value.ToString()), DgvStock.Rows[fila].Cells[1].Value.ToString(), DgvStock.Rows[fila].Cells[3].Value.ToString());

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
                //else
                //{
                //    MessageBox.Show("La cantidad supera el Stock.", "Advertencia");
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

        private void FormEgreso_Load(object sender, EventArgs e)
        {
            DgvStock.DataSource = consultas.D_Lista_Stock(Med_Codigo);
        }

        int fila = 0;
        private void DgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                fila = e.RowIndex;

            }
        }
    }
}
