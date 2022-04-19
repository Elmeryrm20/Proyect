
namespace PRESENTACION
{
    partial class FormAgregarMedicamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LblMuestra1 = new System.Windows.Forms.Label();
            this.cmbLab = new System.Windows.Forms.ComboBox();
            this.CmbPresentacion = new System.Windows.Forms.ComboBox();
            this.cmbCaja = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.textGramaje = new System.Windows.Forms.TextBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CmbPertenencia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblEncargado = new System.Windows.Forms.Label();
            this.CmbEncargado = new System.Windows.Forms.ComboBox();
            this.CmbColaborador = new System.Windows.Forms.ComboBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.PibAgregarPertenencia = new System.Windows.Forms.PictureBox();
            this.PibImagen = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PibAgregarAlmacen = new System.Windows.Forms.PictureBox();
            this.Pib_Agregar_Lab = new System.Windows.Forms.PictureBox();
            this.PibAgregarMedicamento = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dtFecha_Vencimiento = new PRESENTACION.SelectorDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibAgregarPertenencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibAgregarAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pib_Agregar_Lab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibAgregarMedicamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "AÑADIR MEDICAMENTO";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LblMuestra1
            // 
            this.LblMuestra1.AutoSize = true;
            this.LblMuestra1.ForeColor = System.Drawing.Color.Red;
            this.LblMuestra1.Location = new System.Drawing.Point(622, 42);
            this.LblMuestra1.Name = "LblMuestra1";
            this.LblMuestra1.Size = new System.Drawing.Size(54, 13);
            this.LblMuestra1.TabIndex = 26;
            this.LblMuestra1.Text = "Muestra 1";
            this.LblMuestra1.Visible = false;
            this.LblMuestra1.Click += new System.EventHandler(this.LblMuestra1_Click);
            // 
            // cmbLab
            // 
            this.cmbLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Location = new System.Drawing.Point(193, 193);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.Size = new System.Drawing.Size(130, 21);
            this.cmbLab.TabIndex = 3;
            this.cmbLab.Text = "Seleccionar";
            this.cmbLab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbLab_KeyPress);
            this.cmbLab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmbLab_MouseDown);
            // 
            // CmbPresentacion
            // 
            this.CmbPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.CmbPresentacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.CmbPresentacion.FormattingEnabled = true;
            this.CmbPresentacion.Location = new System.Drawing.Point(195, 381);
            this.CmbPresentacion.Name = "CmbPresentacion";
            this.CmbPresentacion.Size = new System.Drawing.Size(130, 21);
            this.CmbPresentacion.TabIndex = 9;
            this.CmbPresentacion.Text = "Seleccionar";
            this.CmbPresentacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPresentacion_KeyPress);
            // 
            // cmbCaja
            // 
            this.cmbCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.cmbCaja.FormattingEnabled = true;
            this.cmbCaja.Location = new System.Drawing.Point(194, 424);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Size = new System.Drawing.Size(130, 21);
            this.cmbCaja.TabIndex = 10;
            this.cmbCaja.Text = "Seleccionar";
            this.cmbCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCaja_KeyPress);
            this.cmbCaja.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmbCaja_MouseDown);
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(193, 338);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(130, 21);
            this.cmbTipo.TabIndex = 8;
            this.cmbTipo.Text = "Seleccionar";
            this.cmbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipo_KeyPress);
            // 
            // textGramaje
            // 
            this.textGramaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.textGramaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textGramaje.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.textGramaje.ForeColor = System.Drawing.Color.White;
            this.textGramaje.Location = new System.Drawing.Point(117, 297);
            this.textGramaje.Name = "textGramaje";
            this.textGramaje.Size = new System.Drawing.Size(194, 16);
            this.textGramaje.TabIndex = 7;
            this.textGramaje.Text = "Gramaje";
            this.textGramaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textGramaje.Click += new System.EventHandler(this.textGramaje_Click);
            this.textGramaje.Leave += new System.EventHandler(this.textGramaje_Leave);
            // 
            // textCantidad
            // 
            this.textCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.textCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.textCantidad.ForeColor = System.Drawing.Color.White;
            this.textCantidad.Location = new System.Drawing.Point(117, 152);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(194, 16);
            this.textCantidad.TabIndex = 2;
            this.textCantidad.Text = "Cantidad";
            this.textCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCantidad.Click += new System.EventHandler(this.textCantidad_Click);
            this.textCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCantidad_KeyPress);
            this.textCantidad.Leave += new System.EventHandler(this.textCantidad_Leave);
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.ForeColor = System.Drawing.Color.White;
            this.textNombre.Location = new System.Drawing.Point(117, 109);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(194, 16);
            this.textNombre.TabIndex = 1;
            this.textNombre.Text = "Nombre";
            this.textNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNombre.Click += new System.EventHandler(this.textNombre_Click);
            this.textNombre.Leave += new System.EventHandler(this.textNombre_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(476, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Subir una Imagen:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(113, 426);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "Almacén:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(140, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Para:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(142, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(142, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Fecha de vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(105, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Laboratorio:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // CmbPertenencia
            // 
            this.CmbPertenencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbPertenencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.CmbPertenencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.CmbPertenencia.FormattingEnabled = true;
            this.CmbPertenencia.Location = new System.Drawing.Point(193, 469);
            this.CmbPertenencia.Name = "CmbPertenencia";
            this.CmbPertenencia.Size = new System.Drawing.Size(130, 21);
            this.CmbPertenencia.TabIndex = 52;
            this.CmbPertenencia.Text = "Seleccionar";
            this.CmbPertenencia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CmbPertenencia_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Pertenencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(385, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Colaborador:";
            // 
            // LblEncargado
            // 
            this.LblEncargado.AutoSize = true;
            this.LblEncargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.LblEncargado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEncargado.ForeColor = System.Drawing.Color.White;
            this.LblEncargado.Location = new System.Drawing.Point(386, 126);
            this.LblEncargado.Name = "LblEncargado";
            this.LblEncargado.Size = new System.Drawing.Size(85, 16);
            this.LblEncargado.TabIndex = 57;
            this.LblEncargado.Text = "Coordinador:";
            // 
            // CmbEncargado
            // 
            this.CmbEncargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbEncargado.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.CmbEncargado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.CmbEncargado.FormattingEnabled = true;
            this.CmbEncargado.Location = new System.Drawing.Point(484, 122);
            this.CmbEncargado.Name = "CmbEncargado";
            this.CmbEncargado.Size = new System.Drawing.Size(192, 23);
            this.CmbEncargado.TabIndex = 59;
            this.CmbEncargado.Text = "Seleccionar:";
            // 
            // CmbColaborador
            // 
            this.CmbColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbColaborador.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.CmbColaborador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.CmbColaborador.FormattingEnabled = true;
            this.CmbColaborador.Location = new System.Drawing.Point(484, 88);
            this.CmbColaborador.Name = "CmbColaborador";
            this.CmbColaborador.Size = new System.Drawing.Size(192, 23);
            this.CmbColaborador.TabIndex = 58;
            this.CmbColaborador.Text = "Seleccionar";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = global::PRESENTACION.Properties.Resources.ComboBox07;
            this.pictureBox11.Location = new System.Drawing.Point(380, 120);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(310, 30);
            this.pictureBox11.TabIndex = 60;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = global::PRESENTACION.Properties.Resources.ComboBox07;
            this.pictureBox12.Location = new System.Drawing.Point(381, 86);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(310, 30);
            this.pictureBox12.TabIndex = 61;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::PRESENTACION.Properties.Resources.ComboBox04;
            this.pictureBox10.Location = new System.Drawing.Point(98, 464);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(230, 30);
            this.pictureBox10.TabIndex = 55;
            this.pictureBox10.TabStop = false;
            // 
            // PibAgregarPertenencia
            // 
            this.PibAgregarPertenencia.Image = global::PRESENTACION.Properties.Resources.BotonFormAgregarNuevo01;
            this.PibAgregarPertenencia.Location = new System.Drawing.Point(341, 467);
            this.PibAgregarPertenencia.Name = "PibAgregarPertenencia";
            this.PibAgregarPertenencia.Size = new System.Drawing.Size(24, 24);
            this.PibAgregarPertenencia.TabIndex = 54;
            this.PibAgregarPertenencia.TabStop = false;
            this.PibAgregarPertenencia.Click += new System.EventHandler(this.PibAgregarPertenencia_Click);
            // 
            // PibImagen
            // 
            this.PibImagen.BackColor = System.Drawing.Color.White;
            this.PibImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PibImagen.Image = global::PRESENTACION.Properties.Resources.Imagen01;
            this.PibImagen.Location = new System.Drawing.Point(463, 224);
            this.PibImagen.Name = "PibImagen";
            this.PibImagen.Size = new System.Drawing.Size(150, 150);
            this.PibImagen.TabIndex = 44;
            this.PibImagen.TabStop = false;
            this.PibImagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::PRESENTACION.Properties.Resources.ImagenMarco01;
            this.pictureBox9.Location = new System.Drawing.Point(460, 177);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(156, 200);
            this.pictureBox9.TabIndex = 51;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::PRESENTACION.Properties.Resources.ComboBox04;
            this.pictureBox8.Location = new System.Drawing.Point(99, 419);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(230, 30);
            this.pictureBox8.TabIndex = 50;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::PRESENTACION.Properties.Resources.ComboBox04;
            this.pictureBox7.Location = new System.Drawing.Point(99, 376);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(230, 30);
            this.pictureBox7.TabIndex = 50;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::PRESENTACION.Properties.Resources.ComboBox04;
            this.pictureBox6.Location = new System.Drawing.Point(99, 333);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(230, 30);
            this.pictureBox6.TabIndex = 50;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PRESENTACION.Properties.Resources.ComboBox04;
            this.pictureBox2.Location = new System.Drawing.Point(99, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 30);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::PRESENTACION.Properties.Resources.TimePicker02;
            this.pictureBox4.Location = new System.Drawing.Point(98, 231);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(232, 46);
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::PRESENTACION.Properties.Resources.TextBox03;
            this.pictureBox3.Location = new System.Drawing.Point(99, 145);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(230, 30);
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PRESENTACION.Properties.Resources.TextBox03;
            this.pictureBox1.Location = new System.Drawing.Point(99, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 30);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // PibAgregarAlmacen
            // 
            this.PibAgregarAlmacen.Image = global::PRESENTACION.Properties.Resources.BotonFormAgregarNuevo01;
            this.PibAgregarAlmacen.Location = new System.Drawing.Point(342, 422);
            this.PibAgregarAlmacen.Name = "PibAgregarAlmacen";
            this.PibAgregarAlmacen.Size = new System.Drawing.Size(24, 24);
            this.PibAgregarAlmacen.TabIndex = 49;
            this.PibAgregarAlmacen.TabStop = false;
            this.PibAgregarAlmacen.Click += new System.EventHandler(this.PibAgregarAlmacen_Click);
            // 
            // Pib_Agregar_Lab
            // 
            this.Pib_Agregar_Lab.BackColor = System.Drawing.Color.Transparent;
            this.Pib_Agregar_Lab.Image = global::PRESENTACION.Properties.Resources.BotonFormAgregarNuevo01;
            this.Pib_Agregar_Lab.Location = new System.Drawing.Point(342, 191);
            this.Pib_Agregar_Lab.Name = "Pib_Agregar_Lab";
            this.Pib_Agregar_Lab.Size = new System.Drawing.Size(24, 24);
            this.Pib_Agregar_Lab.TabIndex = 48;
            this.Pib_Agregar_Lab.TabStop = false;
            this.Pib_Agregar_Lab.Click += new System.EventHandler(this.bnt_Agregar_Lab_Click);
            // 
            // PibAgregarMedicamento
            // 
            this.PibAgregarMedicamento.BackColor = System.Drawing.Color.Transparent;
            this.PibAgregarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PibAgregarMedicamento.Image = global::PRESENTACION.Properties.Resources.BotonFormNuevoMedicamentos05;
            this.PibAgregarMedicamento.Location = new System.Drawing.Point(483, 399);
            this.PibAgregarMedicamento.Name = "PibAgregarMedicamento";
            this.PibAgregarMedicamento.Size = new System.Drawing.Size(110, 60);
            this.PibAgregarMedicamento.TabIndex = 45;
            this.PibAgregarMedicamento.TabStop = false;
            this.PibAgregarMedicamento.Click += new System.EventHandler(this.pictureBox2_Click);
            this.PibAgregarMedicamento.MouseEnter += new System.EventHandler(this.PibAgregarMedicamento_MouseEnter);
            this.PibAgregarMedicamento.MouseLeave += new System.EventHandler(this.PibAgregarMedicamento_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::PRESENTACION.Properties.Resources.TextBox03;
            this.pictureBox5.Location = new System.Drawing.Point(99, 290);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(230, 30);
            this.pictureBox5.TabIndex = 50;
            this.pictureBox5.TabStop = false;
            // 
            // dtFecha_Vencimiento
            // 
            this.dtFecha_Vencimiento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.dtFecha_Vencimiento.BorderSize = 0;
            this.dtFecha_Vencimiento.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.dtFecha_Vencimiento.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtFecha_Vencimiento.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.dtFecha_Vencimiento.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtFecha_Vencimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha_Vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha_Vencimiento.Location = new System.Drawing.Point(140, 253);
            this.dtFecha_Vencimiento.MinimumSize = new System.Drawing.Size(4, 20);
            this.dtFecha_Vencimiento.Name = "dtFecha_Vencimiento";
            this.dtFecha_Vencimiento.Size = new System.Drawing.Size(147, 23);
            this.dtFecha_Vencimiento.SkinColor = System.Drawing.Color.White;
            this.dtFecha_Vencimiento.TabIndex = 62;
            this.dtFecha_Vencimiento.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            // 
            // FormAgregarMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(720, 502);
            this.Controls.Add(this.dtFecha_Vencimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblEncargado);
            this.Controls.Add(this.CmbEncargado);
            this.Controls.Add(this.CmbColaborador);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.CmbPertenencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.PibAgregarPertenencia);
            this.Controls.Add(this.PibImagen);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.CmbPresentacion);
            this.Controls.Add(this.cmbCaja);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.cmbLab);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PibAgregarAlmacen);
            this.Controls.Add(this.LblMuestra1);
            this.Controls.Add(this.Pib_Agregar_Lab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textGramaje);
            this.Controls.Add(this.PibAgregarMedicamento);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgregarMedicamento";
            this.Text = "FormAgregarMedicamento";
            this.Load += new System.EventHandler(this.FormAgregarMedicamento_Load);
            this.SizeChanged += new System.EventHandler(this.FormAgregarMedicamento_SizeChanged);
            this.Resize += new System.EventHandler(this.FormAgregarMedicamento_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibAgregarPertenencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibAgregarAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pib_Agregar_Lab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibAgregarMedicamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LblMuestra1;
        private System.Windows.Forms.PictureBox Pib_Agregar_Lab;
        private System.Windows.Forms.ComboBox cmbLab;
        private System.Windows.Forms.ComboBox CmbPresentacion;
        private System.Windows.Forms.ComboBox cmbCaja;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox textGramaje;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox PibAgregarMedicamento;
        private System.Windows.Forms.PictureBox PibImagen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox PibAgregarAlmacen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.ComboBox CmbPertenencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox PibAgregarPertenencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblEncargado;
        private System.Windows.Forms.ComboBox CmbEncargado;
        private System.Windows.Forms.ComboBox CmbColaborador;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private SelectorDatePicker dtFecha_Vencimiento;
    }
}