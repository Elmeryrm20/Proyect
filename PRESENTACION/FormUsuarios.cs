using DATOS;
using System;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormUsuarios : Form
    {
        Consultas consultas = new Consultas();

        public FormUsuarios()
        {
            InitializeComponent();
        }

        public FormUsuarios(string DNI)
        {
            InitializeComponent();
            this.DNI = DNI;
            mostrarUsuario();
        }
        string DNI;
        string valor_ID = "";
        string NOMBRE = "";
        public void mostrarUsuario()
        {
            dgb_Usuario.DataSource = consultas.ConsultaUsuario();
            dgb_Usuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pb_Click(object sender, EventArgs e)
        {
            FormPrincipal fr = Owner as FormPrincipal;
            //fr.LlamarFormularioA_U();
            fr.AparecerFormulario<FormAgregarUsuario>();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            mostrarUsuario();

        }

        private void bt_EditarU_Click(object sender, EventArgs e)
        {
            if (valor_ID != "")
            {
                FormEditarUsuario frm = new FormEditarUsuario(valor_ID);
                AddOwnedForm(frm);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione Usuario", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void dgb_Usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            valor_ID = dgb_Usuario.CurrentRow.Cells[0].Value.ToString();
            NOMBRE = dgb_Usuario.CurrentRow.Cells[1].Value.ToString();
            label1.Text = valor_ID.ToString() + " " + NOMBRE;
        }

        private void btn_Restablecer_Click(object sender, EventArgs e)
        {
            if (valor_ID != "")
            {
                DialogResult result = MessageBox.Show("Seguro que desea restablecer la contraseña de " + NOMBRE, "Excelente!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    consultas.SP_Restablecer_C(valor_ID);
                    MessageBox.Show("Se a Restablecido la contraseña", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Seleccione Usuario", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

        }

        private void bt_EliminarU_Click(object sender, EventArgs e)
        {
            if (valor_ID != "")
            {
                DialogResult result = MessageBox.Show("Seguro que desea eliminar a " + NOMBRE, "Excelente!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    consultas.SP_Eliminar_U(valor_ID, 3);
                    MessageBox.Show("Usuario Eliminado", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    mostrarUsuario();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Seleccione Usuario", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }
    }
}
