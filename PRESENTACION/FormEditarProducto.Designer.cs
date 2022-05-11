namespace PRESENTACION
{
    partial class FormEditarProducto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CmbPertenencia = new System.Windows.Forms.ComboBox();
            this.cmbLab = new System.Windows.Forms.ComboBox();
            this.CmbPresentacion = new System.Windows.Forms.ComboBox();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.cmbCaja = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Btn_Editar = new System.Windows.Forms.PictureBox();
            this.ptb_Imagen = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.btnSerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 42);
            this.panel1.TabIndex = 1;
            // 
            // btnSerrar
            // 
            this.btnSerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnSerrar.Image = global::PRESENTACION.Properties.Resources.BotonFormCancelar07;
            this.btnSerrar.Location = new System.Drawing.Point(247, 320);
            this.btnSerrar.Name = "btnSerrar";
            this.btnSerrar.Size = new System.Drawing.Size(110, 40);
            this.btnSerrar.TabIndex = 2;
            this.btnSerrar.TabStop = false;
            this.btnSerrar.Click += new System.EventHandler(this.btnSerrar_Click);
            this.btnSerrar.MouseEnter += new System.EventHandler(this.btnSerrar_MouseEnter);
            this.btnSerrar.MouseLeave += new System.EventHandler(this.btnSerrar_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnSerrar);
            this.panel2.Controls.Add(this.CmbPertenencia);
            this.panel2.Controls.Add(this.cmbLab);
            this.panel2.Controls.Add(this.CmbPresentacion);
            this.panel2.Controls.Add(this.txt_fecha);
            this.panel2.Controls.Add(this.cmbCaja);
            this.panel2.Controls.Add(this.cmbTipo);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.Btn_Editar);
            this.panel2.Controls.Add(this.ptb_Imagen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 383);
            this.panel2.TabIndex = 2;
            // 
            // CmbPertenencia
            // 
            this.CmbPertenencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbPertenencia.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.CmbPertenencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.CmbPertenencia.FormattingEnabled = true;
            this.CmbPertenencia.Location = new System.Drawing.Point(120, 256);
            this.CmbPertenencia.Name = "CmbPertenencia";
            this.CmbPertenencia.Size = new System.Drawing.Size(135, 23);
            this.CmbPertenencia.TabIndex = 68;
            this.CmbPertenencia.Text = "Selecciona Pertenencia";
            // 
            // cmbLab
            // 
            this.cmbLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLab.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.cmbLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Location = new System.Drawing.Point(120, 217);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.Size = new System.Drawing.Size(135, 23);
            this.cmbLab.TabIndex = 51;
            this.cmbLab.Text = "Selecciona Laboratorio";
            // 
            // CmbPresentacion
            // 
            this.CmbPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbPresentacion.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.CmbPresentacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.CmbPresentacion.FormattingEnabled = true;
            this.CmbPresentacion.Location = new System.Drawing.Point(-23, 155);
            this.CmbPresentacion.Name = "CmbPresentacion";
            this.CmbPresentacion.Size = new System.Drawing.Size(135, 23);
            this.CmbPresentacion.TabIndex = 55;
            this.CmbPresentacion.Text = "Selecciona Presentación";
            this.CmbPresentacion.Visible = false;
            // 
            // txt_fecha
            // 
            this.txt_fecha.CalendarFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.txt_fecha.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.txt_fecha.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha.Location = new System.Drawing.Point(68, 99);
            this.txt_fecha.MinDate = new System.DateTime(2000, 3, 9, 0, 0, 0, 0);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(156, 21);
            this.txt_fecha.TabIndex = 52;
            this.txt_fecha.Value = new System.DateTime(2022, 3, 9, 0, 0, 0, 0);
            // 
            // cmbCaja
            // 
            this.cmbCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCaja.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.cmbCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.cmbCaja.FormattingEnabled = true;
            this.cmbCaja.Location = new System.Drawing.Point(120, 177);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Size = new System.Drawing.Size(135, 23);
            this.cmbCaja.TabIndex = 56;
            this.cmbCaja.Text = "Selecciona Almacen";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(120, 136);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(135, 23);
            this.cmbTipo.TabIndex = 54;
            this.cmbTipo.Text = "Selecciona Tipo";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(68, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(387, 16);
            this.txtNombre.TabIndex = 49;
            this.txtNombre.Text = "Medicamento";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Editar.Image = global::PRESENTACION.Properties.Resources.BotonFormConfirmar07;
            this.Btn_Editar.Location = new System.Drawing.Point(108, 320);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(110, 40);
            this.Btn_Editar.TabIndex = 66;
            this.Btn_Editar.TabStop = false;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            this.Btn_Editar.MouseEnter += new System.EventHandler(this.Btn_Editar_MouseEnter);
            this.Btn_Editar.MouseLeave += new System.EventHandler(this.Btn_Editar_MouseLeave);
            // 
            // ptb_Imagen
            // 
            this.ptb_Imagen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ptb_Imagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_Imagen.Location = new System.Drawing.Point(319, 126);
            this.ptb_Imagen.Name = "ptb_Imagen";
            this.ptb_Imagen.Size = new System.Drawing.Size(150, 150);
            this.ptb_Imagen.TabIndex = 65;
            this.ptb_Imagen.TabStop = false;
            this.ptb_Imagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRESENTACION.Properties.Resources.FondoEditarMedicamento01;
            this.ClientSize = new System.Drawing.Size(500, 425);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditarProducto";
            this.Load += new System.EventHandler(this.FormEditarProducto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.btnSerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnSerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbLab;
        private System.Windows.Forms.ComboBox CmbPresentacion;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.ComboBox cmbCaja;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox Btn_Editar;
        private System.Windows.Forms.PictureBox ptb_Imagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox CmbPertenencia;
    }
}