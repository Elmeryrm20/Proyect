
namespace PRESENTACION
{
    partial class FormUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Restablecer = new System.Windows.Forms.PictureBox();
            this.bt_EliminarU = new System.Windows.Forms.PictureBox();
            this.bt_ActualizarU = new System.Windows.Forms.PictureBox();
            this.bt_EditarU = new System.Windows.Forms.PictureBox();
            this.bt_AgregarU = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgb_Usuario = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restablecer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_EliminarU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_ActualizarU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_EditarU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_AgregarU)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 59);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(527, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 33);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.btn_Restablecer);
            this.panel2.Controls.Add(this.bt_EliminarU);
            this.panel2.Controls.Add(this.bt_ActualizarU);
            this.panel2.Controls.Add(this.bt_EditarU);
            this.panel2.Controls.Add(this.bt_AgregarU);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 54);
            this.panel2.TabIndex = 4;
            // 
            // btn_Restablecer
            // 
            this.btn_Restablecer.BackColor = System.Drawing.Color.Transparent;
            this.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restablecer.Image = global::PRESENTACION.Properties.Resources.BotonFormElimiarPass01;
            this.btn_Restablecer.Location = new System.Drawing.Point(498, 6);
            this.btn_Restablecer.Name = "btn_Restablecer";
            this.btn_Restablecer.Size = new System.Drawing.Size(110, 40);
            this.btn_Restablecer.TabIndex = 4;
            this.btn_Restablecer.TabStop = false;
            this.btn_Restablecer.Click += new System.EventHandler(this.btn_Restablecer_Click);
            this.btn_Restablecer.MouseEnter += new System.EventHandler(this.btn_Restablecer_MouseEnter);
            this.btn_Restablecer.MouseLeave += new System.EventHandler(this.btn_Restablecer_MouseLeave);
            // 
            // bt_EliminarU
            // 
            this.bt_EliminarU.BackColor = System.Drawing.Color.Transparent;
            this.bt_EliminarU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_EliminarU.Image = global::PRESENTACION.Properties.Resources.BotonFormQuitarUsuario01;
            this.bt_EliminarU.Location = new System.Drawing.Point(256, 6);
            this.bt_EliminarU.Name = "bt_EliminarU";
            this.bt_EliminarU.Size = new System.Drawing.Size(110, 40);
            this.bt_EliminarU.TabIndex = 3;
            this.bt_EliminarU.TabStop = false;
            this.bt_EliminarU.Click += new System.EventHandler(this.bt_EliminarU_Click);
            // 
            // bt_ActualizarU
            // 
            this.bt_ActualizarU.BackColor = System.Drawing.Color.Transparent;
            this.bt_ActualizarU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ActualizarU.Image = global::PRESENTACION.Properties.Resources.BotonFormActualizar01;
            this.bt_ActualizarU.Location = new System.Drawing.Point(377, 6);
            this.bt_ActualizarU.Name = "bt_ActualizarU";
            this.bt_ActualizarU.Size = new System.Drawing.Size(110, 40);
            this.bt_ActualizarU.TabIndex = 2;
            this.bt_ActualizarU.TabStop = false;
            this.bt_ActualizarU.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // bt_EditarU
            // 
            this.bt_EditarU.BackColor = System.Drawing.Color.Transparent;
            this.bt_EditarU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_EditarU.Image = global::PRESENTACION.Properties.Resources.BotonFormEditar01;
            this.bt_EditarU.Location = new System.Drawing.Point(135, 6);
            this.bt_EditarU.Name = "bt_EditarU";
            this.bt_EditarU.Size = new System.Drawing.Size(110, 40);
            this.bt_EditarU.TabIndex = 1;
            this.bt_EditarU.TabStop = false;
            this.bt_EditarU.Click += new System.EventHandler(this.bt_EditarU_Click);
            // 
            // bt_AgregarU
            // 
            this.bt_AgregarU.BackColor = System.Drawing.Color.Transparent;
            this.bt_AgregarU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_AgregarU.Image = global::PRESENTACION.Properties.Resources.BotonFormAgregarUsuario01;
            this.bt_AgregarU.Location = new System.Drawing.Point(14, 6);
            this.bt_AgregarU.Name = "bt_AgregarU";
            this.bt_AgregarU.Size = new System.Drawing.Size(110, 40);
            this.bt_AgregarU.TabIndex = 0;
            this.bt_AgregarU.TabStop = false;
            this.bt_AgregarU.Click += new System.EventHandler(this.pb_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 293);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(701, 59);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(32, 293);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgb_Usuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(32, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 293);
            this.panel3.TabIndex = 5;
            // 
            // dgb_Usuario
            // 
            this.dgb_Usuario.AllowUserToAddRows = false;
            this.dgb_Usuario.AllowUserToDeleteRows = false;
            this.dgb_Usuario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgb_Usuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgb_Usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgb_Usuario.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgb_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgb_Usuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgb_Usuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgb_Usuario.ColumnHeadersHeight = 25;
            this.dgb_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgb_Usuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgb_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgb_Usuario.EnableHeadersVisualStyles = false;
            this.dgb_Usuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.dgb_Usuario.Location = new System.Drawing.Point(0, 0);
            this.dgb_Usuario.MultiSelect = false;
            this.dgb_Usuario.Name = "dgb_Usuario";
            this.dgb_Usuario.ReadOnly = true;
            this.dgb_Usuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgb_Usuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgb_Usuario.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgb_Usuario.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgb_Usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgb_Usuario.Size = new System.Drawing.Size(669, 293);
            this.dgb_Usuario.TabIndex = 3;
            this.dgb_Usuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_Usuario_CellClick);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(733, 406);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restablecer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_EliminarU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_ActualizarU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_EditarU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_AgregarU)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox bt_ActualizarU;
        private System.Windows.Forms.PictureBox bt_EditarU;
        private System.Windows.Forms.PictureBox bt_AgregarU;
        private System.Windows.Forms.PictureBox bt_EliminarU;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btn_Restablecer;
        public System.Windows.Forms.DataGridView dgb_Usuario;
    }
}