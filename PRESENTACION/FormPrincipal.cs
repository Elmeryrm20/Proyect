using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS;

namespace PRESENTACION
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

        }

        Consultas consultas = new Consultas();

        public FormPrincipal(string DNI,String Tipo)
        {
            InitializeComponent();

            LlamarInicio();

        }
        public void LlamarInicio()
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
        void centrar()
        {

        }
        int n, mx, my;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (n == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx - 211, MousePosition.Y - my);
            }
            //label1.Text = MousePosition.X.ToString() + " " + MousePosition.Y.ToString();
            //label2.Text = mx.ToString() + " " + my.ToString();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            n = 0;
            if (MousePosition.Y == 0)
            {
                this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
                this.WindowState = FormWindowState.Maximized;
                btn_Maximizar.Visible = false;
                Btn_Normal.Visible = true;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btn_Maximizar.Visible = true;
                Btn_Normal.Visible = false;
            }
            n = 1;
            mx = e.X;
            my = e.Y;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
                this.WindowState = FormWindowState.Maximized;
                btn_Maximizar.Visible = false;
                Btn_Normal.Visible = true;
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LlamarInicio();
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
            consultas.ConsultaMed();
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


        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            
                this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
                this.WindowState = FormWindowState.Maximized;
                btn_Maximizar.Visible = false;
                Btn_Normal.Visible = true;
            
           
        }

        private void Btn_Normal_Click(object sender, EventArgs e)
        {
           
                this.WindowState = FormWindowState.Normal;
                btn_Maximizar.Visible = true;
                Btn_Normal.Visible = false;

            
        }

        private void Btn_Historial_Click(object sender, EventArgs e)
        {
            Form Formulario;
            Formulario = PnlCuerpo.Controls.OfType<FormHistorial>().FirstOrDefault(); //Busca en la colección el formulario
            if (Formulario == null)
            {
                Formulario = new FormHistorial();
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
