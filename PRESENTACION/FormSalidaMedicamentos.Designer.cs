
namespace PRESENTACION
{
    partial class FormSalidaMedicamentos
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
            this.TxtPersona = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbEncargado = new System.Windows.Forms.ComboBox();
            this.TxtTrabajador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PibAgregarMed = new System.Windows.Forms.PictureBox();
            this.PibEliminarMed = new System.Windows.Forms.PictureBox();
            this.PibLimpiar = new System.Windows.Forms.PictureBox();
            this.PibGuardarImprimir = new System.Windows.Forms.PictureBox();
            this.DgvSalida = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PibAgregarMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibEliminarMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibGuardarImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPersona
            // 
            this.TxtPersona.Location = new System.Drawing.Point(99, 26);
            this.TxtPersona.Name = "TxtPersona";
            this.TxtPersona.Size = new System.Drawing.Size(192, 20);
            this.TxtPersona.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Persona:";
            // 
            // CmbEncargado
            // 
            this.CmbEncargado.FormattingEnabled = true;
            this.CmbEncargado.Location = new System.Drawing.Point(403, 25);
            this.CmbEncargado.Name = "CmbEncargado";
            this.CmbEncargado.Size = new System.Drawing.Size(121, 21);
            this.CmbEncargado.TabIndex = 3;
            // 
            // TxtTrabajador
            // 
            this.TxtTrabajador.Location = new System.Drawing.Point(99, 66);
            this.TxtTrabajador.Name = "TxtTrabajador";
            this.TxtTrabajador.ReadOnly = true;
            this.TxtTrabajador.Size = new System.Drawing.Size(192, 20);
            this.TxtTrabajador.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trabajador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Encargado:";
            // 
            // PibAgregarMed
            // 
            this.PibAgregarMed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PibAgregarMed.Image = global::PRESENTACION.Properties.Resources.BotonFormIngreso01;
            this.PibAgregarMed.Location = new System.Drawing.Point(492, 118);
            this.PibAgregarMed.Name = "PibAgregarMed";
            this.PibAgregarMed.Size = new System.Drawing.Size(110, 40);
            this.PibAgregarMed.TabIndex = 4;
            this.PibAgregarMed.TabStop = false;
            this.PibAgregarMed.Click += new System.EventHandler(this.PibAgregarMed_Click);
            // 
            // PibEliminarMed
            // 
            this.PibEliminarMed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PibEliminarMed.Image = global::PRESENTACION.Properties.Resources.BotonFormeEliminar01;
            this.PibEliminarMed.Location = new System.Drawing.Point(492, 174);
            this.PibEliminarMed.Name = "PibEliminarMed";
            this.PibEliminarMed.Size = new System.Drawing.Size(110, 40);
            this.PibEliminarMed.TabIndex = 5;
            this.PibEliminarMed.TabStop = false;
            // 
            // PibLimpiar
            // 
            this.PibLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PibLimpiar.Image = global::PRESENTACION.Properties.Resources.BotonFormActualizar01;
            this.PibLimpiar.Location = new System.Drawing.Point(492, 229);
            this.PibLimpiar.Name = "PibLimpiar";
            this.PibLimpiar.Size = new System.Drawing.Size(110, 40);
            this.PibLimpiar.TabIndex = 6;
            this.PibLimpiar.TabStop = false;
            // 
            // PibGuardarImprimir
            // 
            this.PibGuardarImprimir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PibGuardarImprimir.Image = global::PRESENTACION.Properties.Resources.BotonFormImprimir01;
            this.PibGuardarImprimir.Location = new System.Drawing.Point(492, 285);
            this.PibGuardarImprimir.Name = "PibGuardarImprimir";
            this.PibGuardarImprimir.Size = new System.Drawing.Size(110, 40);
            this.PibGuardarImprimir.TabIndex = 7;
            this.PibGuardarImprimir.TabStop = false;
            // 
            // DgvSalida
            // 
            this.DgvSalida.AllowUserToAddRows = false;
            this.DgvSalida.AllowUserToDeleteRows = false;
            this.DgvSalida.AllowUserToOrderColumns = true;
            this.DgvSalida.AllowUserToResizeColumns = false;
            this.DgvSalida.AllowUserToResizeRows = false;
            this.DgvSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSalida.BackgroundColor = System.Drawing.Color.White;
            this.DgvSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvSalida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSalida.ColumnHeadersHeight = 30;
            this.DgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvSalida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSalida.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvSalida.EnableHeadersVisualStyles = false;
            this.DgvSalida.GridColor = System.Drawing.Color.Tomato;
            this.DgvSalida.Location = new System.Drawing.Point(35, 118);
            this.DgvSalida.MultiSelect = false;
            this.DgvSalida.Name = "DgvSalida";
            this.DgvSalida.ReadOnly = true;
            this.DgvSalida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSalida.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvSalida.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvSalida.Size = new System.Drawing.Size(418, 215);
            this.DgvSalida.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 225;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormSalidaMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.DgvSalida);
            this.Controls.Add(this.PibGuardarImprimir);
            this.Controls.Add(this.PibLimpiar);
            this.Controls.Add(this.PibEliminarMed);
            this.Controls.Add(this.PibAgregarMed);
            this.Controls.Add(this.CmbEncargado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTrabajador);
            this.Controls.Add(this.TxtPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSalidaMedicamentos";
            this.Text = "FormSalidaMedicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.PibAgregarMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibEliminarMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibGuardarImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbEncargado;
        private System.Windows.Forms.TextBox TxtTrabajador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PibAgregarMed;
        private System.Windows.Forms.PictureBox PibEliminarMed;
        private System.Windows.Forms.PictureBox PibLimpiar;
        private System.Windows.Forms.PictureBox PibGuardarImprimir;
        public System.Windows.Forms.DataGridView DgvSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}