﻿using DATOS;
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
            CmbColaborador.SelectedIndex = -1;
            CmbColaborador.Text = "Seleccionar";
            CmbEncargado.SelectedIndex = -1;
            CmbEncargado.Text = "Seleccionar";
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
        }

        private void FormEntradaMedicamento_Load(object sender, EventArgs e)
        {

            RellenarPersonal();
            //CmbColaborador.DisplayMember = "Colaborador";
            //CmbColaborador.DataSource = consultas.D_MostrarColaboradores(DNI);
            ////CmbColaborador.ValueMember = "Colaborador_Desc";
            CmbColaborador.Text = "Seleccionar";

            //CmbEncargado.DisplayMember = "Coordinador";
            //CmbEncargado.DataSource = consultas.D_MostrarCoordinadores(DNI);
            ////CmbEncargado.ValueMember = "Encargado_Desc";
            CmbEncargado.Text = "Seleccionar";

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

            int fila = DgvEntrada.RowCount;
            string texto = "";
            for (int i = 0; i < fila; i++)
            {
                texto = DgvEntrada.Rows[i].Cells[0].Value.ToString() + "   " + DgvEntrada.Rows[i].Cells[1].Value.ToString() + "   ";
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

        private void ConfirmarIngreso(bool BoolImprimir)
        {
            if (Validacion() == true)
            {
                if (DgvEntrada.Rows.Count > 0)
                {
                    string fecha = DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH-mm-ss");

                    string Colaborador;
                    if (CmbColaborador.SelectedIndex < 0) Colaborador = "t1Mtbf8p";
                    else Colaborador = Colaboradores[CmbColaborador.SelectedIndex, 0];

                    string CodigoIngreso = consultas.D_ActualizarIngreso(DNI, fecha, Colaborador, Coordinadores[CmbEncargado.SelectedIndex, 0]);

                    consultas.AbrirConexion();
                    for (int i = 0; i < DgvEntrada.Rows.Count; i++)
                    {
                        //codigo
                        //nombre
                        //cantidad
                        consultas.SP_Agregar_Detalle_Ingreso(int.Parse(CodigoIngreso), int.Parse(DgvEntrada.Rows[i].Cells[0].Value.ToString()), int.Parse(DgvEntrada.Rows[i].Cells[2].Value.ToString()), DgvEntrada.Rows[i].Cells[5].Value.ToString()); ;
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
