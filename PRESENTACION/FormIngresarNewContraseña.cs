using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            //this.Hide();

            //FormLogin frm = new FormLogin();

            //frm.Show();

            FormLogin hg = ((FormLogin)Owner);
            hg.Show();
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
    }
}
