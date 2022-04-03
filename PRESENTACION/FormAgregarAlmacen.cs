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
    public partial class FormAgregarAlmacen : Form
    {
        public FormAgregarAlmacen()
        {
            InitializeComponent();
        }
        Consultas consultas = new Consultas();
        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre.Text.Length==0)
            {
                MessageBox.Show("Ingrese Almacen", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                consultas.SP_Agregar_Almacen(Txt_Nombre.Text);
                MessageBox.Show("Datos Ingresados Correctamente.", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close(); 
            }
        }
    }
}
