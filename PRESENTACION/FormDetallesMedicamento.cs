using System;
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
    public partial class FormDetallesMedicamento : Form
    {
        Consultas consultas = new Consultas();
        public FormDetallesMedicamento()
        {
            InitializeComponent();
           
        }
        public FormDetallesMedicamento(int valor)
        {
            InitializeComponent();
            Medicamentos_Detallados(valor);
        }
        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void Medicamentos_Detallados(int valor )
        {
            lbl_Nombre.Text=consultas.D_Medicamento_Detallado(valor).Rows[0]["COMPOSICIÒN"].ToString();
            lbl_Ingeso.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL INGRESADO"].ToString();
            lbl_Egreso.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL EGRESADO"].ToString();
            lbl_Almacen.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["ALMACEN"].ToString();
            lbl_F_Vencimiento.Text = ((DateTime)consultas.D_Medicamento_Detallado(valor).Rows[0]["FEC.VENCIMIENTO"]).ToString("D");
            lbl_Tipo.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["TIPO"].ToString();
            lbl_Laboratorio.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["LABORATORIO"].ToString();
            lbl_Presentacion.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["PRESENTACIÒN"].ToString();
            int Ingreso =(int)consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL INGRESADO"];
            int Egreso= (int)consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL EGRESADO"];
            lbl_Existencia.Text = (Ingreso - Egreso).ToString();
            lbl_Porcentage.Text = (((Ingreso - Egreso) / Ingreso)*100).ToString() + " %";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
