﻿using System;
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

        public FormEditarProducto(int id_Medicamento, byte CodigoFilial)
        {
            InitializeComponent();
            this.id_Medicamento = id_Medicamento;
            ObtenerTipo();
            ObtenerAlmacen();
            ObtenerLaboratorio();
            ObtenerPertenencia();
            Consulta_Editar_Medicamento();

        }
        readonly int id_Medicamento;
        readonly byte CodigoFilial;

        #region Métodos de ComboBox
        void ObtenerTipo()
        {
            cmbTipo.DisplayMember = "tip_descripcion";
            cmbTipo.DataSource = consultas.D_ListaPresentacion();
        }

        private string[,] Almacen;
        void ObtenerAlmacen()
        {
            DataTable dt_Almacen = consultas.D_Lista_Almacen(CodigoFilial);
            Almacen = new string[dt_Almacen.Rows.Count, 2];
            for (int i = 0; i < dt_Almacen.Rows.Count; i++)
            {
                Almacen[i, 0] = dt_Almacen.Rows[i][0].ToString();
                Almacen[i, 1] = dt_Almacen.Rows[i][1].ToString();
                cmbCaja.Items.Add(Almacen[i, 1]);
            }
            cmbCaja.SelectedIndex = 0;
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
        #endregion
        private void btnSerrar_Click(object sender, EventArgs e)
        {
            FormMedicamentos fr =Owner as FormMedicamentos;
            fr.Rellenartabla();
            this.Close();
        }
        void SeleccionarFila()
        {
            //MessageBox.Show("Datos actualizados correctamente");
            FormMedicamentos FrmMed = Owner as FormMedicamentos;
            FrmMed.Rellenartabla();
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

                    consultas.SP_Editar_Producto(id_Medicamento, (txtNombre.Text).ToUpper(), txt_fecha.Value.ToString("yyyy-MM-dd"), cmbTipo.SelectedIndex + 1, int.Parse(Almacen[cmbCaja.SelectedIndex,0]), img, CmbPertenencia.SelectedIndex +1);
                }
                else
                {
                    byte[] img = null;
                    consultas.SP_Editar_Producto(id_Medicamento, (txtNombre.Text).ToUpper(), txt_fecha.Value.ToString("yyyy-MM-dd"), cmbTipo.SelectedIndex + 1, int.Parse(Almacen[cmbCaja.SelectedIndex, 0]), img, CmbPertenencia.SelectedIndex + 1);
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
                DataTable dt = consultas.D_Detalles_Medicamento(id_Medicamento);
                txtNombre.Text = dt.Rows[0][0].ToString(); //Composición
                cmbCaja.Text = dt.Rows[0][3].ToString(); //Almacén
                txt_fecha.Text = ((DateTime)dt.Rows[0][4]).ToString("D"); //Fecha Vencimiento
                cmbTipo.Text = dt.Rows[0][5].ToString(); //Tipo
                //cmbLab.Text = dt.Rows[0][6].ToString();  //Laboratorio
                CmbPresentacion.Text = dt.Rows[0][6].ToString(); //Presentación
                CmbPertenencia.Text = dt.Rows[0][7].ToString();

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
                    MemoryStream img = new MemoryStream((byte[])dt.Rows[0][8]);
                    Bitmap imagen = new Bitmap(img);
                    ptb_Imagen.Image = imagen;
                    ptb_Imagen.SizeMode = PictureBoxSizeMode.CenterImage;
                    ptb_Imagen.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception)
                {
                    ptb_Imagen.Image = Properties.Resources.Imagen01;
                    //if (dt.Rows[0][9] == null)
                    //{
                    //    ptb_Imagen.Image = Properties.Resources.Imagen01;
                    //}
                    //else
                    //{
                    //    string Nombre_Imagen = consultas.D_Medicamento_Detallado(id_Medicamento).Rows[0]["COMPOSICIÓN"].ToString();
                    //    string str = Convert.ToString(Directory.GetCurrentDirectory());
                    //    str = str.Replace(@"\bin\Debug", "");
                    //    ptb_Imagen.Image = Image.FromFile(str + @"\Resources\Error.jpg");
                    //    ptb_Imagen.SizeMode = PictureBoxSizeMode.CenterImage;
                    //    ptb_Imagen.SizeMode = PictureBoxSizeMode.Zoom;

                    //}

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

        private void Btn_Editar_MouseEnter(object sender, EventArgs e)
        {
            Btn_Editar.Image = Properties.Resources.BotonFormConfirmar08;
        }

        private void Btn_Editar_MouseLeave(object sender, EventArgs e)
        {
            Btn_Editar.Image = Properties.Resources.BotonFormConfirmar07;

        }

        private void btnSerrar_MouseEnter(object sender, EventArgs e)
        {
            btnSerrar.Image = Properties.Resources.BotonFormCancelar08;
        }

        private void btnSerrar_MouseLeave(object sender, EventArgs e)
        {
            btnSerrar.Image = Properties.Resources.BotonFormCancelar07;

        }
    }
}
