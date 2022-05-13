
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CmbEncargado = new System.Windows.Forms.ComboBox();
            this.TxtTrabajador = new System.Windows.Forms.TextBox();
            this.LblTrabajador = new System.Windows.Forms.Label();
            this.LblEncargado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbColaborador = new System.Windows.Forms.ComboBox();
            this.Pnl01 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblVoluntario = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.PibEncargado = new System.Windows.Forms.PictureBox();
            this.PibColaborador = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.DgvSalida = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PibGuardarImprimir = new System.Windows.Forms.PictureBox();
            this.PibLimpiar = new System.Windows.Forms.PictureBox();
            this.PibConfirmar = new System.Windows.Forms.PictureBox();
            this.PibEliminarMed = new System.Windows.Forms.PictureBox();
            this.PibAgregarMed = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Pnl01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibEncargado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibColaborador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibGuardarImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibConfirmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibEliminarMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibAgregarMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbEncargado
            // 
            this.CmbEncargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbEncargado.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.CmbEncargado.ForeColor = System.Drawing.Color.Tomato;
            this.CmbEncargado.FormattingEnabled = true;
            this.CmbEncargado.Location = new System.Drawing.Point(121, 147);
            this.CmbEncargado.Name = "CmbEncargado";
            this.CmbEncargado.Size = new System.Drawing.Size(192, 23);
            this.CmbEncargado.TabIndex = 8;
            this.CmbEncargado.Text = "Seleccionar:";
            this.CmbEncargado.SelectedIndexChanged += new System.EventHandler(this.CmbEncargado_SelectedIndexChanged);
            this.CmbEncargado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbColaborador_KeyPress);
            // 
            // TxtTrabajador
            // 
            this.TxtTrabajador.BackColor = System.Drawing.Color.White;
            this.TxtTrabajador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTrabajador.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.TxtTrabajador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.TxtTrabajador.Location = new System.Drawing.Point(333, 58);
            this.TxtTrabajador.Name = "TxtTrabajador";
            this.TxtTrabajador.ReadOnly = true;
            this.TxtTrabajador.Size = new System.Drawing.Size(192, 14);
            this.TxtTrabajador.TabIndex = 1;
            this.TxtTrabajador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTrabajador.Visible = false;
            // 
            // LblTrabajador
            // 
            this.LblTrabajador.AutoSize = true;
            this.LblTrabajador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.LblTrabajador.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTrabajador.ForeColor = System.Drawing.Color.White;
            this.LblTrabajador.Location = new System.Drawing.Point(55, 56);
            this.LblTrabajador.Name = "LblTrabajador";
            this.LblTrabajador.Size = new System.Drawing.Size(53, 16);
            this.LblTrabajador.TabIndex = 2;
            this.LblTrabajador.Text = "Usuario:";
            // 
            // LblEncargado
            // 
            this.LblEncargado.AutoSize = true;
            this.LblEncargado.BackColor = System.Drawing.Color.Tomato;
            this.LblEncargado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEncargado.ForeColor = System.Drawing.Color.White;
            this.LblEncargado.Location = new System.Drawing.Point(23, 151);
            this.LblEncargado.Name = "LblEncargado";
            this.LblEncargado.Size = new System.Drawing.Size(85, 16);
            this.LblEncargado.TabIndex = 2;
            this.LblEncargado.Text = "Coordinador:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Tomato;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Colaborador:";
            // 
            // CmbColaborador
            // 
            this.CmbColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbColaborador.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.CmbColaborador.ForeColor = System.Drawing.Color.Tomato;
            this.CmbColaborador.FormattingEnabled = true;
            this.CmbColaborador.Location = new System.Drawing.Point(121, 89);
            this.CmbColaborador.Name = "CmbColaborador";
            this.CmbColaborador.Size = new System.Drawing.Size(192, 23);
            this.CmbColaborador.TabIndex = 7;
            this.CmbColaborador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbColaborador_KeyPress);
            // 
            // Pnl01
            // 
            this.Pnl01.Controls.Add(this.label1);
            this.Pnl01.Controls.Add(this.CmbNacionalidad);
            this.Pnl01.Controls.Add(this.pictureBox1);
            this.Pnl01.Controls.Add(this.LblVoluntario);
            this.Pnl01.Controls.Add(this.label5);
            this.Pnl01.Controls.Add(this.LblEncargado);
            this.Pnl01.Controls.Add(this.LblTrabajador);
            this.Pnl01.Controls.Add(this.TxtTrabajador);
            this.Pnl01.Controls.Add(this.CmbEncargado);
            this.Pnl01.Controls.Add(this.CmbColaborador);
            this.Pnl01.Controls.Add(this.pictureBox11);
            this.Pnl01.Controls.Add(this.pictureBox10);
            this.Pnl01.Controls.Add(this.pictureBox9);
            this.Pnl01.Controls.Add(this.PibEncargado);
            this.Pnl01.Controls.Add(this.PibColaborador);
            this.Pnl01.Controls.Add(this.label7);
            this.Pnl01.Controls.Add(this.pictureBox8);
            this.Pnl01.Location = new System.Drawing.Point(17, -2);
            this.Pnl01.Name = "Pnl01";
            this.Pnl01.Size = new System.Drawing.Size(700, 194);
            this.Pnl01.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(345, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nacionalidad:";
            // 
            // CmbNacionalidad
            // 
            this.CmbNacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbNacionalidad.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.CmbNacionalidad.ForeColor = System.Drawing.Color.Tomato;
            this.CmbNacionalidad.FormattingEnabled = true;
            this.CmbNacionalidad.Location = new System.Drawing.Point(445, 145);
            this.CmbNacionalidad.Name = "CmbNacionalidad";
            this.CmbNacionalidad.Size = new System.Drawing.Size(192, 23);
            this.CmbNacionalidad.TabIndex = 15;
            this.CmbNacionalidad.Text = "Seleccionar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PRESENTACION.Properties.Resources.ComboBox05;
            this.pictureBox1.Location = new System.Drawing.Point(341, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 30);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // LblVoluntario
            // 
            this.LblVoluntario.AutoSize = true;
            this.LblVoluntario.BackColor = System.Drawing.Color.White;
            this.LblVoluntario.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.LblVoluntario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.LblVoluntario.Location = new System.Drawing.Point(118, 58);
            this.LblVoluntario.Name = "LblVoluntario";
            this.LblVoluntario.Size = new System.Drawing.Size(40, 15);
            this.LblVoluntario.TabIndex = 13;
            this.LblVoluntario.Text = "label1";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = global::PRESENTACION.Properties.Resources.ComboBox05;
            this.pictureBox11.Location = new System.Drawing.Point(17, 145);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(310, 30);
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::PRESENTACION.Properties.Resources.ComboBox05;
            this.pictureBox10.Location = new System.Drawing.Point(18, 87);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(310, 30);
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::PRESENTACION.Properties.Resources.ComboBox06;
            this.pictureBox9.Location = new System.Drawing.Point(17, 50);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(310, 30);
            this.pictureBox9.TabIndex = 11;
            this.pictureBox9.TabStop = false;
            // 
            // PibEncargado
            // 
            this.PibEncargado.BackColor = System.Drawing.Color.Transparent;
            this.PibEncargado.Location = new System.Drawing.Point(521, 159);
            this.PibEncargado.Name = "PibEncargado";
            this.PibEncargado.Size = new System.Drawing.Size(24, 24);
            this.PibEncargado.TabIndex = 4;
            this.PibEncargado.TabStop = false;
            // 
            // PibColaborador
            // 
            this.PibColaborador.BackColor = System.Drawing.Color.Transparent;
            this.PibColaborador.Location = new System.Drawing.Point(522, 98);
            this.PibColaborador.Name = "PibColaborador";
            this.PibColaborador.Size = new System.Drawing.Size(24, 24);
            this.PibColaborador.TabIndex = 4;
            this.PibColaborador.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(187)))));
            this.label7.Location = new System.Drawing.Point(72, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "PERSONAL ENCARGADO";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::PRESENTACION.Properties.Resources.Forma02;
            this.pictureBox8.Location = new System.Drawing.Point(570, 7);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(340, 176);
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox6_Click);
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
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column2});
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
            this.DgvSalida.Location = new System.Drawing.Point(34, 198);
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
            this.DgvSalida.Size = new System.Drawing.Size(529, 283);
            this.DgvSalida.TabIndex = 9;
            this.DgvSalida.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSalida_CellClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Código";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            this.Column4.Width = 71;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Descripción";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 95;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cantidad";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 79;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Almacén";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 78;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Present.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 73;
            // 
            // PibGuardarImprimir
            // 
            this.PibGuardarImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PibGuardarImprimir.Image = global::PRESENTACION.Properties.Resources.BotonFormConfirmarImprimir01;
            this.PibGuardarImprimir.Location = new System.Drawing.Point(587, 337);
            this.PibGuardarImprimir.Name = "PibGuardarImprimir";
            this.PibGuardarImprimir.Size = new System.Drawing.Size(110, 40);
            this.PibGuardarImprimir.TabIndex = 7;
            this.PibGuardarImprimir.TabStop = false;
            this.PibGuardarImprimir.Click += new System.EventHandler(this.PibGuardarImprimir_Click);
            this.PibGuardarImprimir.MouseEnter += new System.EventHandler(this.PibGuardarImprimir_MouseEnter);
            this.PibGuardarImprimir.MouseLeave += new System.EventHandler(this.PibGuardarImprimir_MouseLeave);
            // 
            // PibLimpiar
            // 
            this.PibLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PibLimpiar.Image = global::PRESENTACION.Properties.Resources.BotonFormLimpiar03;
            this.PibLimpiar.Location = new System.Drawing.Point(587, 428);
            this.PibLimpiar.Name = "PibLimpiar";
            this.PibLimpiar.Size = new System.Drawing.Size(110, 40);
            this.PibLimpiar.TabIndex = 6;
            this.PibLimpiar.TabStop = false;
            this.PibLimpiar.Click += new System.EventHandler(this.PibLimpiar_Click);
            this.PibLimpiar.MouseEnter += new System.EventHandler(this.PibLimpiar_MouseEnter);
            this.PibLimpiar.MouseLeave += new System.EventHandler(this.PibLimpiar_MouseLeave);
            // 
            // PibConfirmar
            // 
            this.PibConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PibConfirmar.Image = global::PRESENTACION.Properties.Resources.BotonFormConfirmarSalida08;
            this.PibConfirmar.Location = new System.Drawing.Point(587, 262);
            this.PibConfirmar.Name = "PibConfirmar";
            this.PibConfirmar.Size = new System.Drawing.Size(110, 60);
            this.PibConfirmar.TabIndex = 4;
            this.PibConfirmar.TabStop = false;
            this.PibConfirmar.Click += new System.EventHandler(this.PibConfirmar_Click);
            this.PibConfirmar.MouseEnter += new System.EventHandler(this.PibConfirmar_MouseEnter);
            this.PibConfirmar.MouseLeave += new System.EventHandler(this.PibConfirmar_MouseLeave);
            // 
            // PibEliminarMed
            // 
            this.PibEliminarMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PibEliminarMed.Image = global::PRESENTACION.Properties.Resources.BotonFormAgregarQuitar03;
            this.PibEliminarMed.Location = new System.Drawing.Point(587, 383);
            this.PibEliminarMed.Name = "PibEliminarMed";
            this.PibEliminarMed.Size = new System.Drawing.Size(110, 40);
            this.PibEliminarMed.TabIndex = 5;
            this.PibEliminarMed.TabStop = false;
            this.PibEliminarMed.Click += new System.EventHandler(this.PibEliminarMed_Click);
            this.PibEliminarMed.MouseEnter += new System.EventHandler(this.PibEliminarMed_MouseEnter);
            this.PibEliminarMed.MouseLeave += new System.EventHandler(this.PibEliminarMed_MouseLeave);
            // 
            // PibAgregarMed
            // 
            this.PibAgregarMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PibAgregarMed.Image = global::PRESENTACION.Properties.Resources.BotonFormSeleccionarMed03;
            this.PibAgregarMed.Location = new System.Drawing.Point(587, 209);
            this.PibAgregarMed.Name = "PibAgregarMed";
            this.PibAgregarMed.Size = new System.Drawing.Size(110, 40);
            this.PibAgregarMed.TabIndex = 4;
            this.PibAgregarMed.TabStop = false;
            this.PibAgregarMed.Click += new System.EventHandler(this.PibAgregarMed_Click);
            this.PibAgregarMed.MouseEnter += new System.EventHandler(this.PibAgregarMed_MouseEnter);
            this.PibAgregarMed.MouseLeave += new System.EventHandler(this.PibAgregarMed_MouseLeave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormSalidaMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(727, 502);
            this.Controls.Add(this.DgvSalida);
            this.Controls.Add(this.Pnl01);
            this.Controls.Add(this.PibGuardarImprimir);
            this.Controls.Add(this.PibLimpiar);
            this.Controls.Add(this.PibConfirmar);
            this.Controls.Add(this.PibEliminarMed);
            this.Controls.Add(this.PibAgregarMed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSalidaMedicamentos";
            this.Text = "FormSalidaMedicamentos";
            this.Load += new System.EventHandler(this.FormSalidaMedicamentos_Load);
            this.Pnl01.ResumeLayout(false);
            this.Pnl01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibEncargado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibColaborador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibGuardarImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibConfirmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibEliminarMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibAgregarMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbEncargado;
        private System.Windows.Forms.TextBox TxtTrabajador;
        private System.Windows.Forms.Label LblTrabajador;
        private System.Windows.Forms.Label LblEncargado;
        private System.Windows.Forms.PictureBox PibAgregarMed;
        private System.Windows.Forms.PictureBox PibEliminarMed;
        private System.Windows.Forms.PictureBox PibLimpiar;
        private System.Windows.Forms.PictureBox PibGuardarImprimir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbColaborador;
        private System.Windows.Forms.Panel Pnl01;
        private System.Windows.Forms.PictureBox PibEncargado;
        private System.Windows.Forms.PictureBox PibColaborador;
        public System.Windows.Forms.DataGridView DgvSalida;
        public System.Windows.Forms.PictureBox PibConfirmar;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LblVoluntario;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbNacionalidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}