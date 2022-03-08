using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form Formulario;
            Formulario = PnlCuerpo.Controls.OfType<FormInicio>().FirstOrDefault(); //Busca en la colección el formulario
            if (Formulario == null)
            {
                Formulario = new FormInicio();
                AddOwnedForm(Formulario);
                Formulario.TopLevel = false;
                //Formulario.FormBorderStyle = FormBorderStyle.None;
                Formulario.Dock = DockStyle.Fill;
                PnlCuerpo.Controls.Add(Formulario);
                PnlCuerpo.Tag = Formulario;
                Formulario.Show();
                Formulario.BringToFront();
            }
            else
            {
                Formulario.BringToFront();
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            Form Formulario;
            Formulario = PnlCuerpo.Controls.OfType<FormAgregarMedicamento>().FirstOrDefault(); //Busca en la colección el formulario
            if (Formulario == null)
            {
                Formulario = new FormAgregarMedicamento();
                AddOwnedForm(Formulario);
                Formulario.TopLevel = false;
                //Formulario.FormBorderStyle = FormBorderStyle.None;
                Formulario.Dock = DockStyle.Fill;
                PnlCuerpo.Controls.Add(Formulario);
                PnlCuerpo.Tag = Formulario;
                Formulario.Show();
                Formulario.BringToFront();
            }
            else
            {
                Formulario.BringToFront();
            }
        }

        private void Btn_Cajas_Click(object sender, EventArgs e)
        {
            Form Formulario;
            Formulario = PnlCuerpo.Controls.OfType<FormMedicamentos>().FirstOrDefault(); //Busca en la colección el formulario
            if (Formulario == null)
            {
                Formulario = new FormMedicamentos();
                AddOwnedForm(Formulario);
                Formulario.TopLevel = false;
                //Formulario.FormBorderStyle = FormBorderStyle.None;
                Formulario.Dock = DockStyle.Fill;
                PnlCuerpo.Controls.Add(Formulario);
                PnlCuerpo.Tag = Formulario;
                Formulario.Show();
                Formulario.BringToFront();
            }
            else
            {
                Formulario.BringToFront();
            }
        }

        private void Btn_Usuarios_Click(object sender, EventArgs e)
        {
            Form Formulario;
            Formulario = PnlCuerpo.Controls.OfType<FormUsuarios>().FirstOrDefault(); //Busca en la colección el formulario
            if (Formulario == null)
            {
                Formulario = new FormUsuarios();
                AddOwnedForm(Formulario);
                Formulario.TopLevel = false;
                //Formulario.FormBorderStyle = FormBorderStyle.None;
                Formulario.Dock = DockStyle.Fill;
                PnlCuerpo.Controls.Add(Formulario);
                PnlCuerpo.Tag = Formulario;
                Formulario.Show();
                Formulario.BringToFront();
            }
            else
            {
                Formulario.BringToFront();
            }
        }

        private void Btn_Salidas_Click(object sender, EventArgs e)
        {
            Form Formulario;
            Formulario = PnlCuerpo.Controls.OfType<FormSalidaMedicamento>().FirstOrDefault(); //Busca en la colección el formulario
            if (Formulario == null)
            {
                Formulario = new FormSalidaMedicamento();
                AddOwnedForm(Formulario);
                Formulario.TopLevel = false;
                //Formulario.FormBorderStyle = FormBorderStyle.None;
                Formulario.Dock = DockStyle.Fill;
                PnlCuerpo.Controls.Add(Formulario);
                PnlCuerpo.Tag = Formulario;
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
