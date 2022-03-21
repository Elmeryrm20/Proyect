
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
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Control_Entradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialIngreso)).BeginInit();
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
            this.DgvHistorialIngreso.Location = new System.Drawing.Point(50, 57);
            this.DgvHistorialIngreso.Name = "DgvHistorialIngreso";
            this.DgvHistorialIngreso.Size = new System.Drawing.Size(553, 287);
            this.DgvHistorialIngreso.TabIndex = 1;
            // 
            // FormControldeEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 405);
            this.Controls.Add(this.DgvHistorialIngreso);
            this.Controls.Add(this.dgb_Control_Entradas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormControldeEntradas";
            this.Text = "FormControldeEntradas";
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Control_Entradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialIngreso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgb_Control_Entradas;
        private System.Windows.Forms.DataGridView DgvHistorialIngreso;
    }
}