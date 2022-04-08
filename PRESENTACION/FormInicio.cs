using System;
using System.Windows.Forms;

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
            int hora = (int)DateTime.Now.Hour;

            if (hora >= 6 && hora <= 12)
            {
                //LblMensajeBienvenida.Text = "Que tengas un excelente día de trabajo."; 
            }
            else if (hora <= 18 && hora >= 13)
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

        void CargarDashBoard()
        {

        }
        private void FormInicio_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            CmbFiltroFecha.SelectedIndex = 4;
            CargarDashBoard();

            //Prueba1
            int n;
            dgb_Medicamentos.Columns.Add("Column1", "Descripcion");
            dgb_Medicamentos.Columns.Add("Column2", "Cantidad");
            n = dgb_Medicamentos.Rows.Add();
            dgb_Medicamentos.Rows[n].Cells[0].Value = "Acetil";
            dgb_Medicamentos.Rows[n].Cells[1].Value = "34";
            dgb_Medicamentos.Rows[n].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            n = dgb_Medicamentos.Rows.Add();
            dgb_Medicamentos.Rows[n].Cells[0].Value = "Acohol";
            dgb_Medicamentos.Rows[n].Cells[1].Value = "56";

            n = dgb_Medicamentos.Rows.Add();
            dgb_Medicamentos.Rows[n].Cells[0].Value = "Panadol";
            dgb_Medicamentos.Rows[n].Cells[1].Value = "5";    
            
            n = dgb_Medicamentos.Rows.Add();
            dgb_Medicamentos.Rows[n].Cells[0].Value = "Pastilla";
            dgb_Medicamentos.Rows[n].Cells[1].Value = "21";     
            
            n = dgb_Medicamentos.Rows.Add();
            dgb_Medicamentos.Rows[n].Cells[0].Value = "Algodon";
            dgb_Medicamentos.Rows[n].Cells[1].Value = "2";

            dgb_Medicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
    }
}
