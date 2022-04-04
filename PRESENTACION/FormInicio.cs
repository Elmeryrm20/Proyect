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
            //LblNombre.Text = Nombre;
            saludo();

        }
        readonly string DNI;
        readonly string Nombre;
        void saludo()
        {
            int hora=(int)DateTime.Now.Hour;

            if (hora>=6 && hora<=12)
            {
                //LblMensajeBienvenida.Text = "Que tengas un excelente día de trabajo."; 
            }
            else if (hora<=18 && hora>=13)
            {
                //LblMensajeBienvenida.Text = "Que tengas una excelente tarde de trabajo.";
            }
            else if (hora <= 24 && hora >= 19)
            {
                //LblMensajeBienvenida.Text = "Que tengas una excelente noche de trabajo.";
            }
            else
            {
                //LblMensajeBienvenida.Text = "Que tengas una excelente madrugada de trabajo.";
            }
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
        }
    }
}
