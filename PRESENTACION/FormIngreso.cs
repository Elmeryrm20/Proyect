﻿using DATOS;
using System;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormIngreso : Form
    {


        #region Constructores
        public FormIngreso()
        {
            InitializeComponent();
        }
        public FormIngreso(int Med_Codigo, string MedNombre, string DNI, string Almacen, string Tipo, byte CodigoFilial)
        {
            InitializeComponent();
            this.Med_Codigo = Med_Codigo;
            this.MedNombre = MedNombre;
            this.Almacen = Almacen;
            this.Tipo = Tipo;
            this.DNI = DNI;
            this.CodigoFilial = CodigoFilial;
            Ingreso();
            ObtenerLaboratorio();

        }
        #endregion

        #region Inicializar Variables

        readonly Consultas consultas = new Consultas();
        readonly int Med_Codigo;
        readonly string MedNombre;
        readonly string Almacen;
        readonly string Tipo;
        readonly string DNI;
        readonly byte CodigoFilial;
        #endregion

        void ObtenerLaboratorio()
        {
            cmbLab.DisplayMember = "Lab_Descripcion";
            cmbLab.DataSource = consultas.D_Laboratorio();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Ingreso()
        {
            lbl_Nombre.Text = consultas.D_Detalles_Medicamento(Med_Codigo).Rows[0]["COMPOSICIÓN"].ToString();
        }

        private bool ValidarIngreso()
        {
            if (int.Parse(Txt_Cantidad.Text) > 0)
            {
                if (cmbLab.SelectedIndex == -1)
                {
                    errorProvider1.SetError(cmbLab, "Por favor, seleccione un laboratorio.");
                    return false;
                }
                else return true;
            }
            else
            {
                errorProvider1.SetError(Txt_Cantidad, "Por favor, ingrese una cantidad.");
                return false;
            }
        }
        //Botone de Ingresar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //int cantidad = Convert.ToInt32(Txt_Cantidad.Text);
            //try
            //{
            //    consultas.SP_Agregar_Ingreso_Medicamento(Med_Codigo, cantidad, dtp_FechaVencimiento.Value.ToString("yyyy-MM-dd"));
            //    consultas.SP_Agregar_Detalle_Ingreso(Med_Codigo, cantidad, DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH-mm-ss"), DNI, dtp_FechaVencimiento.Value.ToString("yyyy-MM-dd"));
            //    MessageBox.Show("Actualizacion Exitosa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //    FormMedicamentos FrmMed = Owner as FormMedicamentos;
            //    FrmMed.Rellenartabla();
            //    FrmMed.dgb_Medicamentos.CurrentCell = FrmMed.dgb_Medicamentos.Rows[Med_Codigo - 1].Cells[1];
            //    Close();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}


            if (Txt_Cantidad.Text != "")
            {
                if (ValidarIngreso())
                {
                    FormMedicamentos FrmMedicamentos = Owner as FormMedicamentos;
                    FrmMedicamentos.EnviarIngreso(Med_Codigo, MedNombre, int.Parse(Txt_Cantidad.Text), Almacen, Tipo, dtp_FechaVencimiento.Value.ToString("yyyy-MM-dd"), cmbLab.SelectedIndex + 1, cmbLab.Text);
                    Close();
                }
            }
            //else
            //{
            //    MessageBox.Show("Ingrese una cantidad.", "Información", MessageBoxButtons.OK);
            //}
        }


        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {
            dtp_FechaVencimiento.MinDate = DateTime.Now;
            dtp_FechaVencimiento.Value = DateTime.Now;

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.BotonFormConfirmar06;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.BotonFormConfirmar05;

        }

        private void btnSerrar_MouseEnter(object sender, EventArgs e)
        {
            btnSerrar.Image = Properties.Resources.BotonFormCancelar04;

        }

        private void btnSerrar_MouseLeave(object sender, EventArgs e)
        {
            btnSerrar.Image = Properties.Resources.BotonFormCancelar03;

        }
    }
}
