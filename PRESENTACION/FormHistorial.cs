using System;
using System.Drawing;
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
        public void EscogerFormulario<MiForm>(byte indice) where MiForm : Form, new()
        {
            Form Formulario;
            Formulario = pnl_Contenedor_Entradas.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la colección el formulario
            if (Formulario == null)
            {
                //Formulario = new MiForm();
                switch (indice)
                {
                    case 1: Formulario = new FormControldeEntradas(); break;
                    case 2: Formulario = new FormControldeSalidas(); break;
                    default:
                        break;
                }

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
            //LlamarEntrada();
            EscogerFormulario<FormControldeEntradas>(1);


            BtnSalidas.BackColor = Color.FromArgb(241, 241, 252);
            BtnSalidas.ForeColor = Color.CornflowerBlue;
            BtnSalidas.FlatAppearance.BorderSize = 2;

            BtnEntradas.BackColor = Color.CornflowerBlue;
            BtnEntradas.ForeColor = Color.FromArgb(241, 241, 252);
            BtnEntradas.FlatAppearance.BorderSize = 0;
        }
        public void maximizar_Pantalla()
        {
            FormPrincipal sp = Owner as FormPrincipal;
            sp.maximizar_Pantalla();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSalidas_Click(object sender, EventArgs e)
        {
            EscogerFormulario<FormControldeSalidas>(2);

            BtnEntradas.BackColor = Color.FromArgb(241, 241, 252);
            BtnEntradas.ForeColor = Color.CornflowerBlue;
            BtnEntradas.FlatAppearance.BorderSize = 2;

            BtnSalidas.BackColor = Color.CornflowerBlue;
            BtnSalidas.ForeColor = Color.FromArgb(241, 241, 252);
            BtnSalidas.FlatAppearance.BorderSize = 0;
        }
    }
}
