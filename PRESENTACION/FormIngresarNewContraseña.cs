using DATOS;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormIngresarNewContraseña : Form
    {
        Consultas consultas = new Consultas();
        public FormIngresarNewContraseña()
        {
            InitializeComponent();
            Utilidades();
        }
        private void Utilidades()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(PibMinimizar, "Minimizar");
            toolTip.SetToolTip(PibCerrar, "Cerrar");
            toolTip.SetToolTip(PibVolver, "Volver a la ventana de Login");

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text == "")
            {
                MessageBox.Show("Ingrese su N° de Identificación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtusuario.Focus();
            }
            else if (TxtPass1.Text == "")
            {
                MessageBox.Show("Ingrese una Nueva Contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPass1.Focus();

            }
            else if (TxtPass2.Text == "")
            {
                MessageBox.Show("Vuelva a escribir su Nueva Contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPass2.Focus();
            }
            else
            {
                try
                {
                    DataTable data = consultas.D_Validacion_Contraseña(txtusuario.Text);

                    string DNI = data.Rows[0]["Tra_DNI"].ToString();
                    string Pass = data.Rows[0]["Usu_Pass"].ToString();
                    DNI = txtusuario.Text;
                    if (TxtPass1.Text == TxtPass2.Text)
                    {
                        if (Pass == "")
                        {
                            consultas.D_Agregar_Contraseña(txtusuario.Text, TxtPass1.Text);
                            MessageBox.Show("Registro de Contraseña Exitoso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            FormLogin hg = ((FormLogin)Owner);
                            hg.ReestablecerPass(TxtPass1.Text);
                            hg.Show();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Usuario ya cuenta con contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas Ingresadas no son ingual por favor ingrese de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Usuario Incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            //this.Hide();

            //FormLogin frm = new FormLogin();

            //frm.Show();

            FormLogin hg = ((FormLogin)Owner);
            hg.Show();
            //hg.ShowInTaskbar = true;
            this.Close();
        }

        private void txtContraseña2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void PibIngresar_MouseEnter(object sender, EventArgs e)
        {
            PibIngresar.Image = Properties.Resources.BotonReestablecer02;
        }

        private void PibIngresar_MouseLeave(object sender, EventArgs e)
        {
            PibIngresar.Image = Properties.Resources.BotonReestablecer01;

        }

        private void PibMinimizar_MouseEnter(object sender, EventArgs e)
        {
            PibMinimizar.Image = Properties.Resources.BotonVentanaMinimizar02;

        }

        private void PibMinimizar_MouseLeave(object sender, EventArgs e)
        {
            PibMinimizar.Image = Properties.Resources.BotonVentanaMinimizar01;

        }

        private void PibCerrar_MouseEnter(object sender, EventArgs e)
        {
            PibCerrar.Image = Properties.Resources.BotonVentanaCerrar02;

        }

        private void PibCerrar_MouseLeave(object sender, EventArgs e)
        {
            PibCerrar.Image = Properties.Resources.BotonVentanaCerrar01;

        }

        private void PibVolver_MouseEnter(object sender, EventArgs e)
        {
            PibVolver.Image = Properties.Resources.BotonVentanaAtras04;

        }

        private void PibVolver_MouseLeave(object sender, EventArgs e)
        {
            PibVolver.Image = Properties.Resources.BotonVentanaAtras01;

        }

        //Mover Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar)) e.Handled = false;
            else if (char.IsControl(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }

        private void FormIngresarNewContraseña_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;

        }
    }
}
