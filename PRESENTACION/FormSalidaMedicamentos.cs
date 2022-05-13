using DATOS;
using System;
using System.Data;
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
            if (CmbNacionalidad.SelectedIndex == -1 || CmbNacionalidad.Text == "Seleccionar")
            {
                errorProvider1.SetError(CmbNacionalidad, "Seleccione una Nacionalidad");
                return false;
            }
            return true;
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
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += Imprimir;
            ppd.ShowDialog();
        }

        private void ConfirmarEgreso(bool BoolImprimir)
        {
            if (Validacion() == true)
            {
                if (DgvSalida.Rows.Count > 0)
                {
                    string fecha = DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH-mm-ss");
                    byte semana = (byte)DateTime.Now.Day;
                    if (semana >= 1 && semana <= 7) semana = 1;
                    else if (semana > 7 && semana <= 14) semana = 2;
                    else if (semana > 14 && semana <= 21) semana = 3;
                    else if (semana > 21 && semana <= 28) semana = 4;
                    else semana = 5;

                    //string Colaborador;
                    //if (CmbColaborador.SelectedIndex < 0)
                    //{
                    //    Colaborador = "t1Mtbf8p";
                    //}
                    //else
                    //{
                    //    Colaborador = Colaboradores[CmbColaborador.SelectedIndex,0];
                    //}
                    consultas.D_ActualizarEgreso(fecha, DNI, CmbNacionalidad.Text, Colaboradores[CmbColaborador.SelectedIndex, 0], Coordinadores[CmbEncargado.SelectedIndex, 0]);
                    int CodigoEgreso = consultas.D_UltimoIdIngresado();

                    consultas.AbrirConexion();
                    for (int i = 0; i < DgvSalida.Rows.Count; i++)
                    {
                        //codigo
                        //nombre
                        //cantidad
                        consultas.SP_Agregar_Detalle_Egreso(CodigoEgreso, int.Parse(DgvSalida.Rows[i].Cells[0].Value.ToString()), int.Parse(DgvSalida.Rows[i].Cells[2].Value.ToString()), semana); ;
                    }
                    consultas.CerrarConexion();

                    if (BoolImprimir == true)
                    {
                        ImprimirEgreso();
                    }

                    MessageBox.Show("Actualización Exitosa");

                    Limpiar();

                    FormPrincipal FrmPrincipal = (FormPrincipal)Owner;
                    FrmPrincipal.CargarDashBoard();
                    FrmPrincipal.RellenarTablaMedicamentos();

                }
                else
                {
                    MessageBox.Show("Agregue al menos un medicamento en la tabla.", "Información", MessageBoxButtons.OK);
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
            //CmbColaborador.SelectedIndex = -1;
            //CmbColaborador.Text = "Seleccionar";
            //CmbEncargado.SelectedIndex = -1;
            //CmbEncargado.Text = "Seleccionar";

            CmbColaborador.SelectedIndex = 0;
            CmbEncargado.SelectedIndex = 0;
            //CmbNacionalidad.SelectedIndex = 0;
            CmbNacionalidad.Text = "Seleccionar";

            DgvSalida.Rows.Clear();
            PibAgregarMed.Image = Properties.Resources.BotonFormSeleccionarMed05;
            PibConfirmar.Image = Properties.Resources.BotonFormConfirmarSalida06;
            errorProvider1.Clear();
            fila = -1;


        }

        private string[,] Colaboradores;
        private string[,] Coordinadores;

        void RellenarPersonal()
        {
            DataTable dt_Colaborador = consultas.D_MostrarColaboradores(DNI);
            Colaboradores = new string[dt_Colaborador.Rows.Count, 2];
            for (int i = 0; i < dt_Colaborador.Rows.Count; i++)
            {
                Colaboradores[i, 0] = dt_Colaborador.Rows[i][0].ToString();
                Colaboradores[i, 1] = dt_Colaborador.Rows[i][1].ToString();
                CmbColaborador.Items.Add(Colaboradores[i, 1]);
            }

            DataTable dt_Coordinador = consultas.D_MostrarCoordinadores(DNI);
            Coordinadores = new string[dt_Coordinador.Rows.Count, 2];

            for (int i = 0; i < dt_Coordinador.Rows.Count; i++)
            {
                Coordinadores[i, 0] = dt_Coordinador.Rows[i][0].ToString();
                Coordinadores[i, 1] = dt_Coordinador.Rows[i][1].ToString();
                CmbEncargado.Items.Add(Coordinadores[i, 1]);
            }

            //CmbColaborador.Text = "Seleccionar";
            CmbColaborador.SelectedIndex = 0;
            //CmbEncargado.Text = "Seleccionar";
            CmbEncargado.SelectedIndex = 0;
        }
        private void FormSalidaMedicamentos_Load(object sender, System.EventArgs e)
        {
            RellenarPersonal();

            CmbNacionalidad.Items.Add("Peruano");
            CmbNacionalidad.Items.Add("Extranjero");
            //CmbNacionalidad.SelectedIndex = 0;

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
