﻿using DATOS;
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
            Utilidades();
            //Icon = Properties.Resources.Logo011;
        }

        Consultas du = new Consultas();

        private void Utilidades()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(PibMinimizar, "Minimizar");
            toolTip.SetToolTip(PibCerrar, "Cerrar");

        }

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
                MessageBox.Show("No ha ingresado el N° de su Documento de Identidad.");
                PibIngresar.Image = Properties.Resources.BotonIngresar01;
                txtusuario.Focus();

            }
            else if (TxtPass.Text == "" || TxtPass.Text == "Contraseña")
            {
                MessageBox.Show("No ha ingresado su contraseña.");
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
                //Thread.Sleep(1000);
                FormEspera B = new FormEspera(ud.DNI, ud.Tipo, ud.Nombre,ud.Cargo, ud.Filial);
                AddOwnedForm(B);
                B.Show();
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

        public void AbrirFormularioPrincipal()
        {

        }

        //Método de Ingreso
        private void Ingresar()
        {
            //0 DNI
            //1 Password
            //2 Tipo
            //3 Nombre
            //4 Estado
            //5 Cargo
            //6 Filial

            if (txtusuario.Text != ud.DNI) //Es diferente al DNI en el Caché
            {
                DataTable dt = du.D_Login(txtusuario.Text);

                if (dt.Rows.Count >= 1) //Si encuentra el usuario, guarda sus datos en el caché
                {
                    ud.DNI = dt.Rows[0][0].ToString();
                    ud.Pass = dt.Rows[0][1].ToString();
                    ud.Tipo = Convert.ToByte(dt.Rows[0][2]);
                    ud.Nombre = dt.Rows[0][3].ToString();
                    ud.Cargo = Convert.ToByte(dt.Rows[0][5]);
                    ud.Cargo = Convert.ToByte(dt.Rows[0][6]);
                    AdmitirPass();

                }
                else
                {
                    //MessageBox.Show("Usuario Incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PibCheckUsu.Visible = true;
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
        public void ReestablecerPass(string NuevaPass)
        {
            ud.Pass = NuevaPass;
        }
        //Boton principal
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ValidacionTextbox();
            //ShowInTaskbar = false;

        }

        //Nueva Contraseña
        private void label2_Click(object sender, EventArgs e)
        {

            FormIngresarNewContraseña frm = new FormIngresarNewContraseña();
            AddOwnedForm(frm);
            frm.Show();
            this.Hide();
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

        //private bool ActivarTextbox = false;
        private void Txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "DNI")
            {
                txtusuario.Clear();
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
                TxtPass.Clear();
                TxtPass.UseSystemPasswordChar = true;
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
                TxtPass.UseSystemPasswordChar = false;
            }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ActivarTextbox = true;
            PibCheckUsu.Visible = false;

            if ((char)Keys.Enter == e.KeyChar) ValidacionTextbox();
            else if ((char)Keys.Tab == e.KeyChar) e.Handled = false;
            else if (char.IsLetterOrDigit(e.KeyChar)) e.Handled = false;
            else if (char.IsControl(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

            PibCheckPass.Visible = false;

            if ((char)Keys.Enter == e.KeyChar) ValidacionTextbox();
            else if ((char)Keys.Tab == e.KeyChar) e.Handled = false;
            else if (char.IsLetterOrDigit(e.KeyChar)) e.Handled = false;
            else if (char.IsControl(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            Icon = Properties.Resources.Logo02;

        }
        public void Limpiar()
        {
            txtusuario.Text = "DNI";
            TxtPass.Text = "Contraseña";
            PibCheckUsu.Visible = false;
            PibCheckPass.Visible = false;
            ud.DNI = "";
            txtusuario.Focus();
        }

        private void TxtPass_Click(object sender, EventArgs e)
        {
            TxtPass.UseSystemPasswordChar = true;
        }

        private void txtusuario_Click(object sender, EventArgs e)
        {
            if (TxtPass.Text == "")
            {
                TxtPass.Text = "Contraseña";
                TxtPass.UseSystemPasswordChar = false;

            }
        }
    }
}
