using DATOS;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using USUARIO;

namespace PRESENTACION
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }

        Consultas du = new Consultas();

        #region Botones de Ventana
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea Salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            PibMinimizar.Image = Properties.Resources.BotonVentanaMinimizar04;
        }

        private void PibMinimizar_MouseLeave(object sender, EventArgs e)
        {
            PibMinimizar.Image = Properties.Resources.BotonVentanaMinimizar03;

        }

        private void PibCerrar_MouseEnter(object sender, EventArgs e)
        {
            PibCerrar.Image = Properties.Resources.BotonVentanaCerrar04;

        }

        private void PibCerrar_MouseLeave(object sender, EventArgs e)
        {
            PibCerrar.Image = Properties.Resources.BotonVentanaCerrar03;

        }
        #endregion

        #region Botones Principales


        //Validación campos vacíos
        private void ValidacionTextbox()
        {

            PibIngresar.Image = Properties.Resources.BotonIngresar02;

            if (txtusuario.Text == "" || txtusuario.Text == "DNI")
            {
                MessageBox.Show("No hay ingresado el N° de su Documento de Identidad.");
                PibIngresar.Image = Properties.Resources.BotonIngresar01;
                txtusuario.Focus();

            }
            else if (TxtPass.Text == "" || TxtPass.Text == "Contraseña")
            {
                MessageBox.Show("No hay ingresado su contraseña .");
                PibIngresar.Image = Properties.Resources.BotonIngresar01;

                TxtPass.Focus();
            }
            else
            {
                Ingresar();
            }
        }

        U_DatosUsuario01 ud = new U_DatosUsuario01();

        private void AdmitirPass()
        {
            PibCheckUsu.Visible = true;
            //PibCheckUsu.BackColor = Color.Green;
            PibCheckUsu.Image = Properties.Resources.BotonValidarCheck02;



            if (TxtPass.Text == ud.Pass)
            {
                this.Hide();
                FormPrincipal A = new FormPrincipal(ud.DNI, ud.Tipo, ud.Nombre);
                A.Show();
                AddOwnedForm(A);
            }
            else
            {
                //MessageBox.Show("Contraseña Incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PibCheckPass.Visible = true;
                PibIngresar.Image = Properties.Resources.BotonIngresar01;
                TxtPass.SelectAll();
                TxtPass.Focus();
            }
        }

        //Método de Ingreso
        private void Ingresar()
        {
            //0 Codigo
            //1 Password
            //2 Tipo
            //3 Nombre

            if (txtusuario.Text != ud.DNI)
            {
                DataTable dt = du.D_Login(txtusuario.Text);

                if (dt.Rows.Count >= 1)
                {
                    ud.DNI = dt.Rows[0][0].ToString();
                    ud.Pass = dt.Rows[0][1].ToString();
                    ud.Tipo = dt.Rows[0][2].ToString();
                    ud.Nombre = dt.Rows[0][3].ToString();
                    AdmitirPass();

                }
                else
                {
                    //MessageBox.Show("Usuario Incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PibCheckUsu.Visible = true;
                    //PibCheckUsu.BackColor = Color.Red;
                    PibCheckUsu.Image = Properties.Resources.BotonValidarCheck01;
                    PibIngresar.Image = Properties.Resources.BotonIngresar01;

                    TxtPass.Text = "Contraseña";
                    PibCheckPass.Visible = false;

                    txtusuario.SelectAll();
                    txtusuario.Focus();
                }

            }
            else
            {
                AdmitirPass();
            }

        }

        //Boton principal
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ValidacionTextbox();

        }

        //Nueva Contraseña
        private void label2_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormIngresarNewContraseña frm = new FormIngresarNewContraseña();

            frm.Show();

            AddOwnedForm(frm);
        }
        #endregion

        #region Eventos sin usar
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbldocumento_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcontraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtusuario_MouseEnter(object sender, EventArgs e)
        {

        }
        #endregion

        #region Animación Botón Ingresar
        private void PibIngresar_MouseEnter(object sender, EventArgs e)
        {
            PibIngresar.Image = Properties.Resources.BotonIngresar02;
        }

        private void PibIngresar_MouseLeave(object sender, EventArgs e)
        {
            PibIngresar.Image = Properties.Resources.BotonIngresar01;

        }
        #endregion

        #region Métodos de los TextBox



        private bool ActivarTextbox = false;
        private void Txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "DNI")
            {
                txtusuario.SelectAll();
            }
            //if (txtusuario.Text == "DNI")
            //{
            //    if (ActivarTextbox == true)
            //    {
            //        txtusuario.Text = "";
            //    }

            //}
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (TxtPass.Text == "Contraseña")
            {
                TxtPass.SelectAll();
            }
            //ActivarTextbox = true;
            //if (TxtPass.Text == "Contraseña")
            //{

            //    TxtPass.Text = "";
            //    TxtPass.UseSystemPasswordChar = true;

            //}
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "DNI";
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (TxtPass.Text == "")
            {
                //TxtPass.UseSystemPasswordChar = false;
                TxtPass.Text = "Contraseña";
            }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ActivarTextbox = true;
            PibCheckUsu.Visible = false;
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidacionTextbox();
            }


        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

            PibCheckPass.Visible = false;

            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidacionTextbox();

            }

        }

        #endregion

        #region Panel Movimiento

        //Mover Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //int n, mx, my;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (n == 1)
            //{
            //    this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            //}
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //n = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //n = 1;
            //mx = e.X;
            //my = e.Y;

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
