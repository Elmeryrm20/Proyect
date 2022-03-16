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
    public partial class FormIngresarNewContraseña : Form
    {
        Consultas consultas = new Consultas();
        public FormIngresarNewContraseña()
        {
            InitializeComponent();
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
                if (txtusuario.Text=="")
                {
                    MessageBox.Show("Ingrese su DNI O Pasaporte", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtcontraseña.Text=="")
                {
                    MessageBox.Show("Ingrese Contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (txtContraseña2.Text == "")
                {
                    MessageBox.Show("Ingrese Contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                try
                {
                    DataTable data = consultas.D_Validacion_Contraseña(txtusuario.Text);

                    string DNI = data.Rows[0]["Tra_DNI"].ToString();
                    String Contraseña = data.Rows[0]["Usu_Pass"].ToString();
                    DNI = txtusuario.Text;
                    if (txtcontraseña.Text == txtContraseña2.Text)
                    {
                        if (Contraseña == "")
                        {
                            consultas.D_Agregar_Contraseña(txtusuario.Text, txtcontraseña.Text);
                            MessageBox.Show("Registro de Contraseña Exitoso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
            this.Hide();

            FormLogin frm = new FormLogin();

            frm.Show();
        }
    }
}
