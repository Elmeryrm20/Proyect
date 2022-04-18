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
            NOMBRE = "\"" + dgb_Usuario.Rows[0].Cells[1].Value.ToString() + "\"";
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

            //fr.AparecerFormulario<FormAgregarUsuario>();
            fr.EscogerFormulario<FormAgregarUsuario>(9);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            mostrarUsuario();
            DesignDataGridView();

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

        }

        private void btn_Restablecer_Click(object sender, EventArgs e)
        {
            if (valor_ID != "")
            {
                DialogResult result = MessageBox.Show("Seguro que desea Reestablecer la contraseña de " + NOMBRE, "Excelente!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    consultas.SP_Restablecer_C(valor_ID);
                    MessageBox.Show("Se a Reestablecido la contraseña de "+ NOMBRE, "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void dgb_Usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valor_ID = dgb_Usuario.CurrentRow.Cells[0].Value.ToString();
            NOMBRE = dgb_Usuario.CurrentRow.Cells[1].Value.ToString();
            label1.Text = valor_ID.ToString() + " " + NOMBRE;
        }

        private void btn_Restablecer_MouseEnter(object sender, EventArgs e)
        {
            btn_Restablecer.Image = Properties.Resources.BotonFormElimiarPass02;
        }

        private void btn_Restablecer_MouseLeave(object sender, EventArgs e)
        {
            btn_Restablecer.Image = Properties.Resources.BotonFormElimiarPass01;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DesignDataGridView()
        {
            dgb_Usuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgb_Usuario.Columns[0].Visible = false;
            //dgb_Medicamentos.Columns[0].Width = 25;
            //dgb_Medicamentos.Columns[0].MinimumWidth = 25;
            //dgb_Medicamentos.Columns[1].Width = 250;
            dgb_Usuario.ColumnHeadersHeight = 35;
            dgb_Usuario.Columns[0].MinimumWidth = 90;
            dgb_Usuario.Columns[1].MinimumWidth = 150;
            dgb_Usuario.Columns[3].MinimumWidth = 90;
        }
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            DesignDataGridView();
        }

        private void dgb_Usuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
    }
}
