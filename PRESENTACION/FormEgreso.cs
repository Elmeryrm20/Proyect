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
    public partial class FormEgreso : Form
    {
        Consultas consultas=new Consultas();
        public FormEgreso()
        {
            InitializeComponent();
           

        }

        public FormEgreso(int valor ,string DNI)
        {
            InitializeComponent();
            this.valor = valor;
            this.DNI = DNI;
            Egreso();
        }
        readonly int valor;
        readonly string DNI;
        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void Egreso()
        {
            lbl_Nombre.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["COMPOSICIÒN"].ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                consultas.SP_Agregar_Egreso_Medicamento(valor.ToString(), txtCantidad.Text);
                consultas.SP_Agregar_Detalle_Egreso(valor.ToString(), txtCantidad.Text, DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH-mm-ss"), DNI,4);
                MessageBox.Show("Actualizacion Exitosa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Cagaste prro problemas de conexion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
