using DATOS;
using System;
using System.Data;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }

        Consultas du = new Consultas();

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void Ingresar()
        {
            DataTable dt = du.D_Login(txtusuario.Text, TxtPass.Text);

            //MessageBox.Show(dt.Rows[0][0].ToString());

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                if (dt.Rows[0][1].ToString() == "1")
                {

                    FormPrincipal A = new FormPrincipal(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                    A.Show();
                    AddOwnedForm(A);
                    //MessageBox.Show("Eres Encargado");

                }
                else if (dt.Rows[0][1].ToString() == "2")
                {
                    FormPrincipal A = new FormPrincipal(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                    A.Show();
                    AddOwnedForm(A);
                    //MessageBox.Show("Eres Admin");

                }
            }
            else
            {
                MessageBox.Show("Datos Incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PibIngresar.Image = Properties.Resources.BotonIngresar01;
                txtusuario.SelectAll();
                txtusuario.Focus();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ValidacionTextbox();

        }

        int n, mx, my;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (n == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormIngresarNewContraseña frm = new FormIngresarNewContraseña();

            frm.Show();
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

        private void PibIngresar_MouseEnter(object sender, EventArgs e)
        {
            PibIngresar.Image = Properties.Resources.BotonIngresar02;
        }

        private void PibIngresar_MouseLeave(object sender, EventArgs e)
        {
            PibIngresar.Image = Properties.Resources.BotonIngresar01;

        }

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

            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidacionTextbox();
            }


        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidacionTextbox();

            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            n = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            n = 1;
            mx = e.X;
            my = e.Y;
        }
    }
}
