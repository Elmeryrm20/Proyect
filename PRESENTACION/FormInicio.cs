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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }
        public FormInicio(string DNI, string Nombre)
        {
            InitializeComponent();
            this.DNI = DNI;
            this.Nombre = Nombre;
            label1.Text = Nombre;
            saludo();

        }
        readonly string DNI;
        readonly string Nombre;
        void saludo()
        {
            int hora=(int)DateTime.Now.Hour;

            if (hora>=6 && hora<=12)
            {
                label4.Text = "dìa de trabajo"; 
            }
            else if (hora<=18 && hora>=13)
            {
                label4.Text = "tarde de trabajo";
            }
            else if (hora <= 24 && hora >= 19)
            {
                label4.Text = "noche";
            }
            else
            {
                label4.Text = "madrugada de trabajo";
            }
        }



    }
}
