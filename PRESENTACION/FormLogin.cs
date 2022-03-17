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


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DataTable dt = du.D_Login(txtusuario.Text, txtcontraseña.Text);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormIngresarNewContraseña frm = new FormIngresarNewContraseña() ;

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
