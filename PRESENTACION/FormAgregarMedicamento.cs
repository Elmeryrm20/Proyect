﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormAgregarMedicamento : Form
    {
        public FormAgregarMedicamento()
        {
            InitializeComponent();
        }

        private void FormAgregarMedicamento_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Escoja una imagen";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.ShowDialog();


            if (File.Exists(openFileDialog1.FileName))
            {
                string Imagen = openFileDialog1.FileName;
                string nombre = openFileDialog1.SafeFileName;

                this.Text = nombre;
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Load(Imagen);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textNombre.Text != "")
            {       
                string str = Convert.ToString(Directory.GetCurrentDirectory());
                str = str.Replace(@"\bin\Debug","");
                pictureBox1.Image.Save(str + @"\Resources\" + textNombre.Text + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
    }
}