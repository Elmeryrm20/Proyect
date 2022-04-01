using DATOS;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormSalidaMedicamentos : Form
    {
        public FormSalidaMedicamentos()
        {
            InitializeComponent();
        }

        public FormSalidaMedicamentos(string DNI, string Nombre)
        {
            this.DNI = DNI;
            InitializeComponent();
            //this.Nombre = Nombre;
            LblVoluntario.Text = Nombre;

        }
        readonly string DNI;
        Consultas consultas = new Consultas();

        private void PibAgregarMed_Click(object sender, System.EventArgs e)
        {
            FormPrincipal Principal = (FormPrincipal)Owner;
            Principal.SeleccionarBoton(2);
            //Principal.AparecerFormulario<FormMedicamentos>();
            Principal.EscogerFormulario<FormMedicamentos>(2);
            Principal.ResaltarBotonEgreso();
        }


        private bool Validacion()
        {
            if (CmbEncargado.SelectedIndex == -1 || CmbEncargado.Text == "Seleccionar")
            {
                errorProvider1.SetError(CmbEncargado, "Seleccione un coordinador");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font1 = new Font("Arial", 10);
            Font font2 = new Font("Arial", 7);
            int ancho = 450;
            int y = 20;

            //VOUCHER
            e.Graphics.DrawString("  ---Informe Egreso---", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("  RUC: " + "10427462264", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("  --- CRUZ ROJA - FILIAL ICA ---", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("  Dirección", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("  ICA - ICA - ICA", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            //e.Graphics.DrawString("", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("-------------------------------------", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("  FECHA DE EMISIÓN: " + DateTime.Now.ToShortDateString(), font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            //e.Graphics.DrawString("", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("  Coordinador: " + CmbEncargado.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("  Voluntario: " + LblVoluntario.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("-------------------------------------", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("  ---Medicamentos---", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("  Código    Can.  Descripción   Pre. Uni.   Importe Total", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            //e.Graphics.DrawString("", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            int fila = DgvSalida.RowCount;
            string texto = "";
            for (int i = 0; i < fila; i++)
            {
                texto = DgvSalida.Rows[i].Cells[0].Value.ToString() + "   " + DgvSalida.Rows[i].Cells[1].Value.ToString() + "   ";
                e.Graphics.DrawString(texto, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            }
            e.Graphics.DrawString("------------------------------------", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("  Gracias por su compra. Vuelva Pronto.", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));


        }

        private void ImprimirEgreso()
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void ConfirmarEgreso(bool BoolImprimir)
        {
            if (Validacion() == true)
            {
                if (DgvSalida.Rows.Count > 0)
                {
                    string fecha = DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH-mm-ss");

                    string CodigoEgreso = consultas.D_ActualizarEgreso(fecha, DNI, null);

                    consultas.AbrirConexion();
                    for (int i = 0; i < DgvSalida.Rows.Count; i++)
                    {
                        //codigo
                        //nombre
                        //cantidad
                        consultas.SP_Agregar_Detalle_Egreso(int.Parse(CodigoEgreso), int.Parse(DgvSalida.Rows[i].Cells[0].Value.ToString()), int.Parse(DgvSalida.Rows[i].Cells[2].Value.ToString()), 4); ;
                    }
                    consultas.CerrarConexion();

                    if (BoolImprimir == true)
                    {
                        ImprimirEgreso();
                    }

                    MessageBox.Show("Actualización Exitosa");

                    Limpiar();



                    //    FormMedicamentos FrmMed = Owner as FormMedicamentos;
                    //    FrmMed.Rellenartabla();
                    //    FrmMed.dgb_Medicamentos.CurrentCell = FrmMed.dgb_Medicamentos.Rows[Med_Codigo - 1].Cells[0];
                    //    Close();
                }
                else
                {
                    MessageBox.Show("Agregue al menos un medicamento en la tabla.", "Información",MessageBoxButtons.OK);
                    PibAgregarMed.Image = Properties.Resources.BotonFormSeleccionarMed05;
                    DgvSalida.Focus();
                }
            }
        }

        private void PibConfirmar_Click(object sender, System.EventArgs e)
        {
            ConfirmarEgreso(false);
        }

        private void Limpiar()
        {
            CmbColaborador.SelectedIndex = -1;
            CmbColaborador.Text = "Seleccionar";
            CmbEncargado.SelectedIndex = -1;
            CmbEncargado.Text = "Seleccionar";
            DgvSalida.Rows.Clear();
            PibAgregarMed.Image = Properties.Resources.BotonFormSeleccionarMed05;
            PibConfirmar.Image = Properties.Resources.BotonFormConfirmarSalida06;
            errorProvider1.Clear();
            fila = -1;


        }

        private void FormSalidaMedicamentos_Load(object sender, System.EventArgs e)
        {
            CmbColaborador.DisplayMember = "Trabajador";
            CmbColaborador.DataSource = consultas.D_MostrarColaboradores(DNI);
            //CmbColaborador.ValueMember = "Colaborador_Desc";
            CmbColaborador.Text = "Seleccionar";

            CmbEncargado.DisplayMember = "Trabajador";
            CmbEncargado.DataSource = consultas.D_MostrarColaboradores(DNI);
            //CmbEncargado.ValueMember = "Encargado_Desc";
            CmbEncargado.Text = "Seleccionar";

            DesignDataGridView();

        }

        private void PibAgregarMed_MouseEnter(object sender, EventArgs e)
        {
            PibAgregarMed.Image = Properties.Resources.BotonFormSeleccionarMed04;

        }

        private void PibAgregarMed_MouseLeave(object sender, EventArgs e)
        {
            PibAgregarMed.Image = Properties.Resources.BotonFormSeleccionarMed03;

        }

        private void PibConfirmar_MouseEnter(object sender, EventArgs e)
        {
            PibConfirmar.Image = Properties.Resources.BotonFormConfirmarSalida09;

        }

        private void PibConfirmar_MouseLeave(object sender, EventArgs e)
        {
            PibConfirmar.Image = Properties.Resources.BotonFormConfirmarSalida08;

        }

        private void PibEliminarMed_MouseEnter(object sender, EventArgs e)
        {
            PibEliminarMed.Image = Properties.Resources.BotonFormAgregarQuitar04;

        }

        private void PibEliminarMed_MouseLeave(object sender, EventArgs e)
        {
            PibEliminarMed.Image = Properties.Resources.BotonFormAgregarQuitar03;

        }

        private void PibLimpiar_MouseEnter(object sender, EventArgs e)
        {
            PibLimpiar.Image = Properties.Resources.BotonFormLimpiar04;

        }

        private void PibLimpiar_MouseLeave(object sender, EventArgs e)
        {
            PibLimpiar.Image = Properties.Resources.BotonFormLimpiar03;

        }

        private void PibGuardarImprimir_MouseEnter(object sender, EventArgs e)
        {
            PibGuardarImprimir.Image = Properties.Resources.BotonFormConfirmarImprimir02;

        }

        private void PibGuardarImprimir_MouseLeave(object sender, EventArgs e)
        {
            PibGuardarImprimir.Image = Properties.Resources.BotonFormConfirmarImprimir01;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        private void DesignDataGridView()
        {
            DgvSalida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvSalida.Columns[0].Visible = false;
            //dgb_Medicamentos.Columns[0].Width = 25;
            //dgb_Medicamentos.Columns[0].MinimumWidth = 25;
            //dgb_Medicamentos.Columns[1].Width = 250;
            DgvSalida.ColumnHeadersHeight = 35;
            DgvSalida.Columns[1].MinimumWidth = 250;
            DgvSalida.Columns[3].MinimumWidth = 90;
            DgvSalida.RowHeadersWidth = 35;

        }

        private void PibLimpiar_Click(object sender, EventArgs e)
        {
            DesignDataGridView();
            Limpiar();
        }

        private void TxtNumDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar("-") == e.KeyChar)
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        public short fila = -1;
        private void DgvSalida_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = (short)e.RowIndex;

        }

        private void PibEliminarMed_Click(object sender, EventArgs e)
        {
            if (fila >= 0)
            {
                DgvSalida.Rows.RemoveAt(fila);
                fila = -1;
            }
        }

        private void CmbEncargado_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void CmbColaborador_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PibGuardarImprimir_Click(object sender, EventArgs e)
        {
            ConfirmarEgreso(true);
        }
    }
}
