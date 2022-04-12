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
            CpbPorcExtranjeros.Text = dt.Rows[0][4].ToString();
            CpbPorcExtranjeros.Value = int.Parse(dt.Rows[0][4].ToString().Replace("%", String.Empty));
            LblPorcExtranjeros.Text = dt.Rows[0][4].ToString().Replace("%", String.Empty);
            LblNumVencidos.Text = dt.Rows[0][5].ToString();
            LblPorcVencidos.Text = dt.Rows[0][6].ToString();
            PrbVencidos.Value = int.Parse(dt.Rows[0][6].ToString().Replace("%", String.Empty));
            LblNumAgotados.Text = dt.Rows[0][7].ToString();
            LblPorcAgotados.Text = dt.Rows[0][8].ToString();
            PrbAgotados.Value = int.Parse(dt.Rows[0][8].ToString().Replace("%", String.Empty));
            LblProximoVencimiento.Text = dt.Rows[0][9].ToString();
            LblFechaProxVenci.Text = dt.Rows[0][10].ToString();
        }
        void Tablas()
        {
            DgvUltimasSalidas.DataSource = DU.D_UltimosEgresos();
            DgvAgotados.DataSource = DU.D_UltimosAgotados();
            DesignDataGridView();

        }
        #region DashBoard

        public bool maximizar = false;

        public void MaximizarDataGridView()
        {
            maximizar = true;
            DgvUltimasSalidas.Columns[1].Visible = true;
            DgvUltimasSalidas.Columns[3].Visible = true;
            DgvUltimasSalidas.Columns[4].Visible = true;
            DgvUltimasSalidas.Columns[0].MinimumWidth = 300;
            DgvUltimasSalidas.Columns[1].MinimumWidth = 40;
            DgvUltimasSalidas.Columns[2].MinimumWidth = 65;
            DgvUltimasSalidas.Columns[3].MinimumWidth = 35;
            DgvUltimasSalidas.Columns[4].MinimumWidth = 35;
            DgvUltimasSalidas.Columns[2].HeaderText = "Cantidad";

            DgvAgotados.Columns[1].Visible = true;
            DgvAgotados.Columns[3].Visible = true;
            DgvAgotados.Columns[4].Visible = true;
            DgvAgotados.Columns[0].MinimumWidth = 300;
            DgvAgotados.Columns[1].MinimumWidth = 40;
            DgvAgotados.Columns[2].MinimumWidth = 65;
            DgvAgotados.Columns[3].MinimumWidth = 35;
            DgvAgotados.Columns[4].MinimumWidth = 35;
            DgvAgotados.Columns[2].HeaderText = "Existencia";

            LblUltimasSalidas.Text = "últimas 5 Salidas de Medicamentos";
            LblUltimosAgotados.Text = "últimos 5 Medicamentos agotados o próximos a agotarse";

            //dgb_Medicamentos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgb_Medicamentos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgb_Medicamentos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgb_Medicamentos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgb_Medicamentos.MaximumSize.Width = 23;
        }
        public void MinimizarDataGridview()
        {
            maximizar = false;
            LblUltimasSalidas.Text = "últimas 5 Salidas";
            LblUltimosAgotados.Text = "últimos 5 agotados";
            DgvUltimasSalidas.Columns[2].HeaderText = "Cant.";
            DgvUltimasSalidas.Columns[1].Visible = false;
            DgvUltimasSalidas.Columns[3].Visible = false;
            DgvUltimasSalidas.Columns[4].Visible = false;
            DgvUltimasSalidas.Columns[0].MinimumWidth =150;
            DgvUltimasSalidas.Columns[2].MinimumWidth = 30;
            //dgb_Medicamentos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DgvAgotados.Columns[2].HeaderText = "Exis.";
            DgvAgotados.Columns[1].Visible = false;
            DgvAgotados.Columns[3].Visible = false;
            DgvAgotados.Columns[4].Visible = false;
            DgvAgotados.Columns[0].MinimumWidth = 150;
            DgvAgotados.Columns[2].MinimumWidth = 30;

        }
        public void DesignDataGridView()
        {
            DgvUltimasSalidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvAgotados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvUltimasSalidas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvAgotados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            if (maximizar == false) MinimizarDataGridview();
            else MaximizarDataGridView();
        }
        void Graficos()
        {
            //DataTable dt = DU.D_MayoresEgresos();
            ChartMayoresEgresos.DataSource = DU.D_MayoresEgresos();
            ChartMayoresEgresos.Series[0].XValueMember = "Medicamento";
            ChartMayoresEgresos.Series[0].YValueMembers = "Cantidad";
            ChartMayoresEgresos.DataBind();
            //ChartCategorias.

            ChartCategorias.DataSource = DU.D_CategoriasMedicamentos();
            ChartCategorias.Series[0].XValueMember = "Tipo";
            ChartCategorias.Series[0].YValueMembers = "Cantidad";
            ChartCategorias.DataBind();
        }
        public void CargarDashBoard()
        {
            Indicadores();
            Tablas();
            Graficos();
        }
        #endregion
        private void FormInicio_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            CmbFiltroFecha.SelectedIndex = 4;
            CargarDashBoard();
        }

        private void CmbFiltroFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            Indicadores();
        }
    }
}
