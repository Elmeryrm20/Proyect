namespace PRESENTACION
{
    partial class FormHistorial
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
            this.label1 = new System.Windows.Forms.Label();
            this.PnlEncabezado = new System.Windows.Forms.Panel();
            this.BtnSalidas = new System.Windows.Forms.Button();
            this.BtnEntradas = new System.Windows.Forms.Button();
            this.PibSalidas = new System.Windows.Forms.PictureBox();
            this.PibEntradas = new System.Windows.Forms.PictureBox();
            this.pnl_Contenedor_Entradas = new System.Windows.Forms.Panel();
            this.PnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibSalidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "HISTORIAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PnlEncabezado
            // 
            this.PnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.PnlEncabezado.Controls.Add(this.BtnSalidas);
            this.PnlEncabezado.Controls.Add(this.BtnEntradas);
            this.PnlEncabezado.Controls.Add(this.PibSalidas);
            this.PnlEncabezado.Controls.Add(this.PibEntradas);
            this.PnlEncabezado.Controls.Add(this.label1);
            this.PnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.PnlEncabezado.Name = "PnlEncabezado";
            this.PnlEncabezado.Size = new System.Drawing.Size(724, 47);
            this.PnlEncabezado.TabIndex = 1;
            // 
            // BtnSalidas
            // 
            this.BtnSalidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.BtnSalidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalidas.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.BtnSalidas.FlatAppearance.BorderSize = 2;
            this.BtnSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalidas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalidas.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnSalidas.Location = new System.Drawing.Point(260, 7);
            this.BtnSalidas.Name = "BtnSalidas";
            this.BtnSalidas.Size = new System.Drawing.Size(140, 40);
            this.BtnSalidas.TabIndex = 3;
            this.BtnSalidas.Text = "SALIDAS";
            this.BtnSalidas.UseVisualStyleBackColor = false;
            this.BtnSalidas.Click += new System.EventHandler(this.BtnSalidas_Click);
            // 
            // BtnEntradas
            // 
            this.BtnEntradas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEntradas.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.BtnEntradas.FlatAppearance.BorderSize = 0;
            this.BtnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntradas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntradas.ForeColor = System.Drawing.Color.White;
            this.BtnEntradas.Location = new System.Drawing.Point(120, 7);
            this.BtnEntradas.Name = "BtnEntradas";
            this.BtnEntradas.Size = new System.Drawing.Size(140, 40);
            this.BtnEntradas.TabIndex = 3;
            this.BtnEntradas.Text = "ENTRADAS";
            this.BtnEntradas.UseVisualStyleBackColor = false;
            this.BtnEntradas.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PibSalidas
            // 
            this.PibSalidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.PibSalidas.Location = new System.Drawing.Point(579, 9);
            this.PibSalidas.Name = "PibSalidas";
            this.PibSalidas.Size = new System.Drawing.Size(99, 30);
            this.PibSalidas.TabIndex = 2;
            this.PibSalidas.TabStop = false;
            this.PibSalidas.Visible = false;
            this.PibSalidas.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PibEntradas
            // 
            this.PibEntradas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PibEntradas.Location = new System.Drawing.Point(474, 9);
            this.PibEntradas.Name = "PibEntradas";
            this.PibEntradas.Size = new System.Drawing.Size(99, 30);
            this.PibEntradas.TabIndex = 1;
            this.PibEntradas.TabStop = false;
            this.PibEntradas.Visible = false;
            this.PibEntradas.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnl_Contenedor_Entradas
            // 
            this.pnl_Contenedor_Entradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.pnl_Contenedor_Entradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Contenedor_Entradas.Location = new System.Drawing.Point(0, 47);
            this.pnl_Contenedor_Entradas.Name = "pnl_Contenedor_Entradas";
            this.pnl_Contenedor_Entradas.Size = new System.Drawing.Size(724, 365);
            this.pnl_Contenedor_Entradas.TabIndex = 3;
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(724, 412);
            this.Controls.Add(this.pnl_Contenedor_Entradas);
            this.Controls.Add(this.PnlEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistorial";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHistorial_Load);
            this.PnlEncabezado.ResumeLayout(false);
            this.PnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibEntradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlEncabezado;
        private System.Windows.Forms.Panel pnl_Contenedor_Entradas;
        private System.Windows.Forms.PictureBox PibSalidas;
        private System.Windows.Forms.PictureBox PibEntradas;
        private System.Windows.Forms.Button BtnSalidas;
        private System.Windows.Forms.Button BtnEntradas;
    }
}