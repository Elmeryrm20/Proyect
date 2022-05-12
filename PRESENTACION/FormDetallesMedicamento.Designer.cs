namespace PRESENTACION
{
    partial class FormDetallesMedicamento
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.btnSerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblPertenencia = new System.Windows.Forms.Label();
            this.lbl_Porcentage = new System.Windows.Forms.Label();
            this.lbl_Existencia = new System.Windows.Forms.Label();
            this.lbl_Laboratorio = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.lbl_F_Vencimiento = new System.Windows.Forms.Label();
            this.lbl_Almacen = new System.Windows.Forms.Label();
            this.lbl_Egreso = new System.Windows.Forms.Label();
            this.lbl_Ingeso = new System.Windows.Forms.Label();
            this.ptb_Imagen = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_Nombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 42);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(246)))), ((int)(((byte)(159)))));
            this.lbl_Nombre.Location = new System.Drawing.Point(12, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(454, 42);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "label1";
            this.lbl_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSerrar
            // 
            this.btnSerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnSerrar.Image = global::PRESENTACION.Properties.Resources.BotonFormVolver01;
            this.btnSerrar.Location = new System.Drawing.Point(190, 331);
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
            this.panel2.Controls.Add(this.LblPertenencia);
            this.panel2.Controls.Add(this.lbl_Porcentage);
            this.panel2.Controls.Add(this.lbl_Existencia);
            this.panel2.Controls.Add(this.lbl_Laboratorio);
            this.panel2.Controls.Add(this.lbl_Tipo);
            this.panel2.Controls.Add(this.lbl_F_Vencimiento);
            this.panel2.Controls.Add(this.lbl_Almacen);
            this.panel2.Controls.Add(this.lbl_Egreso);
            this.panel2.Controls.Add(this.lbl_Ingeso);
            this.panel2.Controls.Add(this.ptb_Imagen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 383);
            this.panel2.TabIndex = 1;
            // 
            // LblPertenencia
            // 
            this.LblPertenencia.AutoSize = true;
            this.LblPertenencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPertenencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.LblPertenencia.Location = new System.Drawing.Point(136, 136);
            this.LblPertenencia.Name = "LblPertenencia";
            this.LblPertenencia.Size = new System.Drawing.Size(48, 16);
            this.LblPertenencia.TabIndex = 21;
            this.LblPertenencia.Text = "label7";
            // 
            // lbl_Porcentage
            // 
            this.lbl_Porcentage.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Porcentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.lbl_Porcentage.Location = new System.Drawing.Point(282, 255);
            this.lbl_Porcentage.Name = "lbl_Porcentage";
            this.lbl_Porcentage.Size = new System.Drawing.Size(65, 35);
            this.lbl_Porcentage.TabIndex = 19;
            this.lbl_Porcentage.Text = "555";
            this.lbl_Porcentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Existencia
            // 
            this.lbl_Existencia.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Existencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.lbl_Existencia.Location = new System.Drawing.Point(37, 255);
            this.lbl_Existencia.Name = "lbl_Existencia";
            this.lbl_Existencia.Size = new System.Drawing.Size(60, 35);
            this.lbl_Existencia.TabIndex = 17;
            this.lbl_Existencia.Text = "555";
            this.lbl_Existencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Laboratorio
            // 
            this.lbl_Laboratorio.AutoSize = true;
            this.lbl_Laboratorio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Laboratorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.lbl_Laboratorio.Location = new System.Drawing.Point(136, 111);
            this.lbl_Laboratorio.Name = "lbl_Laboratorio";
            this.lbl_Laboratorio.Size = new System.Drawing.Size(48, 16);
            this.lbl_Laboratorio.TabIndex = 14;
            this.lbl_Laboratorio.Text = "label7";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.lbl_Tipo.Location = new System.Drawing.Point(136, 88);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(48, 16);
            this.lbl_Tipo.TabIndex = 13;
            this.lbl_Tipo.Text = "label6";
            // 
            // lbl_F_Vencimiento
            // 
            this.lbl_F_Vencimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_F_Vencimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.lbl_F_Vencimiento.Location = new System.Drawing.Point(384, 283);
            this.lbl_F_Vencimiento.Name = "lbl_F_Vencimiento";
            this.lbl_F_Vencimiento.Size = new System.Drawing.Size(91, 28);
            this.lbl_F_Vencimiento.TabIndex = 10;
            this.lbl_F_Vencimiento.Text = "label9";
            this.lbl_F_Vencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Almacen
            // 
            this.lbl_Almacen.AutoSize = true;
            this.lbl_Almacen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Almacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.lbl_Almacen.Location = new System.Drawing.Point(163, 32);
            this.lbl_Almacen.Name = "lbl_Almacen";
            this.lbl_Almacen.Size = new System.Drawing.Size(48, 16);
            this.lbl_Almacen.TabIndex = 9;
            this.lbl_Almacen.Text = "label8";
            // 
            // lbl_Egreso
            // 
            this.lbl_Egreso.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Egreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.lbl_Egreso.Location = new System.Drawing.Point(201, 255);
            this.lbl_Egreso.Name = "lbl_Egreso";
            this.lbl_Egreso.Size = new System.Drawing.Size(60, 35);
            this.lbl_Egreso.TabIndex = 8;
            this.lbl_Egreso.Text = "555";
            this.lbl_Egreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Ingeso
            // 
            this.lbl_Ingeso.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ingeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.lbl_Ingeso.Location = new System.Drawing.Point(119, 255);
            this.lbl_Ingeso.Name = "lbl_Ingeso";
            this.lbl_Ingeso.Size = new System.Drawing.Size(60, 35);
            this.lbl_Ingeso.TabIndex = 7;
            this.lbl_Ingeso.Text = "555";
            this.lbl_Ingeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptb_Imagen
            // 
            this.ptb_Imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ptb_Imagen.Location = new System.Drawing.Point(329, 26);
            this.ptb_Imagen.Name = "ptb_Imagen";
            this.ptb_Imagen.Size = new System.Drawing.Size(137, 137);
            this.ptb_Imagen.TabIndex = 3;
            this.ptb_Imagen.TabStop = false;
            this.ptb_Imagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormDetallesMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRESENTACION.Properties.Resources.FondoDetalles02;
            this.ClientSize = new System.Drawing.Size(500, 425);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetallesMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoomDetallesMedicamento";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnSerrar;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Laboratorio;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label lbl_F_Vencimiento;
        private System.Windows.Forms.Label lbl_Almacen;
        private System.Windows.Forms.Label lbl_Egreso;
        private System.Windows.Forms.Label lbl_Ingeso;
        private System.Windows.Forms.PictureBox ptb_Imagen;
        private System.Windows.Forms.Label lbl_Porcentage;
        private System.Windows.Forms.Label lbl_Existencia;
        private System.Windows.Forms.Label LblPertenencia;
    }
}