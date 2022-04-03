﻿using DATOS;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormAgregarMedicamento : Form
    {
        Consultas consultas = new Consultas();

        public FormAgregarMedicamento()
        {
            InitializeComponent();

        }
        public FormAgregarMedicamento(string Tra_DNI)
        {
            this.Tra_DNI = Tra_DNI;
            InitializeComponent();


        }

        string Tra_DNI;

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
            ObtenerTipo();
            ObtenerCaja();
            ObtenerPresentacion();
            ObtenerLaboratorio();

            fecha = DateTime.Now.ToString("d");
            dtFecha_Vencimiento.MinDate = DateTime.Now;
            dtFecha_Vencimiento.Value = DateTime.Now;
            cmbLab.Text = "Seleccionar";
            cmbTipo.Text = "Seleccionar";
            CmbPresentacion.Text = "Seleccionar";
            cmbCaja.Text = "Seleccionar";
        }
        private bool Validaciones()
        {
            bool valor = true;
            if (textNombre.Text == "" || textNombre.Text == "Nombre")
            {
                errorProvider1.SetError(textNombre, "Por favor, ingrese un nombre");
                textNombre.SelectAll();
                textNombre.Focus();
                valor = false;
            }
            else
            {
                errorProvider1.SetError(textNombre, "");
            }

            if (textCantidad.Text == "" || textCantidad.Text == "Cantidad")
            {
                errorProvider1.SetError(textCantidad, "Por favor, ingrese una cantidad");
                valor = false;
            }
            else
            {
                errorProvider1.SetError(textCantidad, "");
            }

            if (cmbLab.Text == "Seleccionar")
            {
                errorProvider1.SetError(cmbLab, "Por favor, seleccione o ingrese un laboratorio.");
                valor = false;
            }
            else
            {
                errorProvider1.SetError(cmbLab, "");
            }

            if (dtFecha_Vencimiento.Text == fecha)
            {
                errorProvider1.SetError(dtFecha_Vencimiento, "Por favor, ingrese una fecha.");
                valor = false;
            }
            else
            {
                errorProvider1.SetError(dtFecha_Vencimiento, "");
            }

            if (textGramaje.Text == "" || textGramaje.Text == "Gramaje")
            {
                errorProvider1.SetError(textGramaje, "Por favor, ingrese un valor para gramaje.");
                valor = false;
            }
            else
            {
                errorProvider1.SetError(textGramaje, "");
            }

            if (cmbTipo.Text == "Seleccionar")
            {
                errorProvider1.SetError(cmbTipo, "Por favor, seleccione un tipo.");
                valor = false;
            }
            else
            {
                errorProvider1.SetError(cmbTipo, "");
            }

            if (CmbPresentacion.Text == "Seleccionar")
            {
                errorProvider1.SetError(CmbPresentacion, "Por favor, seleccione una presentacion.");
                valor = false;
            }
            else
            {
                errorProvider1.SetError(CmbPresentacion, "");
            }

            if (cmbCaja.Text == "Seleccionar")
            {
                errorProvider1.SetError(cmbCaja, "Por favor, seleccione una caja.");
                valor = false;
            }
            else
            {
                errorProvider1.SetError(cmbCaja, "");
            }
            return valor;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Validaciones();
            if (Validaciones() == true)
            {
                try
                {
                    string texto = textNombre.Text + " " + textGramaje.Text;
                    string dt = consultas.D_Consulta_Dinamica(texto).Rows[0]["COMPOSICIÓN"].ToString();
                    if (dt == texto)
                    {
                        MessageBox.Show("El Medicamento Ya existe", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception)
                {

                    byte[] img;

                    if (PibImagen.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        PibImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        img = ms.ToArray();
                    }
                    else img = null;
                    string FechaActual = DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH-mm-ss");
                    consultas.D_AgregarMedicamento((textNombre.Text + " " + textGramaje.Text).ToUpper(), int.Parse(textCantidad.Text), cmbLab.SelectedIndex + 1, dtFecha_Vencimiento.Value.ToString("yyyy-MM-dd"), cmbTipo.SelectedIndex + 1, cmbCaja.SelectedIndex + 1, FechaActual, 0, CmbPresentacion.SelectedIndex + 1, img);
                    int CodigoMedicamento = consultas.D_UltimoIdIngresado();
                    string CodigoIngreso = consultas.D_ActualizarIngreso(Tra_DNI, FechaActual, 1);
                    consultas.SP_Agregar_Detalle_Ingreso(int.Parse(CodigoIngreso),CodigoMedicamento,int.Parse(textCantidad.Text), dtFecha_Vencimiento.Value.ToString("yyyy-MM-dd"));

                    MessageBox.Show("Datos Ingresados Correctamente.", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Limpiar();

                }
            }
        }

        private void Limpiar()
        {
            textNombre.Text = "Nombre";
            textCantidad.Text = "Cantidad";
            textGramaje.Text = "Gramaje";
            cmbCaja.Text = "Seleccionar";
            cmbLab.Text = "Seleccionar";
            cmbTipo.Text = "Seleccionar";
            CmbPresentacion.Text = "Seleccionar";
            dtFecha_Vencimiento.Value = DateTime.Now;
            PibImagen.Image = Properties.Resources.Imagen01;
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
                PibImagen.SizeMode = PictureBoxSizeMode.CenterImage;
                PibImagen.SizeMode = PictureBoxSizeMode.Zoom;
                PibImagen.Load(Imagen);
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
            if (this.Width > 721 && this.Height > 502)
            {
                var bounds = Screen.FromControl(this).Bounds;
                double xval = bounds.Width / 16;
                int x = (int)Math.Round(xval);
                double yval = bounds.Height / 8;
                int y = (int)Math.Round(yval);
                //gpbAgregar_Producto.Location = new Point(x, y);
            }
            else
            {
                //gpbAgregar_Producto.Location = new Point(87, 100);
            }
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
                //gpbAgregar_Producto.Location = new Point(x, y);
            }
            else
            {
                //gpbAgregar_Producto.Location = new Point(87, 100);
            }

        }

        private void cmbLab_MouseDown(object sender, MouseEventArgs e)
        {
            if (cmbLab.SelectedIndex == -1)
            {
                ObtenerLaboratorio();
            }
            else
            {
                int numero = Convert.ToInt32(cmbLab.SelectedIndex.ToString());
                ObtenerLaboratorio();
                cmbLab.SelectedIndex = numero;
            }
            
        }

        private void PibAgregarMedicamento_MouseEnter(object sender, EventArgs e)
        {
            PibAgregarMedicamento.Image = Properties.Resources.BotonFormNuevoMedicamentos06;
        }

        private void PibAgregarMedicamento_MouseLeave(object sender, EventArgs e)
        {
            PibAgregarMedicamento.Image = Properties.Resources.BotonFormNuevoMedicamentos05;
        }

        private void textNombre_Click(object sender, EventArgs e)
        {
            if (textNombre.Text == "Nombre")
            {
                textNombre.Text = "";
            }
        }

        private void textCantidad_Click(object sender, EventArgs e)
        {
            if (textCantidad.Text == "Cantidad")
            {
                textCantidad.Text = "";
            }
        }

        private void textGramaje_Click(object sender, EventArgs e)
        {
            if (textGramaje.Text == "Gramaje")
            {
                textGramaje.Text = "";
            }
        }

        private void textNombre_Leave(object sender, EventArgs e)
        {
            if (textNombre.Text == "")
            {
                textNombre.Text = "Nombre";
            }
        }

        private void textCantidad_Leave(object sender, EventArgs e)
        {
            if (textCantidad.Text == "")
            {
                textCantidad.Text = "Cantidad";
            }
        }

        private void textGramaje_Leave(object sender, EventArgs e)
        {
            if (textGramaje.Text == "")
            {
                textGramaje.Text = "Gramaje";
            }
        }

        private void textCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
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