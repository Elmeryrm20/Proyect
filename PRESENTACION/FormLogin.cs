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

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtusuario.Text = "";
            if (radioButton1.Checked == true)
            {
                label2.Text = "DNI";
                txtusuario.MaxLength = 8;
                txtusuario.Text = txtusuario.Text.Trim();
            }
            else if (radioButton2.Checked == true)
            {
                label2.Text = "PASAPORTE";
                txtusuario.MaxLength = 20;
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
    }
}
