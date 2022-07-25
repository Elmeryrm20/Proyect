using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormConfiguracion : Form
    {
        public FormConfiguracion()
        {
            InitializeComponent();
        }
        public FormConfiguracion(string DNI)
        {
            InitializeComponent();
            this.DNI = DNI;
        }
        readonly string DNI;

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
