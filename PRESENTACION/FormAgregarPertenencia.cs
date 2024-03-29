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
    public partial class FormAgregarPertenencia : Form
    {
        public FormAgregarPertenencia()
        {
            InitializeComponent();
        }
        Consultas consultas = new Consultas();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nombre", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                consultas.SP_Agregar_Pertenencia(Txt_Nombre.Text,txt_Telefono.Text);
                MessageBox.Show("Datos Ingresados Correctamente.", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
