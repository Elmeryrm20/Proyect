
namespace PRESENTACION
{
    partial class FormMedicamentos
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
            this.txb_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChbColores = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblIndice = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblResultados = new System.Windows.Forms.Label();
            this.cmb_Almacen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pib_Filtrar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Informe = new System.Windows.Forms.PictureBox();
            this.PibEditar = new System.Windows.Forms.PictureBox();
            this.PibSalida = new System.Windows.Forms.PictureBox();
            this.PibIngreso = new System.Windows.Forms.PictureBox();
            this.PibActualizar = new System.Windows.Forms.PictureBox();
            this.PibDetalles = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgb_Medicamentos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pib_Filtrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Informe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibDetalles)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Medicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_Buscar
            // 
            this.txb_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.txb_Buscar.Location = new System.Drawing.Point(73, 54);
            this.txb_Buscar.MaxLength = 50;
            this.txb_Buscar.Name = "txb_Buscar";
            this.txb_Buscar.Size = new System.Drawing.Size(251, 16);
            this.txb_Buscar.TabIndex = 1;
            this.txb_Buscar.Text = "Buscar Medicamento";
            this.txb_Buscar.Click += new System.EventHandler(this.txb_Buscar_Click);
            this.txb_Buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(70, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "INVENTARIO  DE MEDICAMENTOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.ChbColores);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblIndice);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txb_Buscar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LblResultados);
            this.panel1.Controls.Add(this.cmb_Almacen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Pib_Filtrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 114);
            this.panel1.TabIndex = 7;
            // 
            // ChbColores
            // 
            this.ChbColores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChbColores.AutoSize = true;
            this.ChbColores.BackColor = System.Drawing.Color.Transparent;
            this.ChbColores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChbColores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ChbColores.Location = new System.Drawing.Point(413, 90);
            this.ChbColores.Name = "ChbColores";
            this.ChbColores.Size = new System.Drawing.Size(124, 17);
            this.ChbColores.TabIndex = 16;
            this.ChbColores.Text = "Existencia en Colores";
            this.ChbColores.UseVisualStyleBackColor = false;
            this.ChbColores.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(388, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Present.:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(384, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Almacén:";
            // 
            // LblIndice
            // 
            this.LblIndice.AutoSize = true;
            this.LblIndice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIndice.Location = new System.Drawing.Point(31, 80);
            this.LblIndice.Name = "LblIndice";
            this.LblIndice.Size = new System.Drawing.Size(53, 18);
            this.LblIndice.TabIndex = 6;
            this.LblIndice.Text = "Indice";
            this.LblIndice.Visible = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipo.BackColor = System.Drawing.Color.White;
            this.cmbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(449, 22);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(137, 23);
            this.cmbTipo.TabIndex = 8;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            this.cmbTipo.Click += new System.EventHandler(this.cmbTipo_Click);
            this.cmbTipo.Enter += new System.EventHandler(this.cmbTipo_Enter);
            this.cmbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Almacen_KeyPress);
            this.cmbTipo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmbTipo_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PRESENTACION.Properties.Resources.ComboBox02;
            this.pictureBox2.Location = new System.Drawing.Point(383, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 30);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PRESENTACION.Properties.Resources.TextBox01;
            this.pictureBox1.Location = new System.Drawing.Point(30, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 30);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // LblResultados
            // 
            this.LblResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblResultados.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultados.ForeColor = System.Drawing.Color.Red;
            this.LblResultados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblResultados.Location = new System.Drawing.Point(599, 69);
            this.LblResultados.Name = "LblResultados";
            this.LblResultados.Size = new System.Drawing.Size(126, 38);
            this.LblResultados.TabIndex = 13;
            this.LblResultados.Text = "No ha seleccionado";
            this.LblResultados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblResultados.Visible = false;
            // 
            // cmb_Almacen
            // 
            this.cmb_Almacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Almacen.BackColor = System.Drawing.Color.White;
            this.cmb_Almacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_Almacen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Almacen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Almacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.cmb_Almacen.FormattingEnabled = true;
            this.cmb_Almacen.Location = new System.Drawing.Point(449, 58);
            this.cmb_Almacen.Name = "cmb_Almacen";
            this.cmb_Almacen.Size = new System.Drawing.Size(137, 23);
            this.cmb_Almacen.TabIndex = 12;
            this.cmb_Almacen.TabIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            this.cmb_Almacen.Click += new System.EventHandler(this.cmb_Almacen_Click);
            this.cmb_Almacen.Enter += new System.EventHandler(this.cmb_Almacen_Enter);
            this.cmb_Almacen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Almacen_KeyPress);
            this.cmb_Almacen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmb_Almacen_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // Pib_Filtrar
            // 
            this.Pib_Filtrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pib_Filtrar.BackColor = System.Drawing.Color.Transparent;
            this.Pib_Filtrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pib_Filtrar.Image = global::PRESENTACION.Properties.Resources.BotonFormFiltrar01;
            this.Pib_Filtrar.Location = new System.Drawing.Point(603, 26);
            this.Pib_Filtrar.Name = "Pib_Filtrar";
            this.Pib_Filtrar.Size = new System.Drawing.Size(110, 40);
            this.Pib_Filtrar.TabIndex = 9;
            this.Pib_Filtrar.TabStop = false;
            this.Pib_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            this.Pib_Filtrar.MouseEnter += new System.EventHandler(this.Pib_Filtrar_MouseEnter);
            this.Pib_Filtrar.MouseLeave += new System.EventHandler(this.Pib_Filtrar_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::PRESENTACION.Properties.Resources.ComboBox02;
            this.pictureBox3.Location = new System.Drawing.Point(383, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(210, 30);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.panel3.Controls.Add(this.btn_Informe);
            this.panel3.Controls.Add(this.PibEditar);
            this.panel3.Controls.Add(this.PibSalida);
            this.panel3.Controls.Add(this.PibIngreso);
            this.panel3.Controls.Add(this.PibActualizar);
            this.panel3.Controls.Add(this.PibDetalles);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 63);
            this.panel3.TabIndex = 9;
            // 
            // btn_Informe
            // 
            this.btn_Informe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Informe.BackColor = System.Drawing.Color.Transparent;
            this.btn_Informe.Image = global::PRESENTACION.Properties.Resources.BotonFormInforme01;
            this.btn_Informe.Location = new System.Drawing.Point(584, 6);
            this.btn_Informe.Name = "btn_Informe";
            this.btn_Informe.Size = new System.Drawing.Size(110, 40);
            this.btn_Informe.TabIndex = 8;
            this.btn_Informe.TabStop = false;
            this.btn_Informe.Click += new System.EventHandler(this.btn_Informe_Click);
            // 
            // PibEditar
            // 
            this.PibEditar.BackColor = System.Drawing.Color.Transparent;
            this.PibEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PibEditar.Image = global::PRESENTACION.Properties.Resources.BotonFormEditar01;
            this.PibEditar.Location = new System.Drawing.Point(352, 6);
            this.PibEditar.Name = "PibEditar";
            this.PibEditar.Size = new System.Drawing.Size(110, 40);
            this.PibEditar.TabIndex = 7;
            this.PibEditar.TabStop = false;
            this.PibEditar.Click += new System.EventHandler(this.pictureBox2_Click);
            this.PibEditar.MouseEnter += new System.EventHandler(this.PibEditar_MouseEnter);
            this.PibEditar.MouseLeave += new System.EventHandler(this.PibEditar_MouseLeave);
            // 
            // PibSalida
            // 
            this.PibSalida.BackColor = System.Drawing.Color.Transparent;
            this.PibSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PibSalida.Image = global::PRESENTACION.Properties.Resources.BotonFormSalida01;
            this.PibSalida.Location = new System.Drawing.Point(236, 6);
            this.PibSalida.Name = "PibSalida";
            this.PibSalida.Size = new System.Drawing.Size(110, 40);
            this.PibSalida.TabIndex = 5;
            this.PibSalida.TabStop = false;
            this.PibSalida.Click += new System.EventHandler(this.pictureBox4_Click);
            this.PibSalida.MouseEnter += new System.EventHandler(this.PibSalida_MouseEnter);
            this.PibSalida.MouseLeave += new System.EventHandler(this.PibSalida_MouseLeave);
            // 
            // PibIngreso
            // 
            this.PibIngreso.BackColor = System.Drawing.Color.Transparent;
            this.PibIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PibIngreso.Image = global::PRESENTACION.Properties.Resources.BotonFormIngreso01;
            this.PibIngreso.Location = new System.Drawing.Point(120, 6);
            this.PibIngreso.Name = "PibIngreso";
            this.PibIngreso.Size = new System.Drawing.Size(110, 40);
            this.PibIngreso.TabIndex = 4;
            this.PibIngreso.TabStop = false;
            this.PibIngreso.Click += new System.EventHandler(this.pictureBox3_Click);
            this.PibIngreso.MouseEnter += new System.EventHandler(this.PibIngreso_MouseEnter);
            this.PibIngreso.MouseLeave += new System.EventHandler(this.PibIngreso_MouseLeave);
            // 
            // PibActualizar
            // 
            this.PibActualizar.BackColor = System.Drawing.Color.Transparent;
            this.PibActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PibActualizar.Image = global::PRESENTACION.Properties.Resources.BotonFormActualizar01;
            this.PibActualizar.Location = new System.Drawing.Point(468, 6);
            this.PibActualizar.Name = "PibActualizar";
            this.PibActualizar.Size = new System.Drawing.Size(110, 40);
            this.PibActualizar.TabIndex = 2;
            this.PibActualizar.TabStop = false;
            this.PibActualizar.Click += new System.EventHandler(this.pictureBox1_Click);
            this.PibActualizar.MouseEnter += new System.EventHandler(this.PibActualizar_MouseEnter);
            this.PibActualizar.MouseLeave += new System.EventHandler(this.PibActualizar_MouseLeave);
            // 
            // PibDetalles
            // 
            this.PibDetalles.BackColor = System.Drawing.Color.Transparent;
            this.PibDetalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PibDetalles.Image = global::PRESENTACION.Properties.Resources.BotonFormDetalles01;
            this.PibDetalles.Location = new System.Drawing.Point(4, 6);
            this.PibDetalles.Name = "PibDetalles";
            this.PibDetalles.Size = new System.Drawing.Size(110, 40);
            this.PibDetalles.TabIndex = 3;
            this.PibDetalles.TabStop = false;
            this.PibDetalles.Click += new System.EventHandler(this.btn_Detalles_Click);
            this.PibDetalles.MouseEnter += new System.EventHandler(this.PibDetalles_MouseEnter);
            this.PibDetalles.MouseLeave += new System.EventHandler(this.PibDetalles_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 242);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(694, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(34, 242);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgb_Medicamentos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(34, 114);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(660, 242);
            this.panel5.TabIndex = 12;
            // 
            // dgb_Medicamentos
            // 
            this.dgb_Medicamentos.AllowUserToAddRows = false;
            this.dgb_Medicamentos.AllowUserToDeleteRows = false;
            this.dgb_Medicamentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgb_Medicamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgb_Medicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgb_Medicamentos.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgb_Medicamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgb_Medicamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgb_Medicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgb_Medicamentos.ColumnHeadersHeight = 25;
            this.dgb_Medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgb_Medicamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgb_Medicamentos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgb_Medicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgb_Medicamentos.EnableHeadersVisualStyles = false;
            this.dgb_Medicamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.dgb_Medicamentos.Location = new System.Drawing.Point(0, 0);
            this.dgb_Medicamentos.MultiSelect = false;
            this.dgb_Medicamentos.Name = "dgb_Medicamentos";
            this.dgb_Medicamentos.ReadOnly = true;
            this.dgb_Medicamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgb_Medicamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgb_Medicamentos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.dgb_Medicamentos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgb_Medicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgb_Medicamentos.Size = new System.Drawing.Size(660, 242);
            this.dgb_Medicamentos.TabIndex = 2;
            this.dgb_Medicamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_Medicamentos_CellClick);
            this.dgb_Medicamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_Medicamentos_CellDoubleClick);
            this.dgb_Medicamentos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgb_Medicamentos_CellFormatting);
            this.dgb_Medicamentos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgb_Medicamentos_ColumnHeaderMouseClick);
            // 
            // FormMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(728, 419);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMedicamentos";
            this.Text = "FormMedicamentos";
            this.Load += new System.EventHandler(this.FormMedicamentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pib_Filtrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Informe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibDetalles)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Medicamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txb_Buscar;
        private System.Windows.Forms.PictureBox PibActualizar;
        private System.Windows.Forms.PictureBox PibDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblIndice;
        private System.Windows.Forms.PictureBox PibEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Pib_Filtrar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Almacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblResultados;
        public System.Windows.Forms.DataGridView dgb_Medicamentos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox PibSalida;
        public System.Windows.Forms.PictureBox PibIngreso;
        private System.Windows.Forms.CheckBox ChbColores;
        private System.Windows.Forms.PictureBox btn_Informe;
    }
}