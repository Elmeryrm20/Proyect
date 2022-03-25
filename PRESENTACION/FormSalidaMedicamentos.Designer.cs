
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
            this.TxtNumDNI = new System.Windows.Forms.TextBox();
            this.LblDestino = new System.Windows.Forms.Label();
            this.CmbEncargado = new System.Windows.Forms.ComboBox();
            this.TxtTrabajador = new System.Windows.Forms.TextBox();
            this.LblTrabajador = new System.Windows.Forms.Label();
            this.LblEncargado = new System.Windows.Forms.Label();
            this.PibAgregarMed = new System.Windows.Forms.PictureBox();
            this.PibEliminarMed = new System.Windows.Forms.PictureBox();
            this.PibLimpiar = new System.Windows.Forms.PictureBox();
            this.PibGuardarImprimir = new System.Windows.Forms.PictureBox();
            this.DgvSalida = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblColaborador = new System.Windows.Forms.Label();
            this.CmbTipoDNI = new System.Windows.Forms.ComboBox();
            this.GrbDestino = new System.Windows.Forms.GroupBox();
            this.GrbPersonal = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNacionalidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pnl01 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PibAgregarMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibEliminarMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibGuardarImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalida)).BeginInit();
            this.GrbDestino.SuspendLayout();
            this.GrbPersonal.SuspendLayout();
            this.Pnl01.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNumDNI
            // 
            this.TxtNumDNI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtNumDNI.Location = new System.Drawing.Point(109, 54);
            this.TxtNumDNI.Name = "TxtNumDNI";
            this.TxtNumDNI.Size = new System.Drawing.Size(192, 20);
            this.TxtNumDNI.TabIndex = 1;
            // 
            // LblDestino
            // 
            this.LblDestino.AutoSize = true;
            this.LblDestino.Location = new System.Drawing.Point(81, 57);
            this.LblDestino.Name = "LblDestino";
            this.LblDestino.Size = new System.Drawing.Size(22, 13);
            this.LblDestino.TabIndex = 2;
            this.LblDestino.Text = "N°:";
            // 
            // CmbEncargado
            // 
            this.CmbEncargado.FormattingEnabled = true;
            this.CmbEncargado.Location = new System.Drawing.Point(81, 116);
            this.CmbEncargado.Name = "CmbEncargado";
            this.CmbEncargado.Size = new System.Drawing.Size(192, 21);
            this.CmbEncargado.TabIndex = 3;
            // 
            // TxtTrabajador
            // 
            this.TxtTrabajador.Location = new System.Drawing.Point(81, 29);
            this.TxtTrabajador.Name = "TxtTrabajador";
            this.TxtTrabajador.ReadOnly = true;
            this.TxtTrabajador.Size = new System.Drawing.Size(192, 20);
            this.TxtTrabajador.TabIndex = 1;
            this.TxtTrabajador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblTrabajador
            // 
            this.LblTrabajador.AutoSize = true;
            this.LblTrabajador.Location = new System.Drawing.Point(14, 33);
            this.LblTrabajador.Name = "LblTrabajador";
            this.LblTrabajador.Size = new System.Drawing.Size(61, 13);
            this.LblTrabajador.TabIndex = 2;
            this.LblTrabajador.Text = "Trabajador:";
            // 
            // LblEncargado
            // 
            this.LblEncargado.AutoSize = true;
            this.LblEncargado.Location = new System.Drawing.Point(13, 120);
            this.LblEncargado.Name = "LblEncargado";
            this.LblEncargado.Size = new System.Drawing.Size(62, 13);
            this.LblEncargado.TabIndex = 2;
            this.LblEncargado.Text = "Encargado:";
            // 
            // PibAgregarMed
            // 
            this.PibAgregarMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PibAgregarMed.Image = global::PRESENTACION.Properties.Resources.BotonFormIngreso01;
            this.PibAgregarMed.Location = new System.Drawing.Point(583, 223);
            this.PibAgregarMed.Name = "PibAgregarMed";
            this.PibAgregarMed.Size = new System.Drawing.Size(110, 40);
            this.PibAgregarMed.TabIndex = 4;
            this.PibAgregarMed.TabStop = false;
            this.PibAgregarMed.Click += new System.EventHandler(this.PibAgregarMed_Click);
            // 
            // PibEliminarMed
            // 
            this.PibEliminarMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PibEliminarMed.Image = global::PRESENTACION.Properties.Resources.BotonFormeEliminar01;
            this.PibEliminarMed.Location = new System.Drawing.Point(583, 279);
            this.PibEliminarMed.Name = "PibEliminarMed";
            this.PibEliminarMed.Size = new System.Drawing.Size(110, 40);
            this.PibEliminarMed.TabIndex = 5;
            this.PibEliminarMed.TabStop = false;
            // 
            // PibLimpiar
            // 
            this.PibLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PibLimpiar.Image = global::PRESENTACION.Properties.Resources.BotonFormActualizar01;
            this.PibLimpiar.Location = new System.Drawing.Point(583, 334);
            this.PibLimpiar.Name = "PibLimpiar";
            this.PibLimpiar.Size = new System.Drawing.Size(110, 40);
            this.PibLimpiar.TabIndex = 6;
            this.PibLimpiar.TabStop = false;
            // 
            // PibGuardarImprimir
            // 
            this.PibGuardarImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PibGuardarImprimir.Image = global::PRESENTACION.Properties.Resources.BotonFormImprimir01;
            this.PibGuardarImprimir.Location = new System.Drawing.Point(583, 390);
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
            this.DgvSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
            this.DgvSalida.Location = new System.Drawing.Point(22, 223);
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
            this.DgvSalida.Size = new System.Drawing.Size(536, 215);
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
            this.Column2.Width = 103;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 88;
            // 
            // LblColaborador
            // 
            this.LblColaborador.AutoSize = true;
            this.LblColaborador.Location = new System.Drawing.Point(8, 30);
            this.LblColaborador.Name = "LblColaborador";
            this.LblColaborador.Size = new System.Drawing.Size(95, 13);
            this.LblColaborador.TabIndex = 2;
            this.LblColaborador.Text = "Doc. de Identidad:";
            // 
            // CmbTipoDNI
            // 
            this.CmbTipoDNI.FormattingEnabled = true;
            this.CmbTipoDNI.Location = new System.Drawing.Point(109, 27);
            this.CmbTipoDNI.Name = "CmbTipoDNI";
            this.CmbTipoDNI.Size = new System.Drawing.Size(192, 21);
            this.CmbTipoDNI.TabIndex = 3;
            // 
            // GrbDestino
            // 
            this.GrbDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbDestino.Controls.Add(this.TxtTelefono);
            this.GrbDestino.Controls.Add(this.LblColaborador);
            this.GrbDestino.Controls.Add(this.label4);
            this.GrbDestino.Controls.Add(this.TxtNacionalidad);
            this.GrbDestino.Controls.Add(this.label3);
            this.GrbDestino.Controls.Add(this.CmbTipoDNI);
            this.GrbDestino.Controls.Add(this.TxtApellidos);
            this.GrbDestino.Controls.Add(this.label2);
            this.GrbDestino.Controls.Add(this.TxtNombres);
            this.GrbDestino.Controls.Add(this.label1);
            this.GrbDestino.Controls.Add(this.TxtNumDNI);
            this.GrbDestino.Controls.Add(this.LblDestino);
            this.GrbDestino.Location = new System.Drawing.Point(12, 12);
            this.GrbDestino.Name = "GrbDestino";
            this.GrbDestino.Size = new System.Drawing.Size(316, 193);
            this.GrbDestino.TabIndex = 10;
            this.GrbDestino.TabStop = false;
            this.GrbDestino.Text = "DESTINO";
            // 
            // GrbPersonal
            // 
            this.GrbPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbPersonal.Controls.Add(this.TxtTrabajador);
            this.GrbPersonal.Controls.Add(this.label5);
            this.GrbPersonal.Controls.Add(this.LblEncargado);
            this.GrbPersonal.Controls.Add(this.LblTrabajador);
            this.GrbPersonal.Controls.Add(this.CmbEncargado);
            this.GrbPersonal.Controls.Add(this.comboBox1);
            this.GrbPersonal.Location = new System.Drawing.Point(348, 27);
            this.GrbPersonal.Name = "GrbPersonal";
            this.GrbPersonal.Size = new System.Drawing.Size(309, 151);
            this.GrbPersonal.TabIndex = 10;
            this.GrbPersonal.TabStop = false;
            this.GrbPersonal.Text = "PERSONAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres:";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombres.Location = new System.Drawing.Point(109, 80);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(168, 20);
            this.TxtNombres.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApellidos.Location = new System.Drawing.Point(109, 106);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(168, 20);
            this.TxtApellidos.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nacionalidad:";
            // 
            // TxtNacionalidad
            // 
            this.TxtNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNacionalidad.Location = new System.Drawing.Point(109, 132);
            this.TxtNacionalidad.Name = "TxtNacionalidad";
            this.TxtNacionalidad.Size = new System.Drawing.Size(168, 20);
            this.TxtNacionalidad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Teléfono:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTelefono.Location = new System.Drawing.Point(109, 158);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(168, 20);
            this.TxtTelefono.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Colaborador:";
            // 
            // Pnl01
            // 
            this.Pnl01.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl01.Controls.Add(this.GrbDestino);
            this.Pnl01.Controls.Add(this.GrbPersonal);
            this.Pnl01.Location = new System.Drawing.Point(12, 8);
            this.Pnl01.Name = "Pnl01";
            this.Pnl01.Size = new System.Drawing.Size(699, 209);
            this.Pnl01.TabIndex = 4;
            // 
            // FormSalidaMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.Pnl01);
            this.Controls.Add(this.DgvSalida);
            this.Controls.Add(this.PibGuardarImprimir);
            this.Controls.Add(this.PibLimpiar);
            this.Controls.Add(this.PibEliminarMed);
            this.Controls.Add(this.PibAgregarMed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSalidaMedicamentos";
            this.Text = "FormSalidaMedicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.PibAgregarMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibEliminarMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibGuardarImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalida)).EndInit();
            this.GrbDestino.ResumeLayout(false);
            this.GrbDestino.PerformLayout();
            this.GrbPersonal.ResumeLayout(false);
            this.GrbPersonal.PerformLayout();
            this.Pnl01.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNumDNI;
        private System.Windows.Forms.Label LblDestino;
        private System.Windows.Forms.ComboBox CmbEncargado;
        private System.Windows.Forms.TextBox TxtTrabajador;
        private System.Windows.Forms.Label LblTrabajador;
        private System.Windows.Forms.Label LblEncargado;
        private System.Windows.Forms.PictureBox PibAgregarMed;
        private System.Windows.Forms.PictureBox PibEliminarMed;
        private System.Windows.Forms.PictureBox PibLimpiar;
        private System.Windows.Forms.PictureBox PibGuardarImprimir;
        public System.Windows.Forms.DataGridView DgvSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label LblColaborador;
        private System.Windows.Forms.ComboBox CmbTipoDNI;
        private System.Windows.Forms.GroupBox GrbDestino;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNacionalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrbPersonal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel Pnl01;
    }
}