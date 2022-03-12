using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS;

namespace PRESENTACION
{
    public partial class FormAgregarMedicamento : Form
    {
        Consultas consultas = new Consultas();
        public FormAgregarMedicamento()
        {
            InitializeComponent();
            ObtenerTipo();
            ObtenerCaja();
        }

        void ObtenerTipo()
        {
            cmbTipo.DisplayMember = "tip_descripcion";
            cmbTipo.DataSource=consultas.tipo();
           
        }
        void ObtenerCaja()
        {
           cmbCaja.DisplayMember = "Alm_Descripcion";
            cmbCaja.DataSource = consultas.caja();

        }

    }
}