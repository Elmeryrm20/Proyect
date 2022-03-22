
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
            this.dgb_Medicamentos = new System.Windows.Forms.DataGridView();
            this.txb_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblIndice = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PibEditar = new System.Windows.Forms.PictureBox();
            this.PibSalida = new System.Windows.Forms.PictureBox();
            this.PibIngreso = new System.Windows.Forms.PictureBox();
            this.PibActualizar = new System.Windows.Forms.PictureBox();
            this.PibDetalles = new System.Windows.Forms.PictureBox();
            this.Pib_Filtrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Medicamentos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pib_Filtrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgb_Medicamentos
            // 
            this.dgb_Medicamentos.AllowUserToAddRows = false;
            this.dgb_Medicamentos.AllowUserToDeleteRows = false;
            this.dgb_Medicamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgb_Medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_Medicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgb_Medicamentos.Location = new System.Drawing.Point(0, 0);
            this.dgb_Medicamentos.Name = "dgb_Medicamentos";
            this.dgb_Medicamentos.ReadOnly = true;
            this.dgb_Medicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgb_Medicamentos.Size = new System.Drawing.Size(628, 283);
            this.dgb_Medicamentos.TabIndex = 0;
            this.dgb_Medicamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_Medicamentos_CellClick);
            this.dgb_Medicamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_Medicamentos_CellContentClick);
            // 
            // txb_Buscar
            // 
            this.txb_Buscar.Location = new System.Drawing.Point(40, 35);
            this.txb_Buscar.Name = "txb_Buscar";
            this.txb_Buscar.Size = new System.Drawing.Size(296, 20);
            this.txb_Buscar.TabIndex = 1;
            this.txb_Buscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txb_Buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "INVENTARIO  DE MEDICAMENTOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Pib_Filtrar);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txb_Buscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 73);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(415, 34);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(130, 21);
            this.cmbTipo.TabIndex = 8;
            this.cmbTipo.Text = "Filtrar por...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Composicion";
            // 
            // LblIndice
            // 
            this.LblIndice.AutoSize = true;
            this.LblIndice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIndice.Location = new System.Drawing.Point(616, 0);
            this.LblIndice.Name = "LblIndice";
            this.LblIndice.Size = new System.Drawing.Size(53, 18);
            this.LblIndice.TabIndex = 6;
            this.LblIndice.Text = "Indice";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PibEditar);
            this.panel3.Controls.Add(this.PibSalida);
            this.panel3.Controls.Add(this.PibIngreso);
            this.panel3.Controls.Add(this.LblIndice);
            this.panel3.Controls.Add(this.PibActualizar);
            this.panel3.Controls.Add(this.PibDetalles);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(708, 63);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 280);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(668, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 280);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgb_Medicamentos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(40, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(628, 283);
            this.panel5.TabIndex = 12;
            // 
            // PibEditar
            // 
            this.PibEditar.BackColor = System.Drawing.Color.Transparent;
            this.PibEditar.Image = global::PRESENTACION.Properties.Resources.BotonFormEditar01;
            this.PibEditar.Location = new System.Drawing.Point(391, 11);
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
            this.PibSalida.Image = global::PRESENTACION.Properties.Resources.BotonFormSalida01;
            this.PibSalida.Location = new System.Drawing.Point(275, 11);
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
            this.PibIngreso.Image = global::PRESENTACION.Properties.Resources.BotonFormIngreso01;
            this.PibIngreso.Location = new System.Drawing.Point(159, 11);
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
            this.PibActualizar.Image = global::PRESENTACION.Properties.Resources.BotonFormActualizar01;
            this.PibActualizar.Location = new System.Drawing.Point(507, 11);
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
            this.PibDetalles.Image = global::PRESENTACION.Properties.Resources.BotonFormDetalles01;
            this.PibDetalles.Location = new System.Drawing.Point(43, 11);
            this.PibDetalles.Name = "PibDetalles";
            this.PibDetalles.Size = new System.Drawing.Size(110, 40);
            this.PibDetalles.TabIndex = 3;
            this.PibDetalles.TabStop = false;
            this.PibDetalles.Click += new System.EventHandler(this.btn_Detalles_Click);
            this.PibDetalles.MouseEnter += new System.EventHandler(this.PibDetalles_MouseEnter);
            this.PibDetalles.MouseLeave += new System.EventHandler(this.PibDetalles_MouseLeave);
            // 
            // Pib_Filtrar
            // 
            this.Pib_Filtrar.BackColor = System.Drawing.Color.Transparent;
            this.Pib_Filtrar.Image = global::PRESENTACION.Properties.Resources.BotonFormBusqueda01;
            this.Pib_Filtrar.Location = new System.Drawing.Point(558, 27);
            this.Pib_Filtrar.Name = "Pib_Filtrar";
            this.Pib_Filtrar.Size = new System.Drawing.Size(110, 40);
            this.Pib_Filtrar.TabIndex = 9;
            this.Pib_Filtrar.TabStop = false;
            this.Pib_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            this.Pib_Filtrar.MouseEnter += new System.EventHandler(this.Pib_Filtrar_MouseEnter);
            this.Pib_Filtrar.MouseLeave += new System.EventHandler(this.Pib_Filtrar_MouseLeave);
            // 
            // FormMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 419);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMedicamentos";
            this.Text = "FormMedicamentos";
            this.Load += new System.EventHandler(this.FormMedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Medicamentos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PibEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pib_Filtrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txb_Buscar;
        private System.Windows.Forms.PictureBox PibActualizar;
        private System.Windows.Forms.PictureBox PibDetalles;
        private System.Windows.Forms.PictureBox PibIngreso;
        private System.Windows.Forms.PictureBox PibSalida;
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
        public System.Windows.Forms.DataGridView dgb_Medicamentos;
    }
}