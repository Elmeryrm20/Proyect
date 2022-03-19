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
    public partial class FormUsuarios : Form
    {
        Consultas consultas = new Consultas();
        public FormUsuarios()
        {
            InitializeComponent();
            mostrarUsuario();
        }
        string valor_ID = "";
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
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            mostrarUsuario();

        }

        private void bt_EditarU_Click(object sender, EventArgs e)
        {
            if (valor_ID !="")
            {
                FormEditarUsuario frm = new FormEditarUsuario(valor_ID);
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
            label1.Text = valor_ID.ToString();
        }
    }
}
