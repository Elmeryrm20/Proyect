using DATOS;
using System;
using System.Data;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormInicio : Form
    {
        #region Constructores
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
            //saludo();

        }
        #endregion

        #region Inicializar Variables
        readonly string DNI;
        readonly string Nombre;
        Consultas DU = new Consultas();
        #endregion

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

        string Fecha1()
        {
            switch (CmbFiltroFecha.SelectedIndex)
            {
                case 0: return DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
                case 1: return DateTime.Today.AddDays(-7).ToString("yyyy-MM-dd");
                case 2: return DateTime.Today.AddDays(-30).ToString("yyyy-MM-dd");
                case 3: return DateTime.Today.AddDays(-365).ToString("yyyy-MM-dd");
                case 4: return "2000-01-01";
                default: return "2000-01-01";
            }
        }
        void Indicadores()
        {        
            DataTable dt = DU.D_DashBoard_Indicadores(Fecha1(), DateTime.Today.ToString("yyyy-MM-dd"));
            //0 Cantidad de Medicamentos
            //1 Suma de Ingresos
            //2 Suma de Egresos
            //3 Cantidad de Extranjeros
            //4 Porcentaje de Extranjeros
            //5 Cantidad de Medicamentos Vencidos
            //6 Porcentaje de Medicamentos Vencidos
            //7 Cantidad de Medicamentos Agotados
            //8 Porcentaje de Medicamentos Agotados
            //9 Próximo Medicamento a Vencer
            //10 Fecha de su Vencimiento

            LblNumMedicamentos.Text = dt.Rows[0][0].ToString();
            LblNumEntradas.Text = dt.Rows[0][1].ToString();
            LblNumSalidas.Text = dt.Rows[0][2].ToString();
            LblNumExtranjeros.Text = dt.Rows[0][3].ToString();
            LblPorcExtranjeros.Text = dt.Rows[0][4].ToString();
            LblNumVencidos.Text = dt.Rows[0][5].ToString();
            LblPorcVencidos.Text = dt.Rows[0][6].ToString();
            LblNumAgotados.Text = dt.Rows[0][7].ToString();
            LblPorcAgotados.Text = dt.Rows[0][8].ToString();
            LblProximoVencimiento.Text = dt.Rows[0][9].ToString();
            LblFechaProxVenci.Text = dt.Rows[0][10].ToString();
        }
        void UltimosEgresos()
        {
            //Prueba1
            //dgb_Medicamentos.Rows.Clear();
            //int n;
            //dgb_Medicamentos.Columns.Add("Column1", "Descripcion");
            //dgb_Medicamentos.Columns.Add("Column2", "Cantidad");
            //n = dgb_Medicamentos.Rows.Add();
            //dgb_Medicamentos.Rows[n].Cells[0].Value = "Acetil";
            //dgb_Medicamentos.Rows[n].Cells[1].Value = "34";
            //dgb_Medicamentos.Rows[n].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //n = dgb_Medicamentos.Rows.Add();
            //dgb_Medicamentos.Rows[n].Cells[0].Value = "Acohol";
            //dgb_Medicamentos.Rows[n].Cells[1].Value = "56";

            //n = dgb_Medicamentos.Rows.Add();
            //dgb_Medicamentos.Rows[n].Cells[0].Value = "Panadol";
            //dgb_Medicamentos.Rows[n].Cells[1].Value = "5";

            //n = dgb_Medicamentos.Rows.Add();
            //dgb_Medicamentos.Rows[n].Cells[0].Value = "Pastilla";
            //dgb_Medicamentos.Rows[n].Cells[1].Value = "21";

            //n = dgb_Medicamentos.Rows.Add();
            //dgb_Medicamentos.Rows[n].Cells[0].Value = "Algodon";
            //dgb_Medicamentos.Rows[n].Cells[1].Value = "2";

            //dgb_Medicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        void CargarDashBoard()
        {
            Indicadores();
            UltimosEgresos();
        }
        private void FormInicio_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            CmbFiltroFecha.SelectedIndex = 4;
            CargarDashBoard();
        }

        private void CmbFiltroFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDashBoard(); 
        }
    }
}
