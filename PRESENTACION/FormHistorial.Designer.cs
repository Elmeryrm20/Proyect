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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Contenedor_Entradas = new System.Windows.Forms.Panel();
            this.PibSalidas = new System.Windows.Forms.PictureBox();
            this.PibEntradas = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PibSalidas);
            this.panel1.Controls.Add(this.PibEntradas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 47);
            this.panel1.TabIndex = 1;
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
            // PibSalidas
            // 
            this.PibSalidas.BackColor = System.Drawing.Color.CornflowerBlue;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(106, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "ENTRADAS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(232, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "SALIDAS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(724, 412);
            this.Controls.Add(this.pnl_Contenedor_Entradas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistorial";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibEntradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Contenedor_Entradas;
        private System.Windows.Forms.PictureBox PibSalidas;
        private System.Windows.Forms.PictureBox PibEntradas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}