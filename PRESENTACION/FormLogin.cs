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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            //DtgPrueba.DataSource = du.D_Login("123","123");


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

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                validar.soloNumeros(e);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DataTable dt = du.D_Login(txtusuario.Text, txtcontraseña.Text);

            //MessageBox.Show(dt.Rows[0][0].ToString());

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                if (dt.Rows[0][2].ToString() == "1")
                {
                    FormPrincipal A = new FormPrincipal(dt.Rows[0][0].ToString(), "1");
                    A.Show();
                    AddOwnedForm(A);
                    //MessageBox.Show("Eres Encargado");

                }
                else if (dt.Rows[0][2].ToString() == "2")
                {
                    FormPrincipal A = new FormPrincipal(dt.Rows[0][0].ToString(), "2");
                    A.Show();
                    AddOwnedForm(A);
                    //MessageBox.Show("Eres Admin");

                }
            }
            else
            {
                MessageBox.Show("Datos Incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void DtgPrueba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                lbldocumento.Text = "DNI";
                txtusuario.MaxLength = 8;
                txtusuario.Text = txtusuario.Text.Trim();
                txtusuario.Enabled = true;
                txtcontraseña.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lbldocumento.Text = "PASAPORTE";
                txtusuario.MaxLength = 20;
                txtusuario.Enabled = true;
                txtcontraseña.Enabled = true;
            }
        }
        int n, mx, my;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (n == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
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
