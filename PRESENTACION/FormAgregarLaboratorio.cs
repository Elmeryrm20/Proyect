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
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre.Text == "")
            {
                MessageBox.Show("Falta Ingresar Nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if (txt_Direccion.Text == "")
            //{
            //    MessageBox.Show("Falta Ingresar Direccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (txt_Telefono.Text == "")
            //{
            //    MessageBox.Show("Falta Ingresar Telefono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else
            { 
                consultas.D_Insertar_Laboratorio(Txt_Nombre.Text, txt_Direccion.Text, txt_Telefono.Text);

                MessageBox.Show("Datos Ingresados Correctamente.", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }
        int n, mx, my;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (n == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void Txt_Nombre_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnSerrar_MouseEnter(object sender, EventArgs e)
        {
            btnSerrar.Image = Properties.Resources.BotonVentanaCerrar02;
        }

        private void btnSerrar_MouseLeave(object sender, EventArgs e)
        {
            btnSerrar.Image = Properties.Resources.BotonVentanaCerrar01;

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
