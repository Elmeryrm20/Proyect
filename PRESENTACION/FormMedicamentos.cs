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
    public partial class FormMedicamentos : Form
    {
        Consultas consultas = new Consultas();
        public FormMedicamentos()
        {
            InitializeComponent();
            rellenartabla();
           
        }
        void rellenartabla()
        {
            dgb_Medicamentos.DataSource = consultas.ConsultaMed();
        }
       
        private void FormMedicamentos_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
