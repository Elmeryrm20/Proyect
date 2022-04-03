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
            this.cmbLab = new System.Windows.Forms.ComboBox();
            this.CmbPresentacion = new System.Windows.Forms.ComboBox();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.cmbCaja = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Btn_Editar = new System.Windows.Forms.PictureBox();
            this.ptb_Imagen = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CmbPertenencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(53)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnSerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 42);
            this.panel1.TabIndex = 1;
            // 
            // btnSerrar
            // 
            this.btnSerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnSerrar.Image = global::PRESENTACION.Properties.Resources.BotonVentanaCerrar01;
            this.btnSerrar.Location = new System.Drawing.Point(463, 9);
            this.btnSerrar.Name = "btnSerrar";
            this.btnSerrar.Size = new System.Drawing.Size(24, 24);
            this.btnSerrar.TabIndex = 2;
            this.btnSerrar.TabStop = false;
            this.btnSerrar.Click += new System.EventHandler(this.btnSerrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CmbPertenencia);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbLab);
            this.panel2.Controls.Add(this.CmbPresentacion);
            this.panel2.Controls.Add(this.txt_fecha);
            this.panel2.Controls.Add(this.cmbCaja);
            this.panel2.Controls.Add(this.cmbTipo);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.Btn_Editar);
            this.panel2.Controls.Add(this.ptb_Imagen);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 311);
            this.panel2.TabIndex = 2;
            // 
            // cmbLab
            // 
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Location = new System.Drawing.Point(135, 178);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.Size = new System.Drawing.Size(195, 21);
            this.cmbLab.TabIndex = 51;
            this.cmbLab.Text = "Selecciona Laboratorio";
            // 
            // CmbPresentacion
            // 
            this.CmbPresentacion.FormattingEnabled = true;
            this.CmbPresentacion.Location = new System.Drawing.Point(135, 118);
            this.CmbPresentacion.Name = "CmbPresentacion";
            this.CmbPresentacion.Size = new System.Drawing.Size(195, 21);
            this.CmbPresentacion.TabIndex = 55;
            this.CmbPresentacion.Text = "Selecciona Presentación";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha.Location = new System.Drawing.Point(135, 59);
            this.txt_fecha.MinDate = new System.DateTime(2022, 3, 9, 0, 0, 0, 0);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(195, 20);
            this.txt_fecha.TabIndex = 52;
            this.txt_fecha.Value = new System.DateTime(2022, 3, 9, 0, 0, 0, 0);
            // 
            // cmbCaja
            // 
            this.cmbCaja.FormattingEnabled = true;
            this.cmbCaja.Location = new System.Drawing.Point(135, 148);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Size = new System.Drawing.Size(195, 21);
            this.cmbCaja.TabIndex = 56;
            this.cmbCaja.Text = "Selecciona Almacen";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(135, 88);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(195, 21);
            this.cmbTipo.TabIndex = 54;
            this.cmbTipo.Text = "Selecciona Tipo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 20);
            this.txtNombre.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(415, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "Editar imagen";
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Editar.Image = global::PRESENTACION.Properties.Resources.BotonFormConfirmar01;
            this.Btn_Editar.Location = new System.Drawing.Point(181, 259);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(110, 40);
            this.Btn_Editar.TabIndex = 66;
            this.Btn_Editar.TabStop = false;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // ptb_Imagen
            // 
            this.ptb_Imagen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ptb_Imagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_Imagen.Location = new System.Drawing.Point(336, 30);
            this.ptb_Imagen.Name = "ptb_Imagen";
            this.ptb_Imagen.Size = new System.Drawing.Size(150, 150);
            this.ptb_Imagen.TabIndex = 65;
            this.ptb_Imagen.TabStop = false;
            this.ptb_Imagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "Almacen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Para";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Fec.Vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Laboratorio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Nombre";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CmbPertenencia
            // 
            this.CmbPertenencia.FormattingEnabled = true;
            this.CmbPertenencia.Location = new System.Drawing.Point(135, 205);
            this.CmbPertenencia.Name = "CmbPertenencia";
            this.CmbPertenencia.Size = new System.Drawing.Size(195, 21);
            this.CmbPertenencia.TabIndex = 68;
            this.CmbPertenencia.Text = "Selecciona Pertenencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Pertenencia";
            // 
            // FormEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 353);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditarProducto";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox Btn_Editar;
        private System.Windows.Forms.PictureBox ptb_Imagen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox CmbPertenencia;
        private System.Windows.Forms.Label label1;
    }
}