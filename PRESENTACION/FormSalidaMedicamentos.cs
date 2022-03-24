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
            InitializeComponent();
            this.DNI = DNI;
            //this.Nombre = Nombre;
            TxtTrabajador.Text = Nombre;

        }

        readonly string DNI;

        public void AgregarMedicamentoDgv(string Med_Codigo,int cantidad)
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
        //readonly string Nombre;

    }
}
