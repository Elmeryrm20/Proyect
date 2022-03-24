using System.Linq;
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

        private void PibAgregarMed_Click(object sender, System.EventArgs e)
        {
            FormPrincipal Principal = (FormPrincipal)Owner;
            //Form Formulario;


            Principal.AparecerFormulario<FormMedicamentos>();
            //Formulario = Principal.PnlCuerpo.Controls.OfType<FormMedicamentos>().FirstOrDefault();
            //Formulario.BringToFront();

            //Principal.Btn_Cajas_Click(new object(), new EventArgs());


        }
        //readonly string Nombre;

    }
}
