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
        void mostrarUsuario()
        {
            dgb_Usuario.DataSource = consultas.ConsultaUsuario();
            dgb_Usuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
