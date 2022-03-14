
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
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LblMuestra1 = new System.Windows.Forms.Label();
            this.gpbAgregar_Producto = new System.Windows.Forms.GroupBox();
            this.bnt_Agregar_Lab = new System.Windows.Forms.PictureBox();
            this.cmbLab = new System.Windows.Forms.ComboBox();
            this.CmbPresentacion = new System.Windows.Forms.ComboBox();
            this.dtFecha_Vencimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbCaja = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.textGramaje = new System.Windows.Forms.TextBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbAgregar_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Agregar_Lab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Producto";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LblMuestra1
            // 
            this.LblMuestra1.AutoSize = true;
            this.LblMuestra1.ForeColor = System.Drawing.Color.Red;
            this.LblMuestra1.Location = new System.Drawing.Point(296, 48);
            this.LblMuestra1.Name = "LblMuestra1";
            this.LblMuestra1.Size = new System.Drawing.Size(54, 13);
            this.LblMuestra1.TabIndex = 26;
            this.LblMuestra1.Text = "Muestra 1";
            this.LblMuestra1.Click += new System.EventHandler(this.LblMuestra1_Click);
            // 
            // gpbAgregar_Producto
            // 
            this.gpbAgregar_Producto.Controls.Add(this.bnt_Agregar_Lab);
            this.gpbAgregar_Producto.Controls.Add(this.cmbLab);
            this.gpbAgregar_Producto.Controls.Add(this.CmbPresentacion);
            this.gpbAgregar_Producto.Controls.Add(this.dtFecha_Vencimiento);
            this.gpbAgregar_Producto.Controls.Add(this.cmbCaja);
            this.gpbAgregar_Producto.Controls.Add(this.cmbTipo);
            this.gpbAgregar_Producto.Controls.Add(this.textGramaje);
            this.gpbAgregar_Producto.Controls.Add(this.textCantidad);
            this.gpbAgregar_Producto.Controls.Add(this.textNombre);
            this.gpbAgregar_Producto.Controls.Add(this.label12);
            this.gpbAgregar_Producto.Controls.Add(this.pictureBox2);
            this.gpbAgregar_Producto.Controls.Add(this.pictureBox1);
            this.gpbAgregar_Producto.Controls.Add(this.label11);
            this.gpbAgregar_Producto.Controls.Add(this.label9);
            this.gpbAgregar_Producto.Controls.Add(this.label8);
            this.gpbAgregar_Producto.Controls.Add(this.label7);
            this.gpbAgregar_Producto.Controls.Add(this.label6);
            this.gpbAgregar_Producto.Controls.Add(this.label5);
            this.gpbAgregar_Producto.Controls.Add(this.label4);
            this.gpbAgregar_Producto.Controls.Add(this.label3);
            this.gpbAgregar_Producto.Location = new System.Drawing.Point(26, 86);
            this.gpbAgregar_Producto.Name = "gpbAgregar_Producto";
            this.gpbAgregar_Producto.Size = new System.Drawing.Size(544, 291);
            this.gpbAgregar_Producto.TabIndex = 29;
            this.gpbAgregar_Producto.TabStop = false;
            // 
            // bnt_Agregar_Lab
            // 
            this.bnt_Agregar_Lab.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bnt_Agregar_Lab.Location = new System.Drawing.Point(330, 78);
            this.bnt_Agregar_Lab.Name = "bnt_Agregar_Lab";
            this.bnt_Agregar_Lab.Size = new System.Drawing.Size(47, 21);
            this.bnt_Agregar_Lab.TabIndex = 48;
            this.bnt_Agregar_Lab.TabStop = false;
            this.bnt_Agregar_Lab.Click += new System.EventHandler(this.bnt_Agregar_Lab_Click);
            // 
            // cmbLab
            // 
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Location = new System.Drawing.Point(129, 78);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.Size = new System.Drawing.Size(195, 21);
            this.cmbLab.TabIndex = 47;
            this.cmbLab.Text = "Selecciona Laboratorio";
            this.cmbLab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbLab_KeyPress);
            this.cmbLab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmbLab_MouseDown);
            // 
            // CmbPresentacion
            // 
            this.CmbPresentacion.FormattingEnabled = true;
            this.CmbPresentacion.Location = new System.Drawing.Point(131, 206);
            this.CmbPresentacion.Name = "CmbPresentacion";
            this.CmbPresentacion.Size = new System.Drawing.Size(194, 21);
            this.CmbPresentacion.TabIndex = 40;
            this.CmbPresentacion.Text = "Selecciona Presentación";
            this.CmbPresentacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPresentacion_KeyPress);
            // 
            // dtFecha_Vencimiento
            // 
            this.dtFecha_Vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha_Vencimiento.Location = new System.Drawing.Point(129, 105);
            this.dtFecha_Vencimiento.MinDate = new System.DateTime(2022, 3, 9, 0, 0, 0, 0);
            this.dtFecha_Vencimiento.Name = "dtFecha_Vencimiento";
            this.dtFecha_Vencimiento.Size = new System.Drawing.Size(195, 20);
            this.dtFecha_Vencimiento.TabIndex = 33;
            this.dtFecha_Vencimiento.Value = new System.DateTime(2022, 3, 9, 0, 0, 0, 0);
            // 
            // cmbCaja
            // 
            this.cmbCaja.FormattingEnabled = true;
            this.cmbCaja.Location = new System.Drawing.Point(130, 239);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Size = new System.Drawing.Size(195, 21);
            this.cmbCaja.TabIndex = 41;
            this.cmbCaja.Text = "Selecciona Almacen";
            this.cmbCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCaja_KeyPress);
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(130, 172);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(194, 21);
            this.cmbTipo.TabIndex = 37;
            this.cmbTipo.Text = "Selecciona Tipo";
            this.cmbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipo_KeyPress);
            // 
            // textGramaje
            // 
            this.textGramaje.Location = new System.Drawing.Point(130, 134);
            this.textGramaje.Name = "textGramaje";
            this.textGramaje.Size = new System.Drawing.Size(194, 20);
            this.textGramaje.TabIndex = 35;
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(130, 51);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(194, 20);
            this.textCantidad.TabIndex = 30;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(130, 25);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(194, 20);
            this.textNombre.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Suba una imagen";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(383, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 41);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(383, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 156);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Almacen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Para";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Gramaje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Fecha de vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Laboratorio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nombre";
            // 
            // FormAgregarMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 406);
            this.Controls.Add(this.LblMuestra1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbAgregar_Producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgregarMedicamento";
            this.Text = "FormAgregarMedicamento";
            this.Load += new System.EventHandler(this.FormAgregarMedicamento_Load);
            this.SizeChanged += new System.EventHandler(this.FormAgregarMedicamento_SizeChanged);
            this.Resize += new System.EventHandler(this.FormAgregarMedicamento_Resize);
            this.gpbAgregar_Producto.ResumeLayout(false);
            this.gpbAgregar_Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Agregar_Lab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LblMuestra1;
        private System.Windows.Forms.GroupBox gpbAgregar_Producto;
        private System.Windows.Forms.PictureBox bnt_Agregar_Lab;
        private System.Windows.Forms.ComboBox cmbLab;
        private System.Windows.Forms.ComboBox CmbPresentacion;
        private System.Windows.Forms.DateTimePicker dtFecha_Vencimiento;
        private System.Windows.Forms.ComboBox cmbCaja;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox textGramaje;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}