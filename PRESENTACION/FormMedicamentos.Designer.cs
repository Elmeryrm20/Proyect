﻿
namespace PRESENTACION
{
    partial class FormMedicamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txb_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblResultados = new System.Windows.Forms.Label();
            this.cmb_Almacen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pib_Filtrar = new System.Windows.Forms.PictureBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblIndice = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PibEditar = new System.Windows.Forms.PictureBox();
            this.PibSalida = new System.Windows.Forms.PictureBox();
            this.PibIngreso = new System.Windows.Forms.PictureBox();
            this.PibActualizar = new System.Windows.Forms.PictureBox();
            this.PibDetalles = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgb_Medicamentos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pib_Filtrar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibDetalles)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Medicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_Buscar
            // 
            this.txb_Buscar.Location = new System.Drawing.Point(20, 75);
            this.txb_Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_Buscar.Name = "txb_Buscar";
            this.txb_Buscar.Size = new System.Drawing.Size(393, 22);
            this.txb_Buscar.TabIndex = 1;
            this.txb_Buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "INVENTARIO  DE MEDICAMENTOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblResultados);
            this.panel1.Controls.Add(this.cmb_Almacen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Pib_Filtrar);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txb_Buscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 140);
            this.panel1.TabIndex = 7;
            // 
            // LblResultados
            // 
            this.LblResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblResultados.AutoSize = true;
            this.LblResultados.ForeColor = System.Drawing.Color.Red;
            this.LblResultados.Location = new System.Drawing.Point(596, 108);
            this.LblResultados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblResultados.Name = "LblResultados";
            this.LblResultados.Size = new System.Drawing.Size(119, 17);
            this.LblResultados.TabIndex = 13;
            this.LblResultados.Text = "N° de Resultados";
            // 
            // cmb_Almacen
            // 
            this.cmb_Almacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Almacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_Almacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Almacen.FormattingEnabled = true;
            this.cmb_Almacen.Location = new System.Drawing.Point(600, 65);
            this.cmb_Almacen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Almacen.Name = "cmb_Almacen";
            this.cmb_Almacen.Size = new System.Drawing.Size(172, 24);
            this.cmb_Almacen.TabIndex = 12;
            this.cmb_Almacen.Text = "Caja";
            this.cmb_Almacen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Almacen_KeyPress);
            this.cmb_Almacen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmb_Almacen_MouseDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Caja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // Pib_Filtrar
            // 
            this.Pib_Filtrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pib_Filtrar.BackColor = System.Drawing.Color.Transparent;
            this.Pib_Filtrar.Image = global::PRESENTACION.Properties.Resources.BotonFormFiltrar01;
            this.Pib_Filtrar.Location = new System.Drawing.Point(781, 36);
            this.Pib_Filtrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pib_Filtrar.Name = "Pib_Filtrar";
            this.Pib_Filtrar.Size = new System.Drawing.Size(147, 49);
            this.Pib_Filtrar.TabIndex = 9;
            this.Pib_Filtrar.TabStop = false;
            this.Pib_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            this.Pib_Filtrar.MouseEnter += new System.EventHandler(this.Pib_Filtrar_MouseEnter);
            this.Pib_Filtrar.MouseLeave += new System.EventHandler(this.Pib_Filtrar_MouseLeave);
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(600, 32);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(172, 24);
            this.cmbTipo.TabIndex = 8;
            this.cmbTipo.Text = "Composición";
            this.cmbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Almacen_KeyPress);
            this.cmbTipo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmbTipo_MouseDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Composicion";
            // 
            // LblIndice
            // 
            this.LblIndice.AutoSize = true;
            this.LblIndice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIndice.Location = new System.Drawing.Point(857, 27);
            this.LblIndice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIndice.Name = "LblIndice";
            this.LblIndice.Size = new System.Drawing.Size(66, 24);
            this.LblIndice.TabIndex = 6;
            this.LblIndice.Text = "Indice";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PibEditar);
            this.panel3.Controls.Add(this.PibSalida);
            this.panel3.Controls.Add(this.PibIngreso);
            this.panel3.Controls.Add(this.LblIndice);
            this.panel3.Controls.Add(this.PibActualizar);
            this.panel3.Controls.Add(this.PibDetalles);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 438);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 78);
            this.panel3.TabIndex = 9;
            // 
            // PibEditar
            // 
            this.PibEditar.BackColor = System.Drawing.Color.Transparent;
            this.PibEditar.Image = global::PRESENTACION.Properties.Resources.BotonFormEditar01;
            this.PibEditar.Location = new System.Drawing.Point(521, 14);
            this.PibEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PibEditar.Name = "PibEditar";
            this.PibEditar.Size = new System.Drawing.Size(147, 49);
            this.PibEditar.TabIndex = 7;
            this.PibEditar.TabStop = false;
            this.PibEditar.Click += new System.EventHandler(this.pictureBox2_Click);
            this.PibEditar.MouseEnter += new System.EventHandler(this.PibEditar_MouseEnter);
            this.PibEditar.MouseLeave += new System.EventHandler(this.PibEditar_MouseLeave);
            // 
            // PibSalida
            // 
            this.PibSalida.BackColor = System.Drawing.Color.Transparent;
            this.PibSalida.Image = global::PRESENTACION.Properties.Resources.BotonFormSalida01;
            this.PibSalida.Location = new System.Drawing.Point(367, 14);
            this.PibSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PibSalida.Name = "PibSalida";
            this.PibSalida.Size = new System.Drawing.Size(147, 49);
            this.PibSalida.TabIndex = 5;
            this.PibSalida.TabStop = false;
            this.PibSalida.Click += new System.EventHandler(this.pictureBox4_Click);
            this.PibSalida.MouseEnter += new System.EventHandler(this.PibSalida_MouseEnter);
            this.PibSalida.MouseLeave += new System.EventHandler(this.PibSalida_MouseLeave);
            // 
            // PibIngreso
            // 
            this.PibIngreso.BackColor = System.Drawing.Color.Transparent;
            this.PibIngreso.Image = global::PRESENTACION.Properties.Resources.BotonFormIngreso01;
            this.PibIngreso.Location = new System.Drawing.Point(212, 14);
            this.PibIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PibIngreso.Name = "PibIngreso";
            this.PibIngreso.Size = new System.Drawing.Size(147, 49);
            this.PibIngreso.TabIndex = 4;
            this.PibIngreso.TabStop = false;
            this.PibIngreso.Click += new System.EventHandler(this.pictureBox3_Click);
            this.PibIngreso.MouseEnter += new System.EventHandler(this.PibIngreso_MouseEnter);
            this.PibIngreso.MouseLeave += new System.EventHandler(this.PibIngreso_MouseLeave);
            // 
            // PibActualizar
            // 
            this.PibActualizar.BackColor = System.Drawing.Color.Transparent;
            this.PibActualizar.Image = global::PRESENTACION.Properties.Resources.BotonFormActualizar01;
            this.PibActualizar.Location = new System.Drawing.Point(676, 14);
            this.PibActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PibActualizar.Name = "PibActualizar";
            this.PibActualizar.Size = new System.Drawing.Size(147, 49);
            this.PibActualizar.TabIndex = 2;
            this.PibActualizar.TabStop = false;
            this.PibActualizar.Click += new System.EventHandler(this.pictureBox1_Click);
            this.PibActualizar.MouseEnter += new System.EventHandler(this.PibActualizar_MouseEnter);
            this.PibActualizar.MouseLeave += new System.EventHandler(this.PibActualizar_MouseLeave);
            // 
            // PibDetalles
            // 
            this.PibDetalles.BackColor = System.Drawing.Color.Transparent;
            this.PibDetalles.Image = global::PRESENTACION.Properties.Resources.BotonFormDetalles01;
            this.PibDetalles.Location = new System.Drawing.Point(57, 14);
            this.PibDetalles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PibDetalles.Name = "PibDetalles";
            this.PibDetalles.Size = new System.Drawing.Size(147, 49);
            this.PibDetalles.TabIndex = 3;
            this.PibDetalles.TabStop = false;
            this.PibDetalles.Click += new System.EventHandler(this.btn_Detalles_Click);
            this.PibDetalles.MouseEnter += new System.EventHandler(this.PibDetalles_MouseEnter);
            this.PibDetalles.MouseLeave += new System.EventHandler(this.PibDetalles_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 298);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(891, 140);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(53, 298);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgb_Medicamentos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(53, 140);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(838, 298);
            this.panel5.TabIndex = 12;
            // 
            // dgb_Medicamentos
            // 
            this.dgb_Medicamentos.AllowUserToAddRows = false;
            this.dgb_Medicamentos.AllowUserToDeleteRows = false;
            this.dgb_Medicamentos.AllowUserToOrderColumns = true;
            this.dgb_Medicamentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgb_Medicamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgb_Medicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgb_Medicamentos.BackgroundColor = System.Drawing.Color.White;
            this.dgb_Medicamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgb_Medicamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgb_Medicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgb_Medicamentos.ColumnHeadersHeight = 25;
            this.dgb_Medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgb_Medicamentos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgb_Medicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgb_Medicamentos.EnableHeadersVisualStyles = false;
            this.dgb_Medicamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.dgb_Medicamentos.Location = new System.Drawing.Point(0, 0);
            this.dgb_Medicamentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgb_Medicamentos.MultiSelect = false;
            this.dgb_Medicamentos.Name = "dgb_Medicamentos";
            this.dgb_Medicamentos.ReadOnly = true;
            this.dgb_Medicamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgb_Medicamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgb_Medicamentos.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dgb_Medicamentos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgb_Medicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgb_Medicamentos.Size = new System.Drawing.Size(838, 298);
            this.dgb_Medicamentos.TabIndex = 2;
            this.dgb_Medicamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_Medicamentos_CellClick);
            this.dgb_Medicamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_Medicamentos_CellDoubleClick);
            // 
            // FormMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 516);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMedicamentos";
            this.Text = "FormMedicamentos";
            this.Load += new System.EventHandler(this.FormMedicamentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pib_Filtrar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibDetalles)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Medicamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txb_Buscar;
        private System.Windows.Forms.PictureBox PibActualizar;
        private System.Windows.Forms.PictureBox PibDetalles;
        private System.Windows.Forms.PictureBox PibIngreso;
        private System.Windows.Forms.PictureBox PibSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblIndice;
        private System.Windows.Forms.PictureBox PibEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Pib_Filtrar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Almacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblResultados;
        public System.Windows.Forms.DataGridView dgb_Medicamentos;
    }
}