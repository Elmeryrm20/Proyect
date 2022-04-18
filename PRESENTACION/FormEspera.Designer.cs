namespace PRESENTACION
{
    partial class FormEspera
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
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CpbCarga = new CircularProgressBar.CircularProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stabillo Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cargando controles...";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CpbCarga
            // 
            this.CpbCarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CpbCarga.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CpbCarga.AnimationSpeed = 100;
            this.CpbCarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.CpbCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.CpbCarga.ForeColor = System.Drawing.Color.White;
            this.CpbCarga.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.CpbCarga.InnerMargin = 0;
            this.CpbCarga.InnerWidth = -2;
            this.CpbCarga.Location = new System.Drawing.Point(152, 172);
            this.CpbCarga.Margin = new System.Windows.Forms.Padding(0);
            this.CpbCarga.MarqueeAnimationSpeed = 2000;
            this.CpbCarga.Name = "CpbCarga";
            this.CpbCarga.OuterColor = System.Drawing.Color.Firebrick;
            this.CpbCarga.OuterMargin = -20;
            this.CpbCarga.OuterWidth = 20;
            this.CpbCarga.ProgressColor = System.Drawing.Color.White;
            this.CpbCarga.ProgressWidth = 12;
            this.CpbCarga.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.CpbCarga.Size = new System.Drawing.Size(80, 80);
            this.CpbCarga.StartAngle = 270;
            this.CpbCarga.Step = 100;
            this.CpbCarga.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.CpbCarga.SubscriptColor = System.Drawing.Color.White;
            this.CpbCarga.SubscriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.CpbCarga.SubscriptText = "%";
            this.CpbCarga.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CpbCarga.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CpbCarga.SuperscriptText = "";
            this.CpbCarga.TabIndex = 1;
            this.CpbCarga.Text = "0";
            this.CpbCarga.TextMargin = new System.Windows.Forms.Padding(5, 4, 0, 0);
            this.CpbCarga.Value = 68;
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.CpbCarga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEspera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEspera";
            this.Load += new System.EventHandler(this.FormEspera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private CircularProgressBar.CircularProgressBar CpbCarga;
    }
}