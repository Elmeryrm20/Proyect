
namespace PRESENTACION
{
    partial class FormControldeEntradas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Texto = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.txt_Error = new System.Windows.Forms.Label();
            this.LblHasta = new System.Windows.Forms.Label();
            this.PibFiltrar = new System.Windows.Forms.PictureBox();
            this.dtp_FechaF = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaI = new System.Windows.Forms.DateTimePicker();
            this.LblDesde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PibImprimir = new System.Windows.Forms.PictureBox();
            this.btn_Informe = new System.Windows.Forms.PictureBox();
            this.PibActualizar = new System.Windows.Forms.PictureBox();
            this.DgvHistorialIngreso = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibFiltrar)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Informe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.txt_Texto);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 72);
            this.panel2.TabIndex = 5;
            // 
            // txt_Texto
            // 
            this.txt_Texto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Texto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.txt_Texto.Location = new System.Drawing.Point(55, 32);
            this.txt_Texto.MaxLength = 50;
            this.txt_Texto.Name = "txt_Texto";
            this.txt_Texto.Size = new System.Drawing.Size(253, 16);
            this.txt_Texto.TabIndex = 0;
            this.txt_Texto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PRESENTACION.Properties.Resources.TextBox01;
            this.pictureBox2.Location = new System.Drawing.Point(15, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(310, 30);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(42, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "BUSCAR POR COMPOSICION O TRABAJADOR ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 268);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.panel3.Controls.Add(this.CmbFiltro);
            this.panel3.Controls.Add(this.txt_Error);
            this.panel3.Controls.Add(this.LblHasta);
            this.panel3.Controls.Add(this.PibFiltrar);
            this.panel3.Controls.Add(this.dtp_FechaF);
            this.panel3.Controls.Add(this.dtp_FechaI);
            this.panel3.Controls.Add(this.LblDesde);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(577, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 268);
            this.panel3.TabIndex = 7;
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.BackColor = System.Drawing.Color.White;
            this.CmbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbFiltro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "Hoy",
            "Últimos 7 días",
            "Ultimos 30 días",
            "Elegir una Fecha",
            "Rango de Fechas"});
            this.CmbFiltro.Location = new System.Drawing.Point(6, 43);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.CmbFiltro.TabIndex = 9;
            this.CmbFiltro.SelectedIndexChanged += new System.EventHandler(this.CmbFiltro_SelectedIndexChanged);
            this.CmbFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbFiltro_KeyPress);
            // 
            // txt_Error
            // 
            this.txt_Error.AutoSize = true;
            this.txt_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_Error.Location = new System.Drawing.Point(12, 236);
            this.txt_Error.Name = "txt_Error";
            this.txt_Error.Size = new System.Drawing.Size(103, 13);
            this.txt_Error.TabIndex = 8;
            this.txt_Error.Text = "Ingrese rango valido";
            this.txt_Error.Visible = false;
            // 
            // LblHasta
            // 
            this.LblHasta.AutoSize = true;
            this.LblHasta.Location = new System.Drawing.Point(14, 127);
            this.LblHasta.Name = "LblHasta";
            this.LblHasta.Size = new System.Drawing.Size(35, 13);
            this.LblHasta.TabIndex = 7;
            this.LblHasta.Text = "Hasta";
            this.LblHasta.Visible = false;
            // 
            // PibFiltrar
            // 
            this.PibFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.PibFiltrar.Image = global::PRESENTACION.Properties.Resources.BotonFormFiltrar01;
            this.PibFiltrar.Location = new System.Drawing.Point(9, 193);
            this.PibFiltrar.Name = "PibFiltrar";
            this.PibFiltrar.Size = new System.Drawing.Size(110, 40);
            this.PibFiltrar.TabIndex = 6;
            this.PibFiltrar.TabStop = false;
            this.PibFiltrar.Click += new System.EventHandler(this.pictureBox1_Click);
            this.PibFiltrar.MouseEnter += new System.EventHandler(this.PibFiltrar_MouseEnter);
            this.PibFiltrar.MouseLeave += new System.EventHandler(this.PibFiltrar_MouseLeave);
            // 
            // dtp_FechaF
            // 
            this.dtp_FechaF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaF.Location = new System.Drawing.Point(17, 143);
            this.dtp_FechaF.Name = "dtp_FechaF";
            this.dtp_FechaF.Size = new System.Drawing.Size(100, 20);
            this.dtp_FechaF.TabIndex = 5;
            this.dtp_FechaF.Visible = false;
            // 
            // dtp_FechaI
            // 
            this.dtp_FechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaI.Location = new System.Drawing.Point(15, 99);
            this.dtp_FechaI.Name = "dtp_FechaI";
            this.dtp_FechaI.Size = new System.Drawing.Size(100, 20);
            this.dtp_FechaI.TabIndex = 4;
            this.dtp_FechaI.Visible = false;
            // 
            // LblDesde
            // 
            this.LblDesde.AutoSize = true;
            this.LblDesde.Location = new System.Drawing.Point(14, 83);
            this.LblDesde.Name = "LblDesde";
            this.LblDesde.Size = new System.Drawing.Size(38, 13);
            this.LblDesde.TabIndex = 3;
            this.LblDesde.Text = "Desde";
            this.LblDesde.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "FILTRAR POR FECHA";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.panel4.Controls.Add(this.PibImprimir);
            this.panel4.Controls.Add(this.btn_Informe);
            this.panel4.Controls.Add(this.PibActualizar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 340);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(707, 65);
            this.panel4.TabIndex = 8;
            // 
            // PibImprimir
            // 
            this.PibImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PibImprimir.BackColor = System.Drawing.Color.Transparent;
            this.PibImprimir.Image = global::PRESENTACION.Properties.Resources.BotonFormImprimir01;
            this.PibImprimir.Location = new System.Drawing.Point(277, 13);
            this.PibImprimir.Name = "PibImprimir";
            this.PibImprimir.Size = new System.Drawing.Size(110, 40);
            this.PibImprimir.TabIndex = 5;
            this.PibImprimir.TabStop = false;
            this.PibImprimir.Visible = false;
            this.PibImprimir.Click += new System.EventHandler(this.PibImprimir_Click);
            this.PibImprimir.MouseEnter += new System.EventHandler(this.PibImprimir_MouseEnter_1);
            this.PibImprimir.MouseLeave += new System.EventHandler(this.PibImprimir_MouseLeave);
            // 
            // btn_Informe
            // 
            this.btn_Informe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Informe.BackColor = System.Drawing.Color.Transparent;
            this.btn_Informe.Image = global::PRESENTACION.Properties.Resources.BotonFormInforme01;
            this.btn_Informe.Location = new System.Drawing.Point(161, 13);
            this.btn_Informe.Name = "btn_Informe";
            this.btn_Informe.Size = new System.Drawing.Size(110, 40);
            this.btn_Informe.TabIndex = 4;
            this.btn_Informe.TabStop = false;
            this.btn_Informe.Click += new System.EventHandler(this.btn_Informe_Click);
            this.btn_Informe.MouseEnter += new System.EventHandler(this.btn_Informe_MouseEnter);
            this.btn_Informe.MouseLeave += new System.EventHandler(this.btn_Informe_MouseLeave);
            // 
            // PibActualizar
            // 
            this.PibActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PibActualizar.BackColor = System.Drawing.Color.Transparent;
            this.PibActualizar.Image = global::PRESENTACION.Properties.Resources.BotonFormActualizar01;
            this.PibActualizar.Location = new System.Drawing.Point(45, 13);
            this.PibActualizar.Name = "PibActualizar";
            this.PibActualizar.Size = new System.Drawing.Size(110, 40);
            this.PibActualizar.TabIndex = 3;
            this.PibActualizar.TabStop = false;
            this.PibActualizar.Click += new System.EventHandler(this.PibActualizar_Click);
            this.PibActualizar.MouseEnter += new System.EventHandler(this.PibActualizar_MouseEnter);
            this.PibActualizar.MouseLeave += new System.EventHandler(this.PibActualizar_MouseLeave);
            // 
            // DgvHistorialIngreso
            // 
            this.DgvHistorialIngreso.AllowUserToAddRows = false;
            this.DgvHistorialIngreso.AllowUserToDeleteRows = false;
            this.DgvHistorialIngreso.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvHistorialIngreso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvHistorialIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvHistorialIngreso.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.DgvHistorialIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvHistorialIngreso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHistorialIngreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvHistorialIngreso.ColumnHeadersHeight = 25;
            this.DgvHistorialIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHistorialIngreso.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvHistorialIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvHistorialIngreso.EnableHeadersVisualStyles = false;
            this.DgvHistorialIngreso.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.DgvHistorialIngreso.Location = new System.Drawing.Point(20, 72);
            this.DgvHistorialIngreso.MultiSelect = false;
            this.DgvHistorialIngreso.Name = "DgvHistorialIngreso";
            this.DgvHistorialIngreso.ReadOnly = true;
            this.DgvHistorialIngreso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHistorialIngreso.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvHistorialIngreso.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DgvHistorialIngreso.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvHistorialIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvHistorialIngreso.Size = new System.Drawing.Size(557, 268);
            this.DgvHistorialIngreso.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormControldeEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(707, 405);
            this.Controls.Add(this.DgvHistorialIngreso);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormControldeEntradas";
            this.Text = "FormControldeEntradas";
            this.Load += new System.EventHandler(this.FormControldeEntradas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibFiltrar)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PibImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Informe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PibActualizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Texto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox PibFiltrar;
        private System.Windows.Forms.DateTimePicker dtp_FechaF;
        private System.Windows.Forms.DateTimePicker dtp_FechaI;
        private System.Windows.Forms.Label LblDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_Error;
        public System.Windows.Forms.DataGridView DgvHistorialIngreso;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btn_Informe;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.PictureBox PibImprimir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}