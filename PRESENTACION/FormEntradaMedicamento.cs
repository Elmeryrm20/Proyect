using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormEntradaMedicamento : Form
    {
        public FormEntradaMedicamento()
        {
            InitializeComponent();
        }
        public FormEntradaMedicamento(string DNI)
        {
            InitializeComponent();
            this.DNI = DNI;
        }

        string DNI;
    }
}
