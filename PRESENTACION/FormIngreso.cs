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
    public partial class FormIngreso : Form
    {
        Consultas consultas = new Consultas();
        public FormIngreso()
        {
            InitializeComponent();
        }
        public FormIngreso(int valor)
        {
            InitializeComponent();
            Ingreso(valor);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void Ingreso(int valor)
        {
            lbl_Nombre.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["COMPOSICIÒN"].ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
