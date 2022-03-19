namespace PRESENTACION
{
    partial class FormLogin
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
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DtgPrueba = new System.Windows.Forms.DataGridView();
            this.PibIngresar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PibCheckUsu = new System.Windows.Forms.PictureBox();
            this.PibCheckPass = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPrueba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibCheckUsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibCheckPass)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(201)))));
            this.txtusuario.Location = new System.Drawing.Point(417, 129);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtusuario.MaxLength = 20;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(175, 15);
            this.txtusuario.TabIndex = 2;
            this.txtusuario.Text = "DNI";
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            this.txtusuario.Enter += new System.EventHandler(this.Txtusuario_Enter);
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            this.txtusuario.Leave += new System.EventHandler(this.txtusuario_Leave);
            this.txtusuario.MouseEnter += new System.EventHandler(this.txtusuario_MouseEnter);
            // 
            // TxtPass
            // 
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(201)))));
            this.TxtPass.Location = new System.Drawing.Point(417, 194);
            this.TxtPass.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPass.MaxLength = 20;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(175, 15);
            this.TxtPass.TabIndex = 3;
            this.TxtPass.Text = "Contraseña";
            this.TxtPass.TextChanged += new System.EventHandler(this.txtcontraseña_TextChanged);
            this.TxtPass.Enter += new System.EventHandler(this.txtcontraseña_Enter);
            this.TxtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontraseña_KeyPress);
            this.TxtPass.Leave += new System.EventHandler(this.txtcontraseña_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 37);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(590, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 27);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(623, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.PibCheckPass);
            this.panel2.Controls.Add(this.PibCheckUsu);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DtgPrueba);
            this.panel2.Controls.Add(this.PibIngresar);
            this.panel2.Controls.Add(this.txtusuario);
            this.panel2.Controls.Add(this.TxtPass);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 360);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(428, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Aun no tengo contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DtgPrueba
            // 
            this.DtgPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPrueba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtgPrueba.Location = new System.Drawing.Point(28, 130);
            this.DtgPrueba.Name = "DtgPrueba";
            this.DtgPrueba.Size = new System.Drawing.Size(240, 150);
            this.DtgPrueba.TabIndex = 15;
            this.DtgPrueba.Visible = false;
            // 
            // PibIngresar
            // 
            this.PibIngresar.BackColor = System.Drawing.Color.Transparent;
            this.PibIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PibIngresar.Image = global::PRESENTACION.Properties.Resources.BotonIngresar01;
            this.PibIngresar.Location = new System.Drawing.Point(400, 279);
            this.PibIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.PibIngresar.Name = "PibIngresar";
            this.PibIngresar.Size = new System.Drawing.Size(180, 50);
            this.PibIngresar.TabIndex = 0;
            this.PibIngresar.TabStop = false;
            this.PibIngresar.Click += new System.EventHandler(this.pictureBox2_Click);
            this.PibIngresar.MouseEnter += new System.EventHandler(this.PibIngresar_MouseEnter);
            this.PibIngresar.MouseLeave += new System.EventHandler(this.PibIngresar_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 321);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Lime;
            this.pictureBox2.Location = new System.Drawing.Point(-15, -15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // PibCheckUsu
            // 
            this.PibCheckUsu.Location = new System.Drawing.Point(610, 124);
            this.PibCheckUsu.Name = "PibCheckUsu";
            this.PibCheckUsu.Size = new System.Drawing.Size(20, 20);
            this.PibCheckUsu.TabIndex = 18;
            this.PibCheckUsu.TabStop = false;
            // 
            // PibCheckPass
            // 
            this.PibCheckPass.BackColor = System.Drawing.Color.Red;
            this.PibCheckPass.Location = new System.Drawing.Point(610, 189);
            this.PibCheckPass.Name = "PibCheckPass";
            this.PibCheckPass.Size = new System.Drawing.Size(20, 20);
            this.PibCheckPass.TabIndex = 18;
            this.PibCheckPass.TabStop = false;
            this.PibCheckPass.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRESENTACION.Properties.Resources.Login01;
            this.ClientSize = new System.Drawing.Size(660, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPrueba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibCheckUsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibCheckPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PibIngresar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView DtgPrueba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PibCheckPass;
        private System.Windows.Forms.PictureBox PibCheckUsu;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}