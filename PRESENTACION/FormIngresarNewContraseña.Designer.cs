﻿namespace PRESENTACION
{
    partial class FormIngresarNewContraseña
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
            this.PibVolver = new System.Windows.Forms.PictureBox();
            this.PibMinimizar = new System.Windows.Forms.PictureBox();
            this.PibCerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtPass2 = new System.Windows.Forms.TextBox();
            this.PibIngresar = new System.Windows.Forms.PictureBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.TxtPass1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.PibVolver);
            this.panel1.Controls.Add(this.PibMinimizar);
            this.panel1.Controls.Add(this.PibCerrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 37);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // PibVolver
            // 
            this.PibVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PibVolver.BackColor = System.Drawing.Color.Transparent;
            this.PibVolver.Image = global::PRESENTACION.Properties.Resources.BotonVentanaAtras01;
            this.PibVolver.Location = new System.Drawing.Point(10, 4);
            this.PibVolver.Name = "PibVolver";
            this.PibVolver.Size = new System.Drawing.Size(24, 24);
            this.PibVolver.TabIndex = 14;
            this.PibVolver.TabStop = false;
            this.PibVolver.Click += new System.EventHandler(this.btn_Volver_Click);
            this.PibVolver.MouseEnter += new System.EventHandler(this.PibVolver_MouseEnter);
            this.PibVolver.MouseLeave += new System.EventHandler(this.PibVolver_MouseLeave);
            // 
            // PibMinimizar
            // 
            this.PibMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PibMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.PibMinimizar.Image = global::PRESENTACION.Properties.Resources.BotonVentanaMinimizar01;
            this.PibMinimizar.Location = new System.Drawing.Point(595, 4);
            this.PibMinimizar.Name = "PibMinimizar";
            this.PibMinimizar.Size = new System.Drawing.Size(24, 24);
            this.PibMinimizar.TabIndex = 13;
            this.PibMinimizar.TabStop = false;
            this.PibMinimizar.Click += new System.EventHandler(this.pictureBox4_Click);
            this.PibMinimizar.MouseEnter += new System.EventHandler(this.PibMinimizar_MouseEnter);
            this.PibMinimizar.MouseLeave += new System.EventHandler(this.PibMinimizar_MouseLeave);
            // 
            // PibCerrar
            // 
            this.PibCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PibCerrar.BackColor = System.Drawing.Color.Transparent;
            this.PibCerrar.Image = global::PRESENTACION.Properties.Resources.BotonVentanaCerrar01;
            this.PibCerrar.Location = new System.Drawing.Point(625, 4);
            this.PibCerrar.Name = "PibCerrar";
            this.PibCerrar.Size = new System.Drawing.Size(24, 24);
            this.PibCerrar.TabIndex = 12;
            this.PibCerrar.TabStop = false;
            this.PibCerrar.Click += new System.EventHandler(this.pictureBox3_Click);
            this.PibCerrar.MouseEnter += new System.EventHandler(this.PibCerrar_MouseEnter);
            this.PibCerrar.MouseLeave += new System.EventHandler(this.PibCerrar_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.TxtPass2);
            this.panel2.Controls.Add(this.PibIngresar);
            this.panel2.Controls.Add(this.txtusuario);
            this.panel2.Controls.Add(this.TxtPass1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 360);
            this.panel2.TabIndex = 15;
            // 
            // TxtPass2
            // 
            this.TxtPass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(123)))));
            this.TxtPass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass2.ForeColor = System.Drawing.Color.White;
            this.TxtPass2.Location = new System.Drawing.Point(410, 229);
            this.TxtPass2.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPass2.MaxLength = 20;
            this.TxtPass2.Name = "TxtPass2";
            this.TxtPass2.PasswordChar = '•';
            this.TxtPass2.Size = new System.Drawing.Size(183, 19);
            this.TxtPass2.TabIndex = 17;
            this.TxtPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPass2.TextChanged += new System.EventHandler(this.txtContraseña2_TextChanged);
            this.TxtPass2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // PibIngresar
            // 
            this.PibIngresar.BackColor = System.Drawing.Color.Transparent;
            this.PibIngresar.Image = global::PRESENTACION.Properties.Resources.BotonReestablecer01;
            this.PibIngresar.Location = new System.Drawing.Point(414, 276);
            this.PibIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.PibIngresar.Name = "PibIngresar";
            this.PibIngresar.Size = new System.Drawing.Size(180, 50);
            this.PibIngresar.TabIndex = 0;
            this.PibIngresar.TabStop = false;
            this.PibIngresar.Click += new System.EventHandler(this.pictureBox2_Click);
            this.PibIngresar.MouseEnter += new System.EventHandler(this.PibIngresar_MouseEnter);
            this.PibIngresar.MouseLeave += new System.EventHandler(this.PibIngresar_MouseLeave);
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(123)))));
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.White;
            this.txtusuario.Location = new System.Drawing.Point(410, 81);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtusuario.MaxLength = 20;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(183, 19);
            this.txtusuario.TabIndex = 4;
            this.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // TxtPass1
            // 
            this.TxtPass1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(123)))));
            this.TxtPass1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass1.ForeColor = System.Drawing.Color.White;
            this.TxtPass1.Location = new System.Drawing.Point(410, 156);
            this.TxtPass1.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPass1.MaxLength = 20;
            this.TxtPass1.Name = "TxtPass1";
            this.TxtPass1.PasswordChar = '•';
            this.TxtPass1.Size = new System.Drawing.Size(183, 19);
            this.TxtPass1.TabIndex = 11;
            this.TxtPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPass1.TextChanged += new System.EventHandler(this.txtcontraseña_TextChanged);
            this.TxtPass1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 321);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormIngresarNewContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRESENTACION.Properties.Resources.FondoReestablecer02;
            this.ClientSize = new System.Drawing.Size(660, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIngresarNewContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIngresarNewContraseña";
            this.Load += new System.EventHandler(this.FormIngresarNewContraseña_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PibVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PibMinimizar;
        private System.Windows.Forms.PictureBox PibCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PibIngresar;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox TxtPass1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtPass2;
        private System.Windows.Forms.PictureBox PibVolver;
    }
}