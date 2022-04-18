using System;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormEspera : Form
    {
        public FormEspera()
        {
            InitializeComponent();
        }
        public FormEspera(string DNI, string Tipo, string Nombre)
        {
            InitializeComponent();
            this.DNI = DNI;
            this.Tipo = Tipo;
            this.Nombre = Nombre;
        }
        readonly string DNI, Tipo, Nombre;

        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            //cont += 1;

            if (this.Opacity == 1)
            {

                CpbCarga.Value += 1;
                CpbCarga.Text = CpbCarga.Value.ToString();
            }

            if (CpbCarga.Value == 100)
            {
                timer1.Stop();
                //timer1.Enabled = false;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                //timer2.Enabled = false;
                AbrirFormularioPrincipal();
                this.Close();

            }
        }

        private void AbrirFormularioPrincipal()
        {
            FormLogin hg = ((FormLogin)Owner);
            FormPrincipal A = new FormPrincipal(DNI, Tipo, Nombre);
            hg.AddOwnedForm(A);
            A.Show();
        }

        private void FormEspera_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(5000);
            this.Opacity = 0;
            CpbCarga.Value = 0;
            CpbCarga.Minimum = 0;
            CpbCarga.Maximum = 100;

            //CpbCarga.SetBounds(152, 172, 78, 78);
            timer1.Start();
        }
    }
}
