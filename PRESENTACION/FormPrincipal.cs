using DATOS;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormPrincipal : Form
    {
        #region Constructores
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public FormPrincipal(string DNI, string Tipo, string Nombre)
        {
            InitializeComponent();
            this.DNI = DNI;
            this.Nombre = Nombre;

            if (Tipo == "1") VistaTrabajador(); //Método de Vista de Formularios para Trabajador
            else CargarFormularios(9); //Rango Admin de Formularios

            Btn_Acerca.Visible = false;
            Btn_Config.Visible = false;
            SeleccionarBoton(1);

            AparecerFormulario<FormInicio>();

        }
        #endregion

        #region Inicializar Variables de Formularios
        readonly string DNI;
        readonly string Nombre;

        Consultas consultas = new Consultas();
        #endregion

        #region Método para Formulario

        void VistaTrabajador()
        {
            Btn_Usuarios.Visible = false;
            Btn_AgregarUsuario.Visible = false;
            Btn_Historial.Location = new Point(0, 270);
            Btn_Config.Location = new Point(0, 315);
            Btn_Acerca.Location = new Point(0, 360);
            CargarFormularios(7);
        }

        void CargarFormularios(byte rango)
        {

            for (byte i = 1; i <= rango; i++)
            {
                Form Formulario = null;

                switch (i)
                {
                    case 1: Formulario = new FormInicio(DNI, Nombre); break;
                    case 2: Formulario = new FormMedicamentos(DNI); break;
                    case 3: Formulario = new FormAgregarMedicamento(DNI); break;
                    case 4: Formulario = new FormSalidaMedicamentos(DNI, Nombre); break;
                    case 5: Formulario = new FormHistorial(DNI); break;
                    case 6: Formulario = new FormConfiguracion(DNI); break;
                    case 7: Formulario = new FormAcercaDe(); break;
                    case 8: Formulario = new FormUsuarios(DNI); break;
                    case 9: Formulario = new FormAgregarUsuario(DNI); break;
                    default:
                        break;
                }
                AddOwnedForm(Formulario);
                Formulario.TopLevel = false;
                Formulario.Dock = DockStyle.Fill;
                PnlCuerpo.Controls.Add(Formulario);
                PnlCuerpo.Tag = Formulario;
                //Formulario.Show();
                //Formulario.BringToFront();

            }
        }

        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form Formulario;
            Formulario = PnlCuerpo.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la colección el formulario
            if (Formulario == null)
            {
                Formulario = new MiForm();
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

        public void AparecerFormulario<MiForm>() where MiForm : Form, new()
        {
            Form Formulario;

            Formulario = PnlCuerpo.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la colección el formulario
            Formulario.Show(); //Agregado
            Formulario.BringToFront(); //Agregado
        }
        #endregion

        #region Métodos del Panel
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
                int porc_anchomax = (int)Math.Round(((double)mx / (double)(anchomax - panel2.Width)) * 100);
                this.WindowState = FormWindowState.Normal;
                int anchonormal = this.Width;
                mx = (int)Math.Round(((double)porc_anchomax / 100) * (anchonormal - panel2.Width));
                Pib_Maximizar.Visible = true;
                Pib_Restaurar.Visible = false;
            }
        }
        #endregion

        #region Seleccionar Botón de Menú
        //Metodos de Selección de Menú Principal
        private sbyte Ultimo = 0;
        public void SeleccionarBoton(sbyte x)
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
                case 9:
                    Btn_Salida.Image = Properties.Resources.MenuSalida02;
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
                case 9:
                    Btn_Salida.Image = Properties.Resources.MenuSalida01;
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Botones de Ventana
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes) Application.Exit();
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
        #endregion

        #region Botones Menú
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(1);
            AparecerFormulario<FormInicio>();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(3);
            AparecerFormulario<FormAgregarMedicamento>();
        }

        public void Btn_Cajas_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(2);
            AparecerFormulario<FormMedicamentos>();
        }

        private void Btn_Historial_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(6);
            AparecerFormulario<FormHistorial>();
        }

        private void Btn_Config_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(7);
            AparecerFormulario<FormConfiguracion>();
        }

        private void Btn_Acerca_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(8);
            AparecerFormulario<FormAcercaDe>();
        }

        private void Btn_Usuarios_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(4);
            AparecerFormulario<FormUsuarios>();
        }

        public void ResaltarBotonEgreso()
        {
            FormMedicamentos FrmMedicamentos = PnlCuerpo.Controls.OfType<FormMedicamentos>().FirstOrDefault();
            FrmMedicamentos.PibSalida.Image = Properties.Resources.BotonFormSalida04;
        }

        public void EnviarEgreso(int Codigo, string MedNombre, int cantidad, string Almacen, string Tipo)
        {
            FormSalidaMedicamentos FrmSalida = PnlCuerpo.Controls.OfType<FormSalidaMedicamentos>().FirstOrDefault();

            //Adicionamos nuevo renglon
            int n = FrmSalida.DgvSalida.Rows.Add();

            //Colocamos la información
            FrmSalida.DgvSalida.Rows[n].Cells[0].Value = Codigo.ToString();
            FrmSalida.DgvSalida.Rows[n].Cells[1].Value = MedNombre;
            FrmSalida.DgvSalida.Rows[n].Cells[2].Value = cantidad.ToString();
            FrmSalida.DgvSalida.Rows[n].Cells[3].Value = Almacen;
            FrmSalida.DgvSalida.Rows[n].Cells[4].Value = Tipo;
            FrmSalida.PibConfirmar.Image = Properties.Resources.BotonFormConfirmarSalida05;

            FrmSalida.Show(); //Agregado
            FrmSalida.BringToFront(); //Agregado

            //SeleccionarBoton(2);
            //AparecerFormulario<FormMedicamentos>();


        }

        private void Btn_Salida_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(9);
            AparecerFormulario<FormSalidaMedicamentos>();
        }

        private void Btn_Salidas_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(5);
            AparecerFormulario<FormAgregarUsuario>();
        }
        #endregion

        #region Botones de Formulario

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
            Pib_Restaurar.Image = Properties.Resources.BotonVentanaRestaurar04;
        }

        private void Pib_Restaurar_MouseLeave(object sender, EventArgs e)
        {
            Pib_Restaurar.Image = Properties.Resources.BotonVentanaRestaurar03;
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
            Pib_Maximizar.Image = Properties.Resources.BotonVentanaMaximizar04;
        }

        private void Pib_Maximizar_MouseLeave(object sender, EventArgs e)
        {
            Pib_Maximizar.Image = Properties.Resources.BotonVentanaMaximizar03;
        }

        private void btn_cerrarsesion_Click(object sender, EventArgs e)
        {
            FormLogin cerrar = new FormLogin();
            cerrar.Show();
            this.Close();
        }

        private void PibContraer_MouseEnter(object sender, EventArgs e)
        {
            PibContraer.Image = Properties.Resources.BotonVentanaContraer02;
        }

        private void PibContraer_MouseLeave(object sender, EventArgs e)
        {
            PibContraer.Image = Properties.Resources.BotonVentanaContraer01;
        }
        #endregion

    }
}
