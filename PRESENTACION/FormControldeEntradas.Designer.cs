﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Texto = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Error = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_FechaF = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaI = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Informe = new System.Windows.Forms.PictureBox();
            this.PibActualizar = new System.Windows.Forms.PictureBox();
            this.DgvHistorialIngreso = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Informe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialIngreso)).BeginInit();
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
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
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
            this.panel1.Size = new System.Drawing.Size(20, 275);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.panel3.Controls.Add(this.txt_Error);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.dtp_FechaF);
            this.panel3.Controls.Add(this.dtp_FechaI);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(577, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 275);
            this.panel3.TabIndex = 7;
            // 
            // txt_Error
            // 
            this.txt_Error.AutoSize = true;
            this.txt_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_Error.Location = new System.Drawing.Point(6, 159);
            this.txt_Error.Name = "txt_Error";
            this.txt_Error.Size = new System.Drawing.Size(103, 13);
            this.txt_Error.TabIndex = 8;
            this.txt_Error.Text = "Ingrese rango valido";
            this.txt_Error.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(9, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 24);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtp_FechaF
            // 
            this.dtp_FechaF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaF.Location = new System.Drawing.Point(9, 93);
            this.dtp_FechaF.Name = "dtp_FechaF";
            this.dtp_FechaF.Size = new System.Drawing.Size(100, 20);
            this.dtp_FechaF.TabIndex = 5;
            // 
            // dtp_FechaI
            // 
            this.dtp_FechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaI.Location = new System.Drawing.Point(9, 49);
            this.dtp_FechaI.Name = "dtp_FechaI";
            this.dtp_FechaI.Size = new System.Drawing.Size(100, 20);
            this.dtp_FechaI.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "FILTRAR POR FECHA";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btn_Informe);
            this.panel4.Controls.Add(this.PibActualizar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 347);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(707, 58);
            this.panel4.TabIndex = 8;
            // 
            // btn_Informe
            // 
            this.btn_Informe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Informe.BackColor = System.Drawing.Color.Transparent;
            this.btn_Informe.Image = global::PRESENTACION.Properties.Resources.BotonFormActualizar01;
            this.btn_Informe.Location = new System.Drawing.Point(161, 6);
            this.btn_Informe.Name = "btn_Informe";
            this.btn_Informe.Size = new System.Drawing.Size(110, 40);
            this.btn_Informe.TabIndex = 4;
            this.btn_Informe.TabStop = false;
            this.btn_Informe.Click += new System.EventHandler(this.btn_Informe_Click);
            // 
            // PibActualizar
            // 
            this.PibActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PibActualizar.BackColor = System.Drawing.Color.Transparent;
            this.PibActualizar.Image = global::PRESENTACION.Properties.Resources.BotonFormActualizar01;
            this.PibActualizar.Location = new System.Drawing.Point(45, 6);
            this.PibActualizar.Name = "PibActualizar";
            this.PibActualizar.Size = new System.Drawing.Size(110, 40);
            this.PibActualizar.TabIndex = 3;
            this.PibActualizar.TabStop = false;
            this.PibActualizar.Click += new System.EventHandler(this.PibActualizar_Click);
            // 
            // DgvHistorialIngreso
            // 
            this.DgvHistorialIngreso.AllowUserToAddRows = false;
            this.DgvHistorialIngreso.AllowUserToDeleteRows = false;
            this.DgvHistorialIngreso.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvHistorialIngreso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DgvHistorialIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvHistorialIngreso.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.DgvHistorialIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvHistorialIngreso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHistorialIngreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvHistorialIngreso.ColumnHeadersHeight = 25;
            this.DgvHistorialIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHistorialIngreso.DefaultCellStyle = dataGridViewCellStyle13;
            this.DgvHistorialIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvHistorialIngreso.EnableHeadersVisualStyles = false;
            this.DgvHistorialIngreso.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.DgvHistorialIngreso.Location = new System.Drawing.Point(20, 72);
            this.DgvHistorialIngreso.MultiSelect = false;
            this.DgvHistorialIngreso.Name = "DgvHistorialIngreso";
            this.DgvHistorialIngreso.ReadOnly = true;
            this.DgvHistorialIngreso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHistorialIngreso.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DgvHistorialIngreso.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DgvHistorialIngreso.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DgvHistorialIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvHistorialIngreso.Size = new System.Drawing.Size(557, 275);
            this.DgvHistorialIngreso.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Informe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialIngreso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PibActualizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Texto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_FechaF;
        private System.Windows.Forms.DateTimePicker dtp_FechaI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_Error;
        public System.Windows.Forms.DataGridView DgvHistorialIngreso;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btn_Informe;
        private System.Windows.Forms.Label label5;
    }
}