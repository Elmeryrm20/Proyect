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
            this.Hide();

        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {

            try
            {

                consultas.SP_Editar_Producto(id_Medicamento, txtNombre.Text, txt_fecha.Value.ToString("yyyy-MM-dd"), CmbPresentacion.SelectedIndex + 1, cmbLab.SelectedIndex + 1, cmbTipo.SelectedIndex + 1, cmbCaja.SelectedIndex + 1);
                MessageBox.Show("Los cambios Guardados", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception)
            {

                MessageBox.Show("Error", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }
        void Consulta_Editar_Medicamento()
        {
            txtNombre.Text = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["COMPOSICIÒN"].ToString();
            txt_fecha.Text = ((DateTime)consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["FEC.VENCIMIENTO"]).ToString("D");
            cmbTipo.Text = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["TIPO"].ToString();
            cmbCaja.Text = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["ALMACEN"].ToString();
            CmbPresentacion.Text = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["PRESENTACIÒN"].ToString();
            cmbLab.Text = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["LABORATORIO"].ToString();
            try
            {
                string Nombre_Imagen = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["COMPOSICIÒN"].ToString();
                string str = Convert.ToString(Directory.GetCurrentDirectory());
                str = str.Replace(@"\bin\Debug", "");
                ptb_Imagen.Image = Image.FromFile(str + @"\Resources\" + Nombre_Imagen + ".jpeg");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
