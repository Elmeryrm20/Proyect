using DATOS;
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

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
            ObtenerPresentacion();
            ObtenerLaboratorio();

        }
        validar validacion = new validar();
        void ObtenerTipo()
        {
            cmbTipo.DisplayMember = "tip_descripcion";
            cmbTipo.DataSource = consultas.tipo();
        }

        void ObtenerPresentacion()
        {
            CmbPresentacion.DisplayMember = "pre_descripcion";
            CmbPresentacion.DataSource = consultas.presentacion();

        }

        void ObtenerCaja()
        {
            cmbCaja.DisplayMember = "Alm_Descripcion";
            cmbCaja.DataSource = consultas.caja();

        }
        void ObtenerLaboratorio()
        {
            cmbLab.DisplayMember = "Lab_Descripcion";
            cmbLab.DataSource = consultas.D_Laboratorio();
        }

        public string fecha;

        private void FormAgregarMedicamento_Load(object sender, EventArgs e)
        {
            fecha = DateTime.Now.ToString("d");
            dtFecha_Vencimiento.MinDate = DateTime.Now;
            dtFecha_Vencimiento.Value = DateTime.Now;
            cmbLab.Text = "Seleccione Laboratorio";
            cmbTipo.Text = "Seleccione Tipo";
            CmbPresentacion.Text = "Seleccione Presentacion";
            cmbCaja.Text = "Seleccione Caja";
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
            else if (cmbLab.SelectedIndex == -1)
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
            else if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Falta escojer el tipo.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CmbPresentacion.SelectedIndex == -1)
            {
                MessageBox.Show("Falta escoger para quién será.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCaja.SelectedIndex == -1)
            {
                MessageBox.Show("Falta escojer en caja.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pictureBox1.Image != null)
                {
                    string str = Convert.ToString(Directory.GetCurrentDirectory());
                    str = str.Replace(@"\bin\Debug", "");
                    pictureBox1.Image.Save(str + @"\Resources\" + textNombre.Text +" "+textGramaje.Text + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                consultas.D_AgregarMedicamento((textNombre.Text + " " + textGramaje.Text).ToUpper(), int.Parse(textCantidad.Text), cmbLab.SelectedIndex + 1, dtFecha_Vencimiento.Value.ToString("yyyy-MM-dd"), cmbTipo.SelectedIndex + 1, cmbCaja.SelectedIndex + 1, DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH:mm:ss"), 0, CmbPresentacion.SelectedIndex + 1);

                MessageBox.Show("Datos Ingresados Correctamente.", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                textNombre.Text = "";
                textCantidad.Text = "";
                textGramaje.Text = "";
                cmbCaja.Text = "Seleccione Caja";
                cmbLab.Text = "Seleccione Laboratorio";
                cmbTipo.Text = "Seleccione Tipo";
                CmbPresentacion.Text = "Seleccione Presentacion";
                dtFecha_Vencimiento.Value = DateTime.Now;
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

        private void LblMuestra1_Click(object sender, EventArgs e)
        {
            LblMuestra1.Text = dtFecha_Vencimiento.Value.ToString("yyyy-MM-dd");
        }

        private void cmbTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.Texto_Inmodificable(e);
        }

        private void CmbPresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.Texto_Inmodificable(e);
        }

        private void cmbCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.Texto_Inmodificable(e);
        }

        private void cmbLab_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.Texto_Inmodificable(e);
        }

        private void bnt_Agregar_Lab_Click(object sender, EventArgs e)
        {
            FormAgregarLaboratorio frm = new FormAgregarLaboratorio();
            frm.ShowDialog();
        }

        private void FormAgregarMedicamento_Resize(object sender, EventArgs e)
        {
            
        }

        private void FormAgregarMedicamento_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width > 592 && this.Height > 406)
            {
                var bounds = Screen.FromControl(this).Bounds;
                double xval = bounds.Width / 16;
                int x = (int)Math.Round(xval);
                double yval = bounds.Height / 8;
                int y = (int)Math.Round(yval);
                gpbAgregar_Producto.Location = new Point(x, y);
            }
            
        }

        private void cmbLab_MouseDown(object sender, MouseEventArgs e)
        {
            ObtenerLaboratorio();
        }
    }
}