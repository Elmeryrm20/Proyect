using System.Data;
using DATOS;
using System.Windows.Forms;
using System.IO;

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


        public void AgregarMedicamentoDgv(string Med_Codigo, int cantidad)
        {
            //Adicionamos nuevo renglon
            int n = DgvSalida.Rows.Add();

            //Colocamos la información
            DgvSalida.Rows[n].Cells[0].Value = Med_Codigo;
            DgvSalida.Rows[n].Cells[1].Value = cantidad.ToString();
        }

        private void PibAgregarMed_Click(object sender, System.EventArgs e)
        {
            FormPrincipal Principal = (FormPrincipal)Owner;

            Principal.SeleccionarBoton(2);
            Principal.AparecerFormulario<FormMedicamentos>();

            //Formulario = Principal.PnlCuerpo.Controls.OfType<FormMedicamentos>().FirstOrDefault();
            //Formulario.BringToFront();

            //Principal.Btn_Cajas_Click(new object(), new EventArgs());


        }

        private void PibConfirmar_Click(object sender, System.EventArgs e)
        {

            //    //consultas.SP_Agregar_Egreso_Medicamento(Med_Codigo, cantidad);
            //    consultas.D_ActualizarEgreso(Med_Codigo, cantidad);

            //    consultas.SP_Agregar_Detalle_Egreso(Med_Codigo, cantidad, DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH-mm-ss"), DNI, 4);
            //    MessageBox.Show("Actualización Exitosa");

            //    FormMedicamentos FrmMed = Owner as FormMedicamentos;
            //    FrmMed.Rellenartabla();
            //    FrmMed.dgb_Medicamentos.CurrentCell = FrmMed.dgb_Medicamentos.Rows[Med_Codigo - 1].Cells[0];
            //    Close();
        }

        private void FormSalidaMedicamentos_Load(object sender, System.EventArgs e)
        {
            CmbColaborador.DisplayMember = "Trabajador";
            CmbColaborador.DataSource = consultas.D_MostrarColaboradores(DNI);
            //CmbColaborador.ValueMember = "Colaborador_Desc";


            CmbEncargado.DisplayMember = "Trabajador";
            CmbEncargado.DataSource = consultas.D_MostrarColaboradores(DNI);
            //CmbEncargado.ValueMember = "Encargado_Desc";

        }
    }
}
