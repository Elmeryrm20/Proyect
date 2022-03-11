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

        D_Empleado du = new D_Empleado();

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
            if (radioButton1.Checked==true)
            {
                validar.soloNumeros(e);
            }  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (radioButton1.Checked == true)
            {
                label2.Text = "DNI";
                textBox1.MaxLength = 8;
                textBox1.Text = textBox1.Text.Trim();
            }
            else if (radioButton2.Checked == true)
            {
                label2.Text = "PASAPORTE";
                textBox1.MaxLength = 20;
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (du.conexionexitosa() == 1)
            {
                MessageBox.Show("Conección Exitosa");
            }
            else
            {
                MessageBox.Show("Conección Fallida");

            }
        }
    }
}
