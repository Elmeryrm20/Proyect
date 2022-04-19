﻿using DATOS;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormMedicamentos : Form
    {
        #region Constructores
        public FormMedicamentos()
        {
            InitializeComponent();

        }
        public FormMedicamentos(string DNI)
        {
            InitializeComponent();
            this.DNI = DNI;

        }
        #endregion

        Consultas consultas = new Consultas();
        readonly string DNI;

        #region Métodos al cargar el formulario
        public void MaximizarDataGridView()
        {
            dgb_Medicamentos.Columns[7].Visible = true;
            Maximizar = true;
        }
        public void MinimizarDataGridView()
        {
            dgb_Medicamentos.Columns[7].Visible = false;
            Maximizar = false;
        }
        bool Maximizar = false;
        private void DesignDataGridView()
        {
            dgb_Medicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgb_Medicamentos.Columns[0].Visible = false;
            dgb_Medicamentos.Columns[6].Visible = false;
            //dgb_Medicamentos.Columns[0].Width = 25;
            //dgb_Medicamentos.Columns[0].MinimumWidth = 25;
            //dgb_Medicamentos.Columns[1].Width = 250;
            dgb_Medicamentos.ColumnHeadersHeight = 35;
            dgb_Medicamentos.Columns[1].MinimumWidth = 250;
            dgb_Medicamentos.Columns[2].MinimumWidth = 75;
            dgb_Medicamentos.Columns[3].MinimumWidth = 90;
            dgb_Medicamentos.RowHeadersWidth = 35;
            dgb_Medicamentos.Columns[5].HeaderText = "Presentación";
            dgb_Medicamentos.Columns[7].HeaderText = "Tipo";

            if (this.Maximizar) MaximizarDataGridView();
            else MinimizarDataGridView();

        }

        public void Rellenartabla()
        {
            dgb_Medicamentos.DataSource = consultas.ConsultaMed();
            DesignDataGridView();
        }

        void Elementos_Filtrar()
        {
            cmbTipo.DisplayMember = "tip_descripcion";
            cmbTipo.ValueMember = "tip_descripcion";
            cmbTipo.DataSource = consultas.tipo();
        }
        void Almacen_Filtrar()
        {
            cmb_Almacen.DisplayMember = "Alm_Descripcion";
            cmb_Almacen.ValueMember = "Alm_Descripcion";
            cmb_Almacen.DataSource = consultas.P_AlmMedicamento();
        }
        void Actualizar()
        {
            ChbColores.Checked = false;
            Rellenartabla();
            txb_Buscar.Text = "Buscar Medicamento";
            cmbTipo.SelectedIndex = -1;
            cmb_Almacen.SelectedIndex = -1;
            cmbTipo.Text = "Seleccionar";
            cmb_Almacen.Text = "Seleccionar";
            LblIndice.Visible = false;
            txb_Buscar.SelectAll();
            txb_Buscar.Focus();
            LblResultados.Visible = false;
        }
        #endregion

        #region Sin Usar
        private void FormMedicamentos_Load(object sender, EventArgs e)
        {
            Rellenartabla();
            Elementos_Filtrar();
            Almacen_Filtrar();
            cmbTipo.SelectedIndex = -1;
            cmb_Almacen.SelectedIndex = -1;
            cmbTipo.Text = "Seleccionar";
            cmb_Almacen.Text = "Seleccionar";
        }

        #endregion

        #region Búsqueda,Filtro y obtener ID
        //Búsqueda Dinámica
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            ChbColores.Checked = false;
            PibActualizar.Image = Properties.Resources.BotonFormActualizar04;
            cmbTipo.Text = "Seleccionar";
            cmb_Almacen.Text = "Seleccionar";
            DataTable dt = consultas.D_Consulta_Dinamica(txb_Buscar.Text);
            dgb_Medicamentos.DataSource = dt;
        }

        //Botón Actualizar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        //int valor_ID = 1;

        private void dgb_Medicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void FiltradoExitoso()
        {
            DesignDataGridView();
            LblResultados.Visible = true;
            LblResultados.Text = "Se encontró" + "\n" + dgb_Medicamentos.RowCount.ToString() + " resultados";
            txb_Buscar.Text = "Buscar Medicamento";
            PibActualizar.Image = Properties.Resources.BotonFormActualizar04;
        }
        //Botón Filtrar
        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            ChbColores.Checked = false;

            try
            {
                //string Tipo = cmbTipo.SelectedValue.ToString();
                //string Almacen = cmb_Almacen.SelectedValue.ToString();

                if (cmbTipo.SelectedIndex >= 0) //Sí selección Tipo
                {
                    if (cmb_Almacen.SelectedIndex >= 0) //Si selección Almacén
                    {
                        dgb_Medicamentos.DataSource = consultas.SP_Medicamento_Filtrado_Ambos(cmb_Almacen.SelectedValue.ToString(), cmbTipo.SelectedValue.ToString());
                        FiltradoExitoso();
                    }
                    else //No selección Almacén
                    {
                        dgb_Medicamentos.DataSource = consultas.SP_Consulta_Medicamento_Filtrado(cmbTipo.SelectedValue.ToString());
                        FiltradoExitoso();
                    }
                }
                else //No selección Tipo
                {
                    if (cmb_Almacen.SelectedIndex >= 0)  //Si selección Almacén
                    {
                        dgb_Medicamentos.DataSource = consultas.SP_Medicamento_Filtrado_Almacen(cmb_Almacen.SelectedValue.ToString());
                        FiltradoExitoso();
                    }
                    else
                    {
                        LblResultados.Visible = true;
                        LblResultados.Text = "No ha seleccionado\n Tipo o Almacén.";
                    }
                }

                //if (cmbTipo.SelectedIndex != -1 && cmb_Almacen.SelectedIndex != -1)
                //{
                //    //label4.Text = Tipo + " " + Almacen;
                //    dgb_Medicamentos.DataSource = consultas.SP_Medicamento_Filtrado_Ambos(Almacen, Tipo);
                //    DesignDataGridView();

                //}
                //else if (cmbTipo.SelectedIndex != -1 && cmb_Almacen.SelectedIndex == -1)
                //{
                //    //label4.Text = Tipo;
                //    dgb_Medicamentos.DataSource = consultas.SP_Consulta_Medicamento_Filtrado(Tipo);
                //    DesignDataGridView();

                //}
                //else if (cmbTipo.SelectedIndex == -1 && cmb_Almacen.SelectedIndex != -1)
                //{
                //    //label4.Text = Almacen;
                //    dgb_Medicamentos.DataSource = consultas.SP_Medicamento_Filtrado_Almacen(Almacen);
                //    DesignDataGridView();
                //}
                //else
                //{
                //    label4.Text = "NADA";
                //}

            }
            catch (Exception)
            {

                label4.Text = "Error";
            }
        }
        #endregion

        #region Abrir Formularios
        //Abrir Formulario de Detalles
        private void btn_Detalles_Click(object sender, EventArgs e)
        {
            if (dgb_Medicamentos.Rows.Count > 0)
            {
                FormDetallesMedicamento frm1 = new FormDetallesMedicamento((int)dgb_Medicamentos.Rows[fila].Cells[0].Value);
                frm1.ShowDialog();
            }

        }

        //Abrir Formulario de Ingreso
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (dgb_Medicamentos.Rows.Count > 0)
            {
                string MedNombre, Almacen, Tipo;
                MedNombre = dgb_Medicamentos.CurrentRow.Cells[1].Value.ToString();
                Almacen = dgb_Medicamentos.CurrentRow.Cells[4].Value.ToString();
                Tipo = dgb_Medicamentos.CurrentRow.Cells[5].Value.ToString();
                FormIngreso frm2 = new FormIngreso((int)dgb_Medicamentos.Rows[fila].Cells[0].Value, MedNombre, DNI, Almacen, Tipo);
                AddOwnedForm(frm2);
                frm2.ShowDialog();
            }

        }

        //Abrir Formulario de Egreso
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (dgb_Medicamentos.Rows.Count > 0)
            {
                string MedNombre, Almacen, Tipo;
                MedNombre = dgb_Medicamentos.CurrentRow.Cells[1].Value.ToString();
                Almacen = dgb_Medicamentos.CurrentRow.Cells[4].Value.ToString();
                Tipo = dgb_Medicamentos.CurrentRow.Cells[5].Value.ToString();
                FormEgreso frm3 = new FormEgreso((int)dgb_Medicamentos.Rows[fila].Cells[0].Value, MedNombre, DNI, Almacen, Tipo);
                AddOwnedForm(frm3);
                frm3.ShowDialog();
            }
        }

        //Abrir Formulario de Editar
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (dgb_Medicamentos.Rows.Count > 0)
            {
                //FormEditarProducto frm4 = new FormEditarProducto((int)dgb_Medicamentos.Rows[fila].Cells[0].Value);
                FormEditarProducto frm4 = new FormEditarProducto((int)dgb_Medicamentos.CurrentRow.Cells[0].Value);
                AddOwnedForm(frm4);
                frm4.ShowDialog();
            }


        }
        #endregion

        #region Métodos Heredados
        public void EnviarEgreso(int codigo, string MedNombre, int cantidad, string Almacen, string Tipo)
        {
            FormPrincipal Principal = (FormPrincipal)Owner;
            Principal.EscogerFormulario<FormSalidaMedicamentos>(4);
            Principal.EnviarEgreso(codigo, MedNombre, cantidad, Almacen, Tipo);
        }
        public void EnviarIngreso(int codigo, string MedNombre, int cantidad, string Almacen, string Tipo, string FechaVencimiento)
        {
            FormPrincipal Principal = (FormPrincipal)Owner;
            Principal.EscogerFormulario<FormEntradaMedicamento>(10);
            Principal.EnviarIngreso(codigo, MedNombre, cantidad, Almacen, Tipo, FechaVencimiento);
        }
        #endregion

        int fila = 0;
        //Obtener Id del Medicamento
        private void dgb_Medicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                fila = e.RowIndex;

            }
            //valor_ID = (int)dgb_Medicamentos.CurrentRow.Cells[0].Value;
            //LblIndice.Text = dgb_Medicamentos.Rows[fila].Cells[0].Value.ToString();
        }

        private void PibDetalles_MouseEnter(object sender, EventArgs e)
        {
            PibDetalles.Image = Properties.Resources.BotonFormDetalles02;
        }

        private void PibIngreso_MouseEnter(object sender, EventArgs e)
        {
            PibIngreso.Image = Properties.Resources.BotonFormIngreso02;

        }

        private void PibDetalles_MouseLeave(object sender, EventArgs e)
        {
            PibDetalles.Image = Properties.Resources.BotonFormDetalles01;

        }

        private void PibIngreso_MouseLeave(object sender, EventArgs e)
        {
            PibIngreso.Image = Properties.Resources.BotonFormIngreso01;

        }

        private void PibSalida_MouseEnter(object sender, EventArgs e)
        {
            PibSalida.Image = Properties.Resources.BotonFormSalida02;

        }

        private void PibSalida_MouseLeave(object sender, EventArgs e)
        {
            PibSalida.Image = Properties.Resources.BotonFormSalida01;

        }

        private void PibEditar_MouseEnter(object sender, EventArgs e)
        {
            PibEditar.Image = Properties.Resources.BotonFormEditar02;

        }

        private void PibEditar_MouseLeave(object sender, EventArgs e)
        {
            PibEditar.Image = Properties.Resources.BotonFormEditar01;

        }

        private void PibActualizar_MouseEnter(object sender, EventArgs e)
        {
            PibActualizar.Image = Properties.Resources.BotonFormActualizar02;

        }

        private void PibActualizar_MouseLeave(object sender, EventArgs e)
        {
            PibActualizar.Image = Properties.Resources.BotonFormActualizar01;

        }

        private void Pib_Filtrar_MouseEnter(object sender, EventArgs e)
        {
            Pib_Filtrar.Image = Properties.Resources.BotonFormFiltrar02;

        }

        private void Pib_Filtrar_MouseLeave(object sender, EventArgs e)
        {
            Pib_Filtrar.Image = Properties.Resources.BotonFormFiltrar01;

        }

        private void cmb_Almacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgb_Medicamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //valor_ID = (int)dgb_Medicamentos.CurrentRow.Cells[0].Value;
            //LblIndice.Text = valor_ID.ToString();
            FormDetallesMedicamento frm1 = new FormDetallesMedicamento((int)dgb_Medicamentos.Rows[fila].Cells[0].Value);
            frm1.ShowDialog();

        }

        private void cmbTipo_MouseDown(object sender, MouseEventArgs e)
        {
            Elementos_Filtrar();

        }

        private void cmb_Almacen_MouseDown(object sender, MouseEventArgs e)
        {
            Almacen_Filtrar();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblResultados.Visible = false;
        }

        private void cmb_Almacen_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipo_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipo_Enter(object sender, EventArgs e)
        {
            //cmbTipo.DroppedDown = true;

        }

        private void cmb_Almacen_Enter(object sender, EventArgs e)
        {
            //cmb_Almacen.DroppedDown = true;

        }

        private void txb_Buscar_Click(object sender, EventArgs e)
        {
            if (txb_Buscar.Text == "Buscar Medicamento")
            {
                txb_Buscar.Text = "";
            }
        }

        private bool Colores = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbColores.Checked == true)
            {
                FomarteandoDataGridView(true);
            }
            else
            {
                FomarteandoDataGridView(false);
            }
        }


        void FomarteandoDataGridView(bool formato)
        {

            if (formato)
            {
                for (int i = 0; i < dgb_Medicamentos.Rows.Count; i++)
                {
                    dgb_Medicamentos.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    if (Convert.ToInt32(dgb_Medicamentos.Rows[i].Cells[2].Value) == 0)
                    {
                        dgb_Medicamentos.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    }
                    else if (Convert.ToInt32(dgb_Medicamentos.Rows[i].Cells[2].Value) > 0 && Convert.ToInt32(dgb_Medicamentos.Rows[i].Cells[2].Value) <= 10)
                    {
                        dgb_Medicamentos.Rows[i].Cells[2].Style.BackColor = Color.Orange;
                    }
                    else
                    {
                        dgb_Medicamentos.Rows[i].Cells[2].Style.BackColor = Color.FromArgb(41, 177, 101);
                    }
                }
            }
            else
            {


                for (int i = 0; i < dgb_Medicamentos.Rows.Count; i++)
                {
                    dgb_Medicamentos.Rows[i].Cells[2].Style.BackColor = Color.White;
                    dgb_Medicamentos.Rows[i].Cells[2].Style.ForeColor = Color.FromArgb(53, 141, 216);
                }

                //    dgb_Medicamentos.Columns[2].DefaultCellStyle.BackColor = Color.White;
                //dgb_Medicamentos.Columns[2].DefaultCellStyle.ForeColor = Color.FromArgb(53, 141, 216);
            }
        }
        private void dgb_Medicamentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //    if (Formato)
            //    {

            //        if (this.dgb_Medicamentos.Columns[e.ColumnIndex].Name == "EXISTENCIA")
            //        {
            //            if (Convert.ToInt32(e.Value) == 0)
            //            {
            //                e.CellStyle.BackColor = Color.Red;
            //                e.CellStyle.ForeColor = Color.White;
            //            }
            //            else if (Convert.ToInt32(e.Value) > 0 && Convert.ToInt32(e.Value) <= 10)
            //            {
            //                e.CellStyle.BackColor = Color.Orange;
            //                e.CellStyle.ForeColor = Color.White;
            //            }
            //            else
            //            {
            //                e.CellStyle.BackColor = Color.FromArgb(41, 177, 101);
            //                e.CellStyle.ForeColor = Color.White;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        e.CellStyle.BackColor = Color.White;
            //        e.CellStyle.ForeColor = Color.FromArgb(53,141,216);
            //    }
        }

        private void dgb_Medicamentos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (ChbColores.Checked) FomarteandoDataGridView(true);
                else FomarteandoDataGridView(false);

            }
        }
    }
}
