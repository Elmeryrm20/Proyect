using DATOS;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace PRESENTACION
{
    public partial class FormEntradaMedicamento : Form
    {
        public FormEntradaMedicamento()
        {
            InitializeComponent();
        }
        public FormEntradaMedicamento(string DNI, string Nombre)
        {
            InitializeComponent();
            this.DNI = DNI;
            LblVoluntario.Text = Nombre;

        }

        string DNI;
        Consultas consultas = new Consultas();

        private void PibAgregarMed_Click(object sender, EventArgs e)
        {
            FormPrincipal Principal = (FormPrincipal)Owner;
            Principal.SeleccionarBoton(2);
            //Principal.AparecerFormulario<FormMedicamentos>();
            Principal.EscogerFormulario<FormMedicamentos>(2);
            Principal.ResaltarBotonIngreso();
        }
        private void DesignDataGridView()
        {
            DgvEntrada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvEntrada.Columns[0].Visible = false;
            //dgb_Medicamentos.Columns[0].Width = 25;
            //dgb_Medicamentos.Columns[0].MinimumWidth = 25;
            //dgb_Medicamentos.Columns[1].Width = 250;
            DgvEntrada.ColumnHeadersHeight = 35;
            DgvEntrada.Columns[1].MinimumWidth = 230;
            DgvEntrada.Columns[3].MinimumWidth = 90;
            DgvEntrada.Columns[5].MinimumWidth = 90;
            DgvEntrada.Columns[2].HeaderText = "Cant.";
            DgvEntrada.RowHeadersWidth = 35;

        }

        public short fila = -1;
        private void Limpiar()
        {
            //CmbColaborador.SelectedIndex = -1;
            //CmbColaborador.Text = "Seleccionar";
            //CmbEncargado.SelectedIndex = -1;
            //CmbEncargado.Text = "Seleccionar";

            CmbColaborador.SelectedIndex = 0;
            CmbEncargado.SelectedIndex = 0;
            DgvEntrada.Rows.Clear();
            PibAgregarMed.Image = Properties.Resources.BotonFormSeleccionarMed05;
            PibConfirmar.Image = Properties.Resources.BotonFormConfirmarEntrada01;
            errorProvider1.Clear();
            fila = -1;


        }
        private void PibLimpiar_Click(object sender, EventArgs e)
        {
            DesignDataGridView();
            Limpiar();
        }

        private void PibEliminarMed_Click(object sender, EventArgs e)
        {
            if (fila >= 0)
            {
                DgvEntrada.Rows.RemoveAt(fila);
                fila = -1;
            }
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

        private void FormEntradaMedicamento_Load(object sender, EventArgs e)
        {

            RellenarPersonal();

            DesignDataGridView();
        }

        private void PibAgregarMed_MouseEnter(object sender, EventArgs e)
        {
            PibAgregarMed.Image = Properties.Resources.BotonFormSeleccionarMed07;
        }

        private void PibAgregarMed_MouseLeave(object sender, EventArgs e)
        {
            PibAgregarMed.Image = Properties.Resources.BotonFormSeleccionarMed06;

        }

        private void PibConfirmar_MouseEnter(object sender, EventArgs e)
        {
            PibConfirmar.Image = Properties.Resources.BotonFormConfirmarEntrada02;

        }

        private void PibConfirmar_MouseLeave(object sender, EventArgs e)
        {
            PibConfirmar.Image = Properties.Resources.BotonFormConfirmarEntrada01;

        }

        private void PibGuardarImprimir_MouseEnter(object sender, EventArgs e)
        {
            PibGuardarImprimir.Image = Properties.Resources.BotonFormConfirmarImprimir04;

        }

        private void PibGuardarImprimir_MouseLeave(object sender, EventArgs e)
        {
            PibGuardarImprimir.Image = Properties.Resources.BotonFormConfirmarImprimir03;

        }

        private void PibEliminarMed_MouseEnter(object sender, EventArgs e)
        {
            PibEliminarMed.Image = Properties.Resources.BotonFormAgregarQuitar06;

        }

        private void PibEliminarMed_MouseLeave(object sender, EventArgs e)
        {
            PibEliminarMed.Image = Properties.Resources.BotonFormAgregarQuitar05;

        }

        private void PibLimpiar_MouseEnter(object sender, EventArgs e)
        {
            PibLimpiar.Image = Properties.Resources.BotonFormLimpiar06;

        }

        private void PibLimpiar_MouseLeave(object sender, EventArgs e)
        {
            PibLimpiar.Image = Properties.Resources.BotonFormLimpiar05;

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
        private void Imprimir(object sender, PrintPageEventArgs ep)
        {
            
                const int DGV_ALTO = 30;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;
                ep.Graphics.DrawString(" CRUZ ROJA - FILIAL ICA", new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Red, left, top); top += 30;
                ep.Graphics.DrawString("PERSONAL ENCARGADO: " + LblVoluntario.Text, new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Red, left, top);
            
                top += 43;
                foreach (DataGridViewColumn col in DgvEntrada.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 12, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                    left +=col.Width;

                    if (col.Index < DgvEntrada.ColumnCount - 1)
                        ep.Graphics.DrawLine(Pens.Gray, left - 3, top, left - 3, top + 43 + (DgvEntrada.RowCount) * DGV_ALTO);
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 43;

                foreach (DataGridViewRow row in DgvEntrada.Rows)
                {
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 11), Brushes.Black, left, top + 4);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);
                }
        }
        private void ImprimirIngreso()
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
           
            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += Imprimir;
            ppd.ShowDialog();

        }

        private void ConfirmarIngreso(bool BoolImprimir)
        {
            if (Validacion() == true)
            {
                if (DgvEntrada.Rows.Count > 0)
                {
                    string fecha = DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH:mm:ss");

                    //string Colaborador;
                    //if (CmbColaborador.SelectedIndex < 0) Colaborador = "t1Mtbf8p";
                    //else Colaborador = Colaboradores[CmbColaborador.SelectedIndex, 0];

                    consultas.D_ActualizarIngreso(DNI, fecha, Colaboradores[CmbColaborador.SelectedIndex, 0], Coordinadores[CmbEncargado.SelectedIndex, 0]);
                    int CodigoIngreso = consultas.D_UltimoIdIngresado();

                    consultas.AbrirConexion();
                    for (int i = 0; i < DgvEntrada.Rows.Count; i++)
                    {
                        //codigo
                        //nombre
                        //cantidad
                        consultas.SP_Agregar_Detalle_Ingreso(CodigoIngreso, int.Parse(DgvEntrada.Rows[i].Cells[0].Value.ToString()), int.Parse(DgvEntrada.Rows[i].Cells[2].Value.ToString()), DgvEntrada.Rows[i].Cells[5].Value.ToString()); ;
                    }
                    consultas.CerrarConexion();

                    if (BoolImprimir == true)
                    {
                        FormPrincipal sp = Owner as FormPrincipal;
                        sp.maximizar_Pantalla();
                        ImprimirIngreso();
                    }

                    MessageBox.Show("Actualización Exitosa");

                    Limpiar();

                    FormPrincipal FrmPrincipal = (FormPrincipal)Owner;
                    FrmPrincipal.CargarDashBoard();
                    FrmPrincipal.RellenarTablaMedicamentos();
                    //FrmMed.dgb_Medicamentos.CurrentCell = FrmMed.dgb_Medicamentos.Rows[Med_Codigo - 1].Cells[0];
                }
                else
                {
                    MessageBox.Show("Agregue al menos un medicamento en la tabla.", "Información", MessageBoxButtons.OK);
                    PibAgregarMed.Image = Properties.Resources.BotonFormSeleccionarMed05;
                    DgvEntrada.Focus();
                }
            }
        }
        private void PibConfirmar_Click(object sender, EventArgs e)
        {
            ConfirmarIngreso(false);
        }

        private void PibGuardarImprimir_Click(object sender, EventArgs e)
        {
            ConfirmarIngreso(true);

        }

        private void CmbColaborador_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
}
