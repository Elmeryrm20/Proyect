﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS;

namespace PRESENTACION
{
    public partial class FormAgregarLaboratorio : Form
    {
        Consultas consultas = new Consultas();
        public FormAgregarLaboratorio()
        {
            InitializeComponent();
        }

        private void FormAgregarLaboratorio_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            consultas.D_Insertar_Laboratorio(Txt_Nombre.Text ,txt_Direccion.Text,txt_Telefono.Text);

            MessageBox.Show("Datos Ingresados Correctamente.", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
        int n, mx, my;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (n == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            n = 1;
            mx = e.X;
            my = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            n = 0;
        }
    }
}
