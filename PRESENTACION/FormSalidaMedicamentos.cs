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
        //readonly string Nombre;

    }
}
