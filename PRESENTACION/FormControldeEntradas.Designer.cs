
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
            this.dgb_Control_Entradas = new System.Windows.Forms.DataGridView();
            this.DgvHistorialIngreso = new System.Windows.Forms.DataGridView();
            this.PibActualizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Control_Entradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibActualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgb_Control_Entradas
            // 
            this.dgb_Control_Entradas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgb_Control_Entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_Control_Entradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgb_Control_Entradas.Location = new System.Drawing.Point(0, 0);
            this.dgb_Control_Entradas.Name = "dgb_Control_Entradas";
            this.dgb_Control_Entradas.Size = new System.Drawing.Size(690, 405);
            this.dgb_Control_Entradas.TabIndex = 0;
            // 
            // DgvHistorialIngreso
            // 
            this.DgvHistorialIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistorialIngreso.Location = new System.Drawing.Point(54, 12);
            this.DgvHistorialIngreso.Name = "DgvHistorialIngreso";
            this.DgvHistorialIngreso.Size = new System.Drawing.Size(553, 287);
            this.DgvHistorialIngreso.TabIndex = 1;
            // 
            // PibActualizar
            // 
            this.PibActualizar.BackColor = System.Drawing.Color.Transparent;
            this.PibActualizar.Image = global::PRESENTACION.Properties.Resources.BotonFormActualizar01;
            this.PibActualizar.Location = new System.Drawing.Point(279, 308);
            this.PibActualizar.Name = "PibActualizar";
            this.PibActualizar.Size = new System.Drawing.Size(110, 40);
            this.PibActualizar.TabIndex = 3;
            this.PibActualizar.TabStop = false;
            this.PibActualizar.Click += new System.EventHandler(this.PibActualizar_Click);
            // 
            // FormControldeEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 405);
            this.Controls.Add(this.PibActualizar);
            this.Controls.Add(this.DgvHistorialIngreso);
            this.Controls.Add(this.dgb_Control_Entradas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormControldeEntradas";
            this.Text = "FormControldeEntradas";
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Control_Entradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibActualizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgb_Control_Entradas;
        private System.Windows.Forms.DataGridView DgvHistorialIngreso;
        private System.Windows.Forms.PictureBox PibActualizar;
    }
}