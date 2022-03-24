using System;
using System.Linq;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormHistorial : Form
    {
        public FormHistorial()
        {
            InitializeComponent();
        }

        public FormHistorial(string DNI)
        {
            InitializeComponent();
            this.DNI = DNI;
            LlamarEntrada();
        }
        readonly string DNI;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public void LlamarEntrada()
        {
            Form Formulario;
            Formulario = pnl_Contenedor_Entradas.Controls.OfType<FormControldeEntradas>().FirstOrDefault(); //Busca en la colección el formulario
            if (Formulario == null)
            {
                Formulario = new FormControldeEntradas();
                AddOwnedForm(Formulario);
                Formulario.TopLevel = false;
                //Formulario.FormBorderStyle = FormBorderStyle.None;
                Formulario.Dock = DockStyle.Fill;
                pnl_Contenedor_Entradas.Controls.Add(Formulario);
                pnl_Contenedor_Entradas.Tag = Formulario;
                Formulario.Show();
                Formulario.BringToFront();
            }
            else
            {
                Formulario.BringToFront();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LlamarEntrada();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form Formulario;
            Formulario = pnl_Contenedor_Entradas.Controls.OfType<FormControldeSalidas>().FirstOrDefault(); //Busca en la colección el formulario
            if (Formulario == null)
            {
                Formulario = new FormControldeSalidas();
                AddOwnedForm(Formulario);
                Formulario.TopLevel = false;
                //Formulario.FormBorderStyle = FormBorderStyle.None;
                Formulario.Dock = DockStyle.Fill;
                pnl_Contenedor_Entradas.Controls.Add(Formulario);
                pnl_Contenedor_Entradas.Tag = Formulario;
                Formulario.Show();
                Formulario.BringToFront();
            }
            else
            {
                Formulario.BringToFront();
            }
        }
    }
}
