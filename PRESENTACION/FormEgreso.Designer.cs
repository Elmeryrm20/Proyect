namespace PRESENTACION
{
    partial class FormEgreso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSerrar = new System.Windows.Forms.PictureBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.LblStock = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DgvSalida = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnSerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 37);
            this.panel1.TabIndex = 0;
            // 
            // btnSerrar
            // 
            this.btnSerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnSerrar.Image = global::PRESENTACION.Properties.Resources.BotonFormCancelar05;
            this.btnSerrar.Location = new System.Drawing.Point(287, 248);
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
            this.lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.lbl_Nombre.Location = new System.Drawing.Point(148, 9);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(260, 55);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "label1";
            this.lbl_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 30.75F, System.Drawing.FontStyle.Bold);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.txtCantidad.Location = new System.Drawing.Point(227, 94);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(105, 51);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // LblStock
            // 
            this.LblStock.BackColor = System.Drawing.Color.Transparent;
            this.LblStock.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.LblStock.ForeColor = System.Drawing.Color.Tomato;
            this.LblStock.Location = new System.Drawing.Point(227, 186);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(105, 31);
            this.LblStock.TabIndex = 4;
            this.LblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PRESENTACION.Properties.Resources.BotonFormConfirmar03;
            this.pictureBox1.Location = new System.Drawing.Point(162, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 40);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // DgvSalida
            // 
            this.DgvSalida.AllowUserToAddRows = false;
            this.DgvSalida.AllowUserToDeleteRows = false;
            this.DgvSalida.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvSalida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvSalida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.DgvSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvSalida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvSalida.ColumnHeadersHeight = 25;
            this.DgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvSalida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSalida.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvSalida.EnableHeadersVisualStyles = false;
            this.DgvSalida.GridColor = System.Drawing.Color.Tomato;
            this.DgvSalida.Location = new System.Drawing.Point(49, 335);
            this.DgvSalida.MultiSelect = false;
            this.DgvSalida.Name = "DgvSalida";
            this.DgvSalida.ReadOnly = true;
            this.DgvSalida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSalida.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvSalida.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Humnst777 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvSalida.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvSalida.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DgvSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSalida.Size = new System.Drawing.Size(294, 78);
            this.DgvSalida.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "LabCodigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 88;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Laboratorio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 91;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stock";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 59;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha Venc.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 99;
            // 
            // FormEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRESENTACION.Properties.Resources.FondoSalida01;
            this.ClientSize = new System.Drawing.Size(420, 438);
            this.Controls.Add(this.DgvSalida);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btnSerrar);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEgreso";
            ((System.ComponentModel.ISupportInitialize)(this.btnSerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnSerrar;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblStock;
        public System.Windows.Forms.DataGridView DgvSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}