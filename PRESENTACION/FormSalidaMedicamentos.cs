using DATOS;
using System;
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
            TxtTrabajador.Text = Nombre;

        }

        readonly string DNI;
        Consultas consultas = new Consultas();

        private void PibAgregarMed_Click(object sender, System.EventArgs e)
        {
            FormPrincipal Principal = (FormPrincipal)Owner;

            Principal.SeleccionarBoton(2);
            Principal.AparecerFormulario<FormMedicamentos>();
        }

        private bool Validacion()
        {
            if (CmbTipoDNI.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Documento de Identificación", "Información");
                CmbTipoDNI.Focus();
                return false;
            }
            else if (TxtNumDNI.Text == "")
            {
                MessageBox.Show("Ingrese un Número de Identificación", "Información");
                TxtNumDNI.Focus();
                return false;
            }
            else if (TxtNombres.Text == "")
            {
                MessageBox.Show("Ingrese el Nombre", "Información");
                TxtNombres.Focus();
                return false;
            }
            else if (TxtApellidos.Text == "")
            {
                MessageBox.Show("Ingrese los apellidos", "Información");
                TxtApellidos.Focus();
                return false;
            }
            else if (TxtNacionalidad.Text == "")
            {
                MessageBox.Show("Ingrese la nacionalidad", "Información");
                TxtNacionalidad.Focus();
                return false;
            }
            else if (CmbEncargado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Encargado", "Información");
                CmbEncargado.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void PibConfirmar_Click(object sender, System.EventArgs e)
        {

            if (Validacion() == true)
            {
                if (DgvSalida.Rows.Count > 0)
                {
                    string fecha = DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH-mm-ss");

                    if (CmbColaborador.SelectedIndex >= 0)
                    {
                        if (consultas.D_VerificarPersona(TxtNumDNI.Text) == false)
                        {
                            consultas.D_AgregarDestino(TxtNumDNI.Text, TxtNombres.Text, TxtApellidos.Text, TxtNacionalidad.Text, TxtTelefono.Text, CmbTipoDNI.SelectedIndex + 1);
                        }

                        string CodigoEgreso = consultas.D_ActualizarEgreso(fecha, DNI, TxtNumDNI.Text);

                        consultas.AbrirConexion();
                        for (int i = 0; i < DgvSalida.Rows.Count; i++)
                        {
                            //codigo
                            //nombre
                            //cantidad
                            consultas.SP_Agregar_Detalle_Egreso(int.Parse(CodigoEgreso), int.Parse(DgvSalida.Rows[i].Cells[0].Value.ToString()), int.Parse(DgvSalida.Rows[i].Cells[2].Value.ToString()), 4); ;
                        }
                        consultas.CerrarConexion();

                        MessageBox.Show("Actualización Exitosa");

                        Limpiar();
                    }


                    //    FormMedicamentos FrmMed = Owner as FormMedicamentos;
                    //    FrmMed.Rellenartabla();
                    //    FrmMed.dgb_Medicamentos.CurrentCell = FrmMed.dgb_Medicamentos.Rows[Med_Codigo - 1].Cells[0];
                    //    Close();
                }
                else
                {
                    MessageBox.Show("La lista de medicamentos para el egreso está vacía.", "Información");
                    DgvSalida.Focus();
                }
            }

            //MessageBox.Show("Por el momento no están habilitados los egresos.");

        }

        private void Limpiar()
        {
            CmbTipoDNI.SelectedIndex = -1;
            CmbTipoDNI.Text = "Seleccione un tipo de Identificación";
            TxtNumDNI.Text = "";
            TxtNombres.Text = "";
            PibApellidos.Text = "";
            PibNacionalidad.Text = "";
            PibTelefono.Text = "";
            CmbColaborador.SelectedIndex = -1;
            CmbColaborador.Text = "Seleccione un Colaborador";
            CmbEncargado.SelectedIndex = -1;
            CmbEncargado.Text = "Seleccione un Encargado";
            CmbTipoDNI.Focus();

        }

        private void FormSalidaMedicamentos_Load(object sender, System.EventArgs e)
        {
            CmbColaborador.DisplayMember = "Trabajador";
            CmbColaborador.DataSource = consultas.D_MostrarColaboradores(DNI);
            //CmbColaborador.ValueMember = "Colaborador_Desc";


            CmbEncargado.DisplayMember = "Trabajador";
            CmbEncargado.DataSource = consultas.D_MostrarColaboradores(DNI);
            //CmbEncargado.ValueMember = "Encargado_Desc";

            CmbTipoDNI.DisplayMember = "Tid_Descripcion";
            CmbTipoDNI.DataSource = consultas.D_TipoDNI();

        }

        private void PibAgregarMed_MouseEnter(object sender, EventArgs e)
        {
            PibAgregarMed.Image = Properties.Resources.BotonFormSeleccionarMed02;

        }

        private void PibAgregarMed_MouseLeave(object sender, EventArgs e)
        {
            PibAgregarMed.Image = Properties.Resources.BotonFormSeleccionarMed01;

        }

        private void PibConfirmar_MouseEnter(object sender, EventArgs e)
        {
            PibConfirmar.Image = Properties.Resources.BotonFormConfirmarSalida04;

        }

        private void PibConfirmar_MouseLeave(object sender, EventArgs e)
        {
            PibConfirmar.Image = Properties.Resources.BotonFormConfirmarSalida03;

        }

        private void PibEliminarMed_MouseEnter(object sender, EventArgs e)
        {
            PibEliminarMed.Image = Properties.Resources.BotonFormAgregarQuitar02;

        }

        private void PibEliminarMed_MouseLeave(object sender, EventArgs e)
        {
            PibEliminarMed.Image = Properties.Resources.BotonFormAgregarQuitar01;

        }

        private void PibLimpiar_MouseEnter(object sender, EventArgs e)
        {
            PibLimpiar.Image = Properties.Resources.BotonFormLimpiar02;

        }

        private void PibLimpiar_MouseLeave(object sender, EventArgs e)
        {
            PibLimpiar.Image = Properties.Resources.BotonFormLimpiar01;

        }

        private void PibGuardarImprimir_MouseEnter(object sender, EventArgs e)
        {
            PibGuardarImprimir.Image = Properties.Resources.BotonFormImprimir02;

        }

        private void PibGuardarImprimir_MouseLeave(object sender, EventArgs e)
        {
            PibGuardarImprimir.Image = Properties.Resources.BotonFormImprimir01;

        }
    }
}
