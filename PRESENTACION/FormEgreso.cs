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

            if (txtCantidad.Text.Length != 0)
            {
                try
                {
                    int Ingreso = (int)consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL INGRESADO"];
                    int Egreso = (int)consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL EGRESADO"];
                    int Existencias = Ingreso - Egreso;

                    if (Convert.ToInt32(txtCantidad.Text) <= Existencias)
                    {
                        consultas.SP_Agregar_Egreso_Medicamento(valor.ToString(), txtCantidad.Text);
                        consultas.SP_Agregar_Detalle_Egreso(valor.ToString(), txtCantidad.Text, DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH-mm-ss"), DNI, 4);
                        MessageBox.Show("Actualizacion Exitosa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Los productos exeden al stock del mediacamento", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                MessageBox.Show("Ingrese Campo", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
