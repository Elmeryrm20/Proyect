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

        public FormPrincipal(string DNI,String Tipo, string Nombre)
        {
            InitializeComponent();
            this.DNI = DNI;
            this.Tipo = Tipo;
            this.Nombre = Nombre;

            SeleccionarBoton(1);

            LlamarInicio();

        }
        readonly string DNI;
        readonly string Tipo;
        readonly string Nombre;

        public void LlamarInicio()
        {
            Form Formulario;
            Formulario = PnlCuerpo.Controls.OfType<FormInicio>().FirstOrDefault(); //Busca en la colección el formulario
            if (Formulario == null)
            {
                Formulario = new FormInicio(DNI,Nombre);
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
                this.SetDesktopLocation(MousePosition.X - mx - Convert.ToInt32(panel2.Width), MousePosition.Y - my);
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
                Pib_Maximizar.Visible = false;
                Pib_Restaurar.Visible = true;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            n = 1;
            mx = e.X;
            my = e.Y;

            if (WindowState == FormWindowState.Maximized)
            {
                int anchomax = this.Width;
                int porc_anchomax = (int)Math.Round(((double)mx / (double)anchomax) * 100);
                this.WindowState = FormWindowState.Normal;
                int anchonormal = this.Width;
                mx = (int)Math.Round(((double)porc_anchomax / 100) * anchonormal);
                Pib_Maximizar.Visible = true;
                Pib_Restaurar.Visible = false;
            }
        }

        //Metodos de Selección de Menú Principal
        private sbyte Ultimo = 0;
        private void SeleccionarBoton(sbyte x)
        {
            switch (x)
            {
                case 1:
                    Btn_Inicio.Image = Properties.Resources.MenuInicio02;
                    break;
                case 2:
                    Btn_Medicamentos.Image = Properties.Resources.MenuMedicamentos02;
                    break;
                case 3:
                    Btn_Agregar.Image = Properties.Resources.MenuAgregar02;
                    break;
                case 4:
                    Btn_Usuarios.Image = Properties.Resources.MenuUsuarios02;
                    break;
                case 5:
                    Btn_AgregarUsuario.Image = Properties.Resources.MenuAgregarUsuario02;
                    break;
                case 6:
                    Btn_Historial.Image = Properties.Resources.MenuHistorial02;
                    break;
                case 7:
                    Btn_Config.Image = Properties.Resources.MenuConfiguracion02;
                    break;
                case 8:
                    Btn_Acerca.Image = Properties.Resources.MenuAcercaDe02;
                    break;
                default:
                    break;
            }

            if (Ultimo != x)
            {
                DeseleccionarBoton(Ultimo);
                Ultimo = x;
            }
            
        }

        private void DeseleccionarBoton(sbyte y)
        {
            switch (y)
            {
                case 1:
                    Btn_Inicio.Image = Properties.Resources.MenuInicio01;
                    break;
                case 2:
                    Btn_Medicamentos.Image = Properties.Resources.MenuMedicamentos01;
                    break;
                case 3:
                    Btn_Agregar.Image = Properties.Resources.MenuAgregar01;
                    break;
                case 4:
                    Btn_Usuarios.Image = Properties.Resources.MenuUsuarios01;
                    break;
                case 5:
                    Btn_AgregarUsuario.Image = Properties.Resources.MenuAgregarUsuario01;
                    break;
                case 6:
                    Btn_Historial.Image = Properties.Resources.MenuHistorial01;
                    break;
                case 7:
                    Btn_Config.Image = Properties.Resources.MenuConfiguracion01;
                    break;
                case 8:
                    Btn_Acerca.Image = Properties.Resources.MenuAcercaDe01;
                    break;
                default:
                    break;
            }
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
                Pib_Maximizar.Visible = false;
                Pib_Restaurar.Visible = true;
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(1);
            LlamarInicio();

        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(3);

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
            SeleccionarBoton(2);

            consultas.ConsultaMed();
            Form Formulario;
            Formulario = PnlCuerpo.Controls.OfType<FormMedicamentos>().FirstOrDefault(); //Busca en la colección el formulario
            if (Formulario == null)
            {
                Formulario = new FormMedicamentos(DNI);
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
                Pib_Maximizar.Visible = false;
                Pib_Restaurar.Visible = true;
            
           
        }

        private void Btn_Normal_Click(object sender, EventArgs e)
        {
           
                this.WindowState = FormWindowState.Normal;
                Pib_Maximizar.Visible = true;
                Pib_Restaurar.Visible = false;

            
        }

        private void Btn_Historial_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(6);


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

        private void Btn_Config_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(7);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Acerca_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(8);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            PibMinimizar.Image = Properties.Resources.BotonVentanaMinimizar06;
        }

        private void PibMinimizar_MouseLeave(object sender, EventArgs e)
        {
            PibMinimizar.Image = Properties.Resources.BotonVentanaMinimizar05;

        }

        private void Pib_Restaurar_MouseEnter(object sender, EventArgs e)
        {
            Pib_Restaurar.Image = Properties.Resources.BotonVentanaRestaurar02;

        }

        private void Pib_Restaurar_MouseLeave(object sender, EventArgs e)
        {
            Pib_Restaurar.Image = Properties.Resources.BotonVentanaRestaurar01;

        }

        private void PibCerrar_MouseEnter(object sender, EventArgs e)
        {
            PibCerrar.Image = Properties.Resources.BotonVentanaCerrar06;

        }

        private void PibCerrar_MouseLeave(object sender, EventArgs e)
        {
            PibCerrar.Image = Properties.Resources.BotonVentanaCerrar05;

        }

        private void Pib_Maximizar_MouseEnter(object sender, EventArgs e)
        {
            Pib_Maximizar.Image = Properties.Resources.BotonVentanaMaximizar02;

        }

        private void Pib_Maximizar_MouseLeave(object sender, EventArgs e)
        {
            Pib_Maximizar.Image = Properties.Resources.BotonVentanaMaximizar01;

        }

        private void PibContraer_MouseEnter(object sender, EventArgs e)
        {
            PibContraer.Image = Properties.Resources.BotonVentanaContraer02;

        }

        private void PibContraer_MouseLeave(object sender, EventArgs e)
        {
            PibContraer.Image = Properties.Resources.BotonVentanaContraer01;

        }

        private void Btn_Usuarios_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(4);


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
            SeleccionarBoton(5);


            Form Formulario;
            Formulario = PnlCuerpo.Controls.OfType<FormAgregarUsuario>().FirstOrDefault(); //Busca en la colección el formulario
            if (Formulario == null)
            {
                Formulario = new FormAgregarUsuario();
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
