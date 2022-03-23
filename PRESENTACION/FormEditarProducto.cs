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
using System.IO;


namespace PRESENTACION
{
    public partial class FormEditarProducto : Form
    {
        Consultas consultas = new Consultas();

        public FormEditarProducto()
        {
            InitializeComponent();
        }

        public FormEditarProducto(int id_Medicamento)
        {
            InitializeComponent();
            this.id_Medicamento = id_Medicamento;
            ObtenerTipo();
            ObtenerCaja();
            ObtenerPresentacion();
            ObtenerLaboratorio();
            Consulta_Editar_Medicamento();

        }
        readonly int id_Medicamento;
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
        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {

            try
            {
                if (ptb_Imagen.Image!=null)
                {
                    MemoryStream ms = new MemoryStream();
                    ptb_Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] img = ms.ToArray();

                    consultas.SP_Editar_Producto(id_Medicamento, (txtNombre.Text).ToUpper(), txt_fecha.Value.ToString("yyyy-MM-dd"), CmbPresentacion.SelectedIndex + 1, cmbLab.SelectedIndex + 1, cmbTipo.SelectedIndex + 1, cmbCaja.SelectedIndex + 1, img);
                }
                else
                {
                    byte[] img = null;
                    consultas.SP_Editar_Producto(id_Medicamento, (txtNombre.Text).ToUpper(), txt_fecha.Value.ToString("yyyy-MM-dd"), CmbPresentacion.SelectedIndex + 1, cmbLab.SelectedIndex + 1, cmbTipo.SelectedIndex + 1, cmbCaja.SelectedIndex + 1, img);
                }
                MessageBox.Show("Los cambios Guardados", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Consulta_Editar_Medicamento();

            }
            catch (Exception)
            {

                MessageBox.Show("Error", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        void Consulta_Editar_Medicamento()
        {

            try
            {
                txtNombre.Text = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["COMPOSICIÒN"].ToString();
                txt_fecha.Text = ((DateTime)consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["FEC.VENCIMIENTO"]).ToString("D");
                cmbTipo.Text = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["TIPO"].ToString();
                cmbCaja.Text = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["ALMACEN"].ToString();
                CmbPresentacion.Text = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["PRESENTACIÒN"].ToString();
                cmbLab.Text = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["LABORATORIO"].ToString();
                try
                {
                    MemoryStream img = new MemoryStream((byte[])consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["imagen"]);
                    Bitmap imagen = new Bitmap(img);
                    ptb_Imagen.Image = imagen;
                    ptb_Imagen.SizeMode = PictureBoxSizeMode.CenterImage;
                    ptb_Imagen.SizeMode = PictureBoxSizeMode.Zoom;

                }
                catch (Exception)
                {
                    string Nombre_Imagen = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["COMPOSICIÒN"].ToString();
                    string str = Convert.ToString(Directory.GetCurrentDirectory());
                    str = str.Replace(@"\bin\Debug", "");
                    ptb_Imagen.Image = Image.FromFile(str + @"\Resources\Error.jpg");
                    ptb_Imagen.SizeMode = PictureBoxSizeMode.CenterImage;
                    ptb_Imagen.SizeMode = PictureBoxSizeMode.Zoom;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Selecione un producto Valido", "erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                ptb_Imagen.SizeMode = PictureBoxSizeMode.CenterImage;
                ptb_Imagen.SizeMode = PictureBoxSizeMode.Zoom;
                ptb_Imagen.Load(Imagen);
            }
        }

        private void FormEditarProducto_Load(object sender, EventArgs e)
        {
           
        }


     
    }
}
