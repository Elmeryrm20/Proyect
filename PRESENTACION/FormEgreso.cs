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
    public partial class FormEgreso : Form
    {
        Consultas consultas=new Consultas();
        public FormEgreso()
        {
            InitializeComponent();
           

        }
        public FormEgreso(int valor)
        {
            InitializeComponent();
            Egreso(valor);
        }

        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void Egreso(int valor)
        {
            lbl_Nombre.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["COMPOSICIÒN"].ToString();

        }
    }
}
