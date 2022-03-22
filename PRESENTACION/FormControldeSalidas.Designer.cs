
namespace PRESENTACION
{
    partial class FormControldeSalidas
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
            this.dgb_Contral_Salida = new System.Windows.Forms.DataGridView();
            this.DgvHistorialEgreso = new System.Windows.Forms.DataGridView();
            this.PibActualizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Contral_Salida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialEgreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibActualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgb_Contral_Salida
            // 
            this.dgb_Contral_Salida.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgb_Contral_Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_Contral_Salida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgb_Contral_Salida.Location = new System.Drawing.Point(0, 0);
            this.dgb_Contral_Salida.Name = "dgb_Contral_Salida";
            this.dgb_Contral_Salida.Size = new System.Drawing.Size(639, 349);
            this.dgb_Contral_Salida.TabIndex = 0;
            // 
            // DgvHistorialEgreso
            // 
            this.DgvHistorialEgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistorialEgreso.Location = new System.Drawing.Point(38, 12);
            this.DgvHistorialEgreso.Name = "DgvHistorialEgreso";
            this.DgvHistorialEgreso.Size = new System.Drawing.Size(553, 287);
            this.DgvHistorialEgreso.TabIndex = 2;
            // 
            // PibActualizar
            // 
            this.PibActualizar.BackColor = System.Drawing.Color.Transparent;
            this.PibActualizar.Image = global::PRESENTACION.Properties.Resources.BotonFormActualizar01;
            this.PibActualizar.Location = new System.Drawing.Point(238, 305);
            this.PibActualizar.Name = "PibActualizar";
            this.PibActualizar.Size = new System.Drawing.Size(110, 40);
            this.PibActualizar.TabIndex = 4;
            this.PibActualizar.TabStop = false;
            this.PibActualizar.Click += new System.EventHandler(this.PibActualizar_Click);
            // 
            // FormControldeSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 349);
            this.Controls.Add(this.PibActualizar);
            this.Controls.Add(this.DgvHistorialEgreso);
            this.Controls.Add(this.dgb_Contral_Salida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormControldeSalidas";
            this.Text = "FormControldeSalidas";
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Contral_Salida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialEgreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibActualizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgb_Contral_Salida;
        private System.Windows.Forms.DataGridView DgvHistorialEgreso;
        private System.Windows.Forms.PictureBox PibActualizar;
    }
}