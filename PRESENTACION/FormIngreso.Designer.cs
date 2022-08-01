namespace PRESENTACION
{
    partial class FormIngreso
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_FechaVencimiento = new PRESENTACION.SelectorDatePicker();
            this.cmbLab = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 27);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSerrar
            // 
            this.btnSerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnSerrar.Image = global::PRESENTACION.Properties.Resources.BotonFormCancelar03;
            this.btnSerrar.Location = new System.Drawing.Point(203, 267);
            this.btnSerrar.Name = "btnSerrar";
            this.btnSerrar.Size = new System.Drawing.Size(110, 40);
            this.btnSerrar.TabIndex = 3;
            this.btnSerrar.TabStop = false;
            this.btnSerrar.Click += new System.EventHandler(this.btnSerrar_Click);
            this.btnSerrar.MouseEnter += new System.EventHandler(this.btnSerrar_MouseEnter);
            this.btnSerrar.MouseLeave += new System.EventHandler(this.btnSerrar_MouseLeave);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.lbl_Nombre.Location = new System.Drawing.Point(145, 30);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(263, 37);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "420 320";
            this.lbl_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Cantidad.Font = new System.Drawing.Font("Century Gothic", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(177)))), ((int)(((byte)(101)))));
            this.Txt_Cantidad.Location = new System.Drawing.Point(228, 154);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(99, 51);
            this.Txt_Cantidad.TabIndex = 4;
            this.Txt_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PRESENTACION.Properties.Resources.BotonFormConfirmar05;
            this.pictureBox1.Location = new System.Drawing.Point(164, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 40);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // dtp_FechaVencimiento
            // 
            this.dtp_FechaVencimiento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.dtp_FechaVencimiento.BorderSize = 0;
            this.dtp_FechaVencimiento.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaVencimiento.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.dtp_FechaVencimiento.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtp_FechaVencimiento.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.dtp_FechaVencimiento.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtp_FechaVencimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaVencimiento.Location = new System.Drawing.Point(214, 225);
            this.dtp_FechaVencimiento.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtp_FechaVencimiento.MinDate = new System.DateTime(2022, 4, 4, 0, 0, 0, 0);
            this.dtp_FechaVencimiento.MinimumSize = new System.Drawing.Size(4, 20);
            this.dtp_FechaVencimiento.Name = "dtp_FechaVencimiento";
            this.dtp_FechaVencimiento.Size = new System.Drawing.Size(127, 27);
            this.dtp_FechaVencimiento.SkinColor = System.Drawing.Color.White;
            this.dtp_FechaVencimiento.TabIndex = 63;
            this.dtp_FechaVencimiento.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.dtp_FechaVencimiento.Value = new System.DateTime(2022, 4, 4, 1, 35, 32, 0);
            // 
            // cmbLab
            // 
            this.cmbLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLab.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.cmbLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Location = new System.Drawing.Point(214, 114);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.Size = new System.Drawing.Size(135, 23);
            this.cmbLab.TabIndex = 64;
            this.cmbLab.Text = "Selecciona Laboratorio";
            // 
            // FormIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRESENTACION.Properties.Resources.FondoEntrada01;
            this.ClientSize = new System.Drawing.Size(420, 320);
            this.Controls.Add(this.cmbLab);
            this.Controls.Add(this.btnSerrar);
            this.Controls.Add(this.Txt_Cantidad);
            this.Controls.Add(this.dtp_FechaVencimiento);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIngreso";
            this.Load += new System.EventHandler(this.FormIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnSerrar;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private SelectorDatePicker dtp_FechaVencimiento;
        private System.Windows.Forms.ComboBox cmbLab;
    }
}