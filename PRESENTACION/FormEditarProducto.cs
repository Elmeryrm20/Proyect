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
            ObtenerPertenencia();
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
        void ObtenerPertenencia()
        {
            CmbPertenencia.DisplayMember = "Per_Desc";
            CmbPertenencia.DataSource = consultas.D_Pertenencia();
        }
        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void SeleccionarFila()
        {
            //MessageBox.Show("Datos actualizados correctamente");
            FormMedicamentos FrmMed = Owner as FormMedicamentos;
            FrmMed.Actualizar();
            FrmMed.dgb_Medicamentos.CurrentCell = FrmMed.dgb_Medicamentos.Rows[id_Medicamento - 1].Cells[1];
            Close();
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

                    consultas.SP_Editar_Producto(id_Medicamento, (txtNombre.Text).ToUpper(), txt_fecha.Value.ToString("yyyy-MM-dd"), CmbPresentacion.SelectedIndex + 1, cmbLab.SelectedIndex + 1, cmbTipo.SelectedIndex + 1, cmbCaja.SelectedIndex + 1, img, CmbPertenencia.SelectedIndex +1);
                }
                else
                {
                    byte[] img = null;
                    consultas.SP_Editar_Producto(id_Medicamento, (txtNombre.Text).ToUpper(), txt_fecha.Value.ToString("yyyy-MM-dd"), CmbPresentacion.SelectedIndex + 1, cmbLab.SelectedIndex + 1, cmbTipo.SelectedIndex + 1, cmbCaja.SelectedIndex + 1, img, CmbPertenencia.SelectedIndex + 1);
                }
                MessageBox.Show("Los cambios Guardados", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SeleccionarFila();

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
                DataTable dt = consultas.D_Medicamento_Detallado(id_Medicamento);
                txtNombre.Text = dt.Rows[0][0].ToString(); //Composición
                cmbCaja.Text = dt.Rows[0][3].ToString(); //Almacén
                txt_fecha.Text = ((DateTime)dt.Rows[0][4]).ToString("D"); //Fecha Vencimiento
                cmbTipo.Text = dt.Rows[0][5].ToString(); //Tipo
                cmbLab.Text = dt.Rows[0][6].ToString();  //Laboratorio
                CmbPresentacion.Text = dt.Rows[0][7].ToString(); //Presentación
                CmbPertenencia.Text = dt.Rows[0][8].ToString();

                //txtNombre.Text = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["COMPOSICIÓN"].ToString();
                //txt_fecha.Text = ((DateTime)consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["FEC. VENCIMIENTO"]).ToString("D");
                //cmbTipo.Text = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["TIPO"].ToString();
                //cmbCaja.Text = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["ALMACÉN"].ToString();
                //CmbPresentacion.Text = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["PRESENTACIÓN"].ToString();
                //cmbLab.Text = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["LABORATORIO"].ToString();

                //-----------------Imagen--------------------------
                try
                {
                    //MemoryStream img = new MemoryStream((byte[])consultas.D_Medicamento_Detallado(valor).Rows[0]["imagen"]);
                    MemoryStream img = new MemoryStream((byte[])dt.Rows[0][9]);
                    Bitmap imagen = new Bitmap(img);
                    ptb_Imagen.Image = imagen;
                    ptb_Imagen.SizeMode = PictureBoxSizeMode.CenterImage;
                    ptb_Imagen.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception)
                {
                    if (dt.Rows[0][9] == null)
                    {
                        ptb_Imagen.Image = Properties.Resources.Imagen01;
                    }
                    else
                    {
                        string Nombre_Imagen = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["COMPOSICIÓN"].ToString();
                        string str = Convert.ToString(Directory.GetCurrentDirectory());
                        str = str.Replace(@"\bin\Debug", "");
                        ptb_Imagen.Image = Image.FromFile(str + @"\Resources\Error.jpg");
                        ptb_Imagen.SizeMode = PictureBoxSizeMode.CenterImage;
                        ptb_Imagen.SizeMode = PictureBoxSizeMode.Zoom;

                    }

                }
                //-----------------------------------------------

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Selecione un producto Válido.", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());

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

        private void FormEditarProducto_Load_1(object sender, EventArgs e)
        {

        }
    }
}
