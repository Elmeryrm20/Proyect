using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS;

namespace PRESENTACION
{
    public partial class FormAgregarMedicamento : Form
    {
        Consultas consultas = new Consultas();
        public FormAgregarMedicamento()
        {
            InitializeComponent();
            ObtenerTipo();
            ObtenerCaja();
        }

        void ObtenerTipo()
        {
            cmbTipo.DisplayMember = "tip_descripcion";
            cmbTipo.DataSource=consultas.tipo();
           
        }
        void ObtenerCaja()
        {
           cmbCaja.DisplayMember = "Alm_Descripcion";
            cmbCaja.DataSource = consultas.caja();

        }
        public string fecha;

        private void FormAgregarMedicamento_Load(object sender, EventArgs e)
        {
            fecha = dtFecha_Vencimiento.Text;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (textNombre.Text == "")
            {
                MessageBox.Show("Falta completar el campo nombre.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textCantidad.Text == "")
            {
                MessageBox.Show("Falta completar el campo cantidad", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textLaboratorio.Text == "")
            {
                MessageBox.Show("Falta completar el campo laboratorio.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
            else if (dtFecha_Vencimiento.Text == fecha)
            {
                MessageBox.Show("Falta completar el campo Fecha de Vencimiento.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textGramaje.Text == "")
            {
                MessageBox.Show("Falta completar el campo Gramaje.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbTipo.Text == "")
            {
                MessageBox.Show("Falta escojer el tipo.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Falta escoger para quién será.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCaja.Text == "")
            {
                MessageBox.Show("Falta escojer en caja.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pictureBox1.Image == null)
            {
                MessageBox.Show("Falta completar el campo Subir Imagen.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string str = Convert.ToString(Directory.GetCurrentDirectory());
                str = str.Replace(@"\bin\Debug", "");
                pictureBox1.Image.Save(str + @"\Resources\" + textNombre.Text + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show("Datos Ingresados Correctamente.", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Escoja una imagen";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            openFileDialog1.ShowDialog();


            if (File.Exists(openFileDialog1.FileName))
            {
                string Imagen = openFileDialog1.FileName;
                string nombre = openFileDialog1.SafeFileName;

                this.Text = nombre;
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Load(Imagen);
            }
        }

        
    }
}