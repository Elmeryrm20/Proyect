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

            OrdenarBotonesMenu(Tipo);


            //Btn_Acerca.Visible = false;
            //Btn_Config.Visible = false;
            SeleccionarBoton(1);

            //AparecerFormulario<FormInicio>();
            EscogerFormulario<FormInicio>(1);

        }
        #endregion

        #region Inicializar Variables de Formularios
        readonly string DNI;
        readonly string Nombre;

        Consultas consultas = new Consultas();
        #endregion

        #region Método para Formulario
        void ActivarTootip()
        {
            ToolTip toolTip2 = new ToolTip();
            toolTip2.SetToolTip(PibCerrar, "Cerrar");
            toolTip2.SetToolTip(Pib_Restaurar, "Restaurar");
            toolTip2.SetToolTip(Pib_Maximizar, "Maximizar");
            toolTip2.SetToolTip(PibMinimizar, "Minimizar");

            ToolTip toolTip1 = new ToolTip();
            toolTip1.UseAnimation = true;
            toolTip1.UseFading = true;
            //toolTip1.BackColor = Color.FromArgb(241, 241, 252);
            //toolTip1.ForeColor = Color.FromArgb(230, 50, 10);
            toolTip1.IsBalloon = true;
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;

            toolTip1.SetToolTip(Btn_Inicio, "Ventana de Inicio.");
            toolTip1.SetToolTip(Btn_Medicamentos, "Muestra el inventario de medicamentos.");
            toolTip1.SetToolTip(BtnEntrada, "Aquí podrás registrar las entradas de medicamentos.");
            toolTip1.SetToolTip(Btn_Salida, "Aquí podrás registrar las salidas de medicamentos.");
            toolTip1.SetToolTip(Btn_Agregar, "Agrega un nuevo medicamento al inventario.");
            toolTip1.SetToolTip(Btn_Usuarios, "Muestra la lista de usuarios registrados.");
            toolTip1.SetToolTip(Btn_AgregarUsuario, "Registra un nuevo usuario a la aplicación.");
            toolTip1.SetToolTip(Btn_Historial, "Aquí puedes revisar el historial \nde todas las entradas y salidas \nde los medicamentos.");
            toolTip1.SetToolTip(Btn_Config, "Configura las opciones de la aplicación.");
            toolTip1.SetToolTip(Btn_Acerca, "Muestra datos acerca de la aplicación.");

            //using (StringFormat sf = new StringFormat())
            //{
            //    sf.Alignment = StringAlignment.Center;
            //}


        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ActivarTootip();
            //ShowInTaskbar = true;
            LblNombre.Text = Nombre;

        }
        private void OrdenarBotonesMenu(string Tipo)
        {

            BtnEntrada.Location = new Point(0, 180);
            Btn_Salida.Location = new Point(0, 225);
            Btn_Agregar.Location = new Point(0, 270);

            if (Tipo == "1") VistaVoluntario(); //Método de Vista de Formularios para Voluntario
            else VistaCoordinador(); //Rango Admin de Coordinador
        }

        void VistaVoluntario()
        {
            Btn_Usuarios.Visible = false;
            Btn_AgregarUsuario.Visible = false;
            Btn_Historial.Location = new Point(0, 315);
            Btn_Config.Location = new Point(0, 360);
            Btn_Acerca.Location = new Point(0, 405);
            //CargarFormularios(7);
        }
        void VistaCoordinador()
        {
            Btn_Usuarios.Location = new Point(0, 315);
            Btn_AgregarUsuario.Location = new Point(0, 360);
            Btn_Historial.Location = new Point(0, 405);
            Btn_Config.Location = new Point(0, 450);
            Btn_Acerca.Location = new Point(0, 495);
            //CargarFormularios(9);

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

        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        public void EscogerFormulario<MiForm>(byte indice) where MiForm : Form, new()
        {
            Form Formulario;
            Formulario = PnlCuerpo.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la colección el formulario
            if (Formulario == null)
            {
                //Formulario = new MiForm();
                switch (indice)
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
                    case 10: Formulario = new FormEntradaMedicamento(DNI, Nombre); break;
                    default:
                        break;
                }

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
                case 10:
                    BtnEntrada.Image = Properties.Resources.MenuEntrada02;
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
                case 10:
                    BtnEntrada.Image = Properties.Resources.MenuEntrada01;
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Botones de Ventana
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

            maximizar_Pantalla();
            FormInicio FrmInicio = PnlCuerpo.Controls.OfType<FormInicio>().FirstOrDefault();
            FrmInicio.MaximizarDataGridView();

        }
        public void maximizar_Pantalla()
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
            FormInicio FrmInicio = PnlCuerpo.Controls.OfType<FormInicio>().FirstOrDefault();
            FrmInicio.MinimizarDataGridview();
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

        private void Btn_Cerrar_Sesion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cerrar sesion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                FormLogin sp = new FormLogin();
                sp.Show();
            }

        }

        private void Btn_Cerrar_Sesion_MouseEnter(object sender, EventArgs e)
        {
            btn_cerrarsesion.Image = Properties.Resources.BotonVentanaCerrarSesion02;
        }

        private void Btn_Cerrar_Sesion_MouseLeave(object sender, EventArgs e)
        {
            btn_cerrarsesion.Image = Properties.Resources.BotonVentanaCerrarSesion01;
        }
        #endregion

        #region Botones Menú
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(1); //INICIO
            //AparecerFormulario<FormInicio>();
            EscogerFormulario<FormInicio>(1);
        }

        public void Btn_Cajas_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(2); //MEDICAMENTOS
            //AparecerFormulario<FormMedicamentos>();
            EscogerFormulario<FormMedicamentos>(2);

        }
        private void BtnEntrada_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(10); //ENTRADA
            EscogerFormulario<FormEntradaMedicamento>(10);

        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(3); //AGREGAR MEDICAMENTO
            //AparecerFormulario<FormAgregarMedicamento>();
            EscogerFormulario<FormAgregarMedicamento>(3);
        }
        private void Btn_Historial_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(6); //HISTORIAL
            //AparecerFormulario<FormHistorial>();
            EscogerFormulario<FormHistorial>(5);
        }

        private void Btn_Config_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(7); //CONFIGURACIÓN
            //AparecerFormulario<FormConfiguracion>();
            EscogerFormulario<FormConfiguracion>(6);
        }

        private void Btn_Acerca_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(8); //ACERCA DE
            //AparecerFormulario<FormAcercaDe>();
            EscogerFormulario<FormAcercaDe>(7);
        }

        private void Btn_Usuarios_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(4); //USUARIOS
            //AparecerFormulario<FormUsuarios>();
            EscogerFormulario<FormUsuarios>(8);
        }

        private void Btn_Salida_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(9); //SALIDA
            //AparecerFormulario<FormSalidaMedicamentos>();
            EscogerFormulario<FormSalidaMedicamentos>(4);
        }

        private void Btn_Salidas_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(5); //AGREGAR USUARIO
            EscogerFormulario<FormAgregarUsuario>(9);
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

        #region Métodos Heredados
        public void CargarDashBoard()
        {
            FormInicio FrmInicio = PnlCuerpo.Controls.OfType<FormInicio>().FirstOrDefault();
            FrmInicio.CargarDashBoard();
        }
        public void RellenarTablaMedicamentos()
        {
            FormMedicamentos FrmMedicamentos = PnlCuerpo.Controls.OfType<FormMedicamentos>().FirstOrDefault();
            FrmMedicamentos.Rellenartabla();
        }
        public void ResaltarBotonEgreso()
        {
            FormMedicamentos FrmMedicamentos = PnlCuerpo.Controls.OfType<FormMedicamentos>().FirstOrDefault();
            FrmMedicamentos.PibSalida.Image = Properties.Resources.BotonFormSalida04;
        }
        public void ResaltarBotonIngreso()
        {
            FormMedicamentos FrmMedicamentos = PnlCuerpo.Controls.OfType<FormMedicamentos>().FirstOrDefault();

            FrmMedicamentos.PibIngreso.Image = Properties.Resources.BotonFormIngreso03;
        }
        private bool SeleccionRepetida(DataGridView d, int Codigo)
        {
            if (d.Rows.Count > 0)
            {
                for (int i = 0; i < d.Rows.Count; i++)
                {
                    if (Convert.ToInt32(d.Rows[i].Cells[0].Value) == Codigo)
                    {
                        MessageBox.Show("Ya seleccionó ese medicamento.");
                        return false;
                    }
                }
            }
            return true;
        }

        public void EnviarEgreso(int Codigo, string MedNombre, int cantidad, string Almacen, string Tipo)
        {
            FormSalidaMedicamentos FrmSalida = PnlCuerpo.Controls.OfType<FormSalidaMedicamentos>().FirstOrDefault();

            if (SeleccionRepetida(FrmSalida.DgvSalida, Codigo))
            {
                //Adicionamos nuevo renglon
                int n = FrmSalida.DgvSalida.Rows.Add();

                //Colocamos la información
                FrmSalida.DgvSalida.Rows[n].Cells[0].Value = Codigo.ToString();
                FrmSalida.DgvSalida.Rows[n].Cells[1].Value = MedNombre;
                FrmSalida.DgvSalida.Rows[n].Cells[2].Value = cantidad.ToString();
                FrmSalida.DgvSalida.Rows[n].Cells[3].Value = Almacen;
                FrmSalida.DgvSalida.Rows[n].Cells[4].Value = Tipo;
                FrmSalida.PibConfirmar.Image = Properties.Resources.BotonFormConfirmarSalida05;
                short fila = (short)(FrmSalida.DgvSalida.Rows.Count - 1);
                FrmSalida.DgvSalida.CurrentCell = FrmSalida.DgvSalida.Rows[fila].Cells[1];
                FrmSalida.fila = fila;

                FrmSalida.Show(); //Agregado
                FrmSalida.BringToFront(); //Agregado


                SeleccionarBoton(9);
                //AparecerFormulario<FormSalidaMedicamentos>();
            }

        }
        public void EnviarIngreso(int Codigo, string MedNombre, int cantidad, string Almacen, string Tipo, string FechaVencimiento)
        {
            FormEntradaMedicamento FrmEntrada = PnlCuerpo.Controls.OfType<FormEntradaMedicamento>().FirstOrDefault();

            if (SeleccionRepetida(FrmEntrada.DgvEntrada, Codigo))
            {
                //Adicionamos nuevo renglon
                int n = FrmEntrada.DgvEntrada.Rows.Add();

                //Colocamos la información
                FrmEntrada.DgvEntrada.Rows[n].Cells[0].Value = Codigo.ToString();
                FrmEntrada.DgvEntrada.Rows[n].Cells[1].Value = MedNombre;
                FrmEntrada.DgvEntrada.Rows[n].Cells[2].Value = cantidad.ToString();
                FrmEntrada.DgvEntrada.Rows[n].Cells[3].Value = Almacen;
                FrmEntrada.DgvEntrada.Rows[n].Cells[4].Value = Tipo;
                FrmEntrada.DgvEntrada.Rows[n].Cells[5].Value = FechaVencimiento;
                FrmEntrada.PibConfirmar.Image = Properties.Resources.BotonFormConfirmarEntrada03;
                short fila = (short)(FrmEntrada.DgvEntrada.Rows.Count - 1);
                FrmEntrada.DgvEntrada.CurrentCell = FrmEntrada.DgvEntrada.Rows[fila].Cells[1];
                FrmEntrada.fila = fila;

                FrmEntrada.Show(); //Agregado
                FrmEntrada.BringToFront(); //Agregado


                SeleccionarBoton(10);
                //AparecerFormulario<FormSalidaMedicamentos>();
            }

        }
        #endregion

    }
}
