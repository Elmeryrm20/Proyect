
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
            this.DgvSalida = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibAgregarMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibEliminarMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibGuardarImprimir)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSalida
            // 
            this.DgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSalida.Location = new System.Drawing.Point(24, 114);
            this.DgvSalida.Name = "DgvSalida";
            this.DgvSalida.Size = new System.Drawing.Size(509, 228);
            this.DgvSalida.TabIndex = 0;
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
            this.PibAgregarMed.Image = global::PRESENTACION.Properties.Resources.BotonFormIngreso01;
            this.PibAgregarMed.Location = new System.Drawing.Point(550, 126);
            this.PibAgregarMed.Name = "PibAgregarMed";
            this.PibAgregarMed.Size = new System.Drawing.Size(110, 40);
            this.PibAgregarMed.TabIndex = 4;
            this.PibAgregarMed.TabStop = false;
            // 
            // PibEliminarMed
            // 
            this.PibEliminarMed.Image = global::PRESENTACION.Properties.Resources.BotonFormeEliminar01;
            this.PibEliminarMed.Location = new System.Drawing.Point(550, 182);
            this.PibEliminarMed.Name = "PibEliminarMed";
            this.PibEliminarMed.Size = new System.Drawing.Size(110, 40);
            this.PibEliminarMed.TabIndex = 5;
            this.PibEliminarMed.TabStop = false;
            // 
            // PibLimpiar
            // 
            this.PibLimpiar.Image = global::PRESENTACION.Properties.Resources.BotonFormActualizar01;
            this.PibLimpiar.Location = new System.Drawing.Point(550, 237);
            this.PibLimpiar.Name = "PibLimpiar";
            this.PibLimpiar.Size = new System.Drawing.Size(110, 40);
            this.PibLimpiar.TabIndex = 6;
            this.PibLimpiar.TabStop = false;
            // 
            // PibGuardarImprimir
            // 
            this.PibGuardarImprimir.Image = global::PRESENTACION.Properties.Resources.BotonFormImprimir01;
            this.PibGuardarImprimir.Location = new System.Drawing.Point(550, 293);
            this.PibGuardarImprimir.Name = "PibGuardarImprimir";
            this.PibGuardarImprimir.Size = new System.Drawing.Size(110, 40);
            this.PibGuardarImprimir.TabIndex = 7;
            this.PibGuardarImprimir.TabStop = false;
            // 
            // FormSalidaMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.DgvSalida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSalidaMedicamentos";
            this.Text = "FormSalidaMedicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibAgregarMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibEliminarMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibGuardarImprimir)).EndInit();
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
        public System.Windows.Forms.DataGridView DgvSalida;
        private System.Windows.Forms.PictureBox PibGuardarImprimir;
    }
}