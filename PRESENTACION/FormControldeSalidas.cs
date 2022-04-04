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
using SpreadsheetLight;

namespace PRESENTACION
{
    public partial class FormControldeSalidas : Form
    {
        public FormControldeSalidas()
        {
            InitializeComponent();
            RellenarDataGridView();
        }


        Consultas du = new Consultas();

        private void RellenarDataGridView()
        {
            DgvHistorialEgreso.DataSource = du.D_HistorialEgreso();
            DgvHistorialEgreso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void PibActualizar_Click(object sender, EventArgs e)
        {
            RellenarDataGridView();
            txt_Texto.Clear();
            LblDesde.Visible = false;
            dtp_FechaI.Visible = false;
            LblHasta.Visible = false;
            dtp_FechaF.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dtp_FechaI.Value.Date <= dtp_FechaF.Value.Date)
            {
                switch (CmbFiltro.SelectedIndex)
                {
                    case 0:
                        DgvHistorialEgreso.DataSource = du.Sp_Filtro_Fecha_HI(DateTime.Today.ToString("yyyy-MM-dd"), DateTime.Today.AddDays(1).ToString("yyyy-MM-dd"));
                        break;
                    case 1:
                        DgvHistorialEgreso.DataSource = du.Sp_Filtro_Fecha_HI(DateTime.Today.AddDays(-7).ToString("yyyy-MM-dd"), DateTime.Today.ToString("yyyy-MM-dd"));
                        break;
                    case 2:
                        DgvHistorialEgreso.DataSource = du.Sp_Filtro_Fecha_HI(DateTime.Today.AddDays(-30).ToString("yyyy-MM-dd"), DateTime.Today.ToString("yyyy-MM-dd"));

                        break;
                    case 3:
                        DgvHistorialEgreso.DataSource = du.Sp_Filtro_Fecha_HI(dtp_FechaI.Value.ToString("yyyy-MM-dd"), dtp_FechaF.Value.AddDays(1).ToString("yyyy-MM-dd"));
                        break;
                    case 4:
                        DgvHistorialEgreso.DataSource = du.Sp_Filtro_Fecha_HI(dtp_FechaI.Value.ToString("yyyy-MM-dd"), dtp_FechaF.Value.ToString("yyyy-MM-dd"));
                        break;
                    default:
                        break;
                }
                DgvHistorialEgreso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                txt_Texto.Clear();
                txt_Error.Visible = false;
            }
            else
            {
                txt_Error.Visible = true;
            }
        }

        private void txt_Texto_KeyUp(object sender, KeyEventArgs e)
        {
            DgvHistorialEgreso.DataSource = du.Sp_Filtro_Dinamico_HE(txt_Texto.Text);

        }
        private void DesignDataGridView()
        {
            DgvHistorialEgreso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvHistorialEgreso.Columns[0].Visible = false;
            DgvHistorialEgreso.Columns[2].Width = 40;
            DgvHistorialEgreso.Columns[5].Width = 40;
            DgvHistorialEgreso.ColumnHeadersHeight = 35;
            DgvHistorialEgreso.Columns[0].MinimumWidth = 90;
            DgvHistorialEgreso.Columns[1].MinimumWidth = 150;
            DgvHistorialEgreso.Columns[2].MinimumWidth = 40;
            DgvHistorialEgreso.Columns[3].MinimumWidth = 80;
            DgvHistorialEgreso.Columns[4].MinimumWidth = 80;
            DgvHistorialEgreso.Columns[5].MinimumWidth = 40;
            DgvHistorialEgreso.Columns[2].HeaderText = "CANT.";
            DgvHistorialEgreso.RowHeadersWidth = 35;
        }
        private void FormControldeSalidas_Load(object sender, EventArgs e)
        {
            DesignDataGridView();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SLDocument documento = new SLDocument();
            int Cantidad = int.Parse(DgvHistorialEgreso.RowCount.ToString());
            documento.SetCellValue("A1", "ID");
            documento.SetCellValue("B1", "MEDICAMENTO");
            documento.SetCellValue("C1", "CANTIDAD");
            documento.SetCellValue("D1", "FECHA DE INGRESO");
            documento.SetCellValue("E1", "HORA DE INGRESO");
            documento.SetCellValue("F1", "Nº SEMANA");
            documento.SetCellValue("G1", "TRABAJADOR");
            SLStyle style = new SLStyle();
            style.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            style.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            style.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            style.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            style.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.FromArgb(225, 99, 71), System.Drawing.Color.Red);
            style.Font.FontSize = 10;
            style.Font.FontName = "Book Antique";
            style.Font.Bold = true;
            documento.SetCellStyle("A1", "G1", style);
            documento.AutoFitColumn("A", "G");

            for (int i = 0; i < Cantidad; i++)
            {
                int j = i + 2;
                documento.SetCellValue(j, 1, DgvHistorialEgreso.Rows[i].Cells[0].Value.ToString());
                documento.SetCellValue(j, 2, DgvHistorialEgreso.Rows[i].Cells[1].Value.ToString());
                documento.SetCellValue(j, 3, DgvHistorialEgreso.Rows[i].Cells[2].Value.ToString());
                documento.SetCellValue(j, 4, Convert.ToDateTime(DgvHistorialEgreso.Rows[i].Cells[3].Value.ToString()).ToString("yyyy/MM/dd"));
                documento.SetCellValue(j, 5, DgvHistorialEgreso.Rows[i].Cells[4].Value.ToString());
                documento.SetCellValue(j, 6, DgvHistorialEgreso.Rows[i].Cells[5].Value.ToString());
                documento.SetCellValue(j, 7, DgvHistorialEgreso.Rows[i].Cells[6].Value.ToString());
            }
            SLStyle estilos = new SLStyle();
            estilos.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            estilos.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            estilos.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            estilos.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            estilos.Font.FontSize = 10;
            estilos.Font.FontName = "Book Antique";
            documento.SetCellStyle("A2", "G" + (Cantidad + 1), estilos);
            documento.AutoFitColumn("A", "G");

            string direccion = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            direccion = direccion + "\\" + "Informe_Egreso_" + DateTime.Now.ToString("dd-MM-yy-HH-mm-ss") + ".xls";
            documento.SaveAs(direccion);
            MessageBox.Show("Exportacion exitosa archivo guardado en Documentos", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.BotonFormInforme02;

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.BotonFormInforme01;

        }

        private void PibActualizar_MouseEnter(object sender, EventArgs e)
        {
            PibActualizar.Image = Properties.Resources.BotonFormActualizar02;
        }

        private void PibActualizar_MouseLeave(object sender, EventArgs e)
        {
            PibActualizar.Image = Properties.Resources.BotonFormActualizar01;

        }

        private void CmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hoy
            //Últimos 7 días
            //Últimos 30 días
            //Elegir Fecha
            //Elegir Rango de Fecha

            switch (CmbFiltro.SelectedIndex)
            {
                case 0:
                    LblDesde.Visible = false;
                    dtp_FechaI.Visible = false;
                    LblHasta.Visible = false;
                    dtp_FechaF.Visible = false;
                    break;
                case 1:
                    LblDesde.Visible = false;
                    dtp_FechaI.Visible = false;
                    LblHasta.Visible = false;
                    dtp_FechaF.Visible = false;
                    break;
                case 2:
                    LblDesde.Visible = false;
                    dtp_FechaI.Visible = false;
                    LblHasta.Visible = false;
                    dtp_FechaF.Visible = false;
                    break;
                case 3:
                    LblDesde.Visible = true;
                    LblDesde.Text = "Elegir Fecha";
                    dtp_FechaI.Visible = true;
                    LblHasta.Visible = false;
                    dtp_FechaF.Visible = false;
                    break;
                case 4:
                    LblDesde.Visible = true;
                    LblDesde.Text = "Desde:";
                    dtp_FechaI.Visible = true;
                    LblHasta.Visible = true;
                    dtp_FechaF.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void Btn_Informe_MouseEnter(object sender, EventArgs e)
        {

        }

        private void PibImprimir_MouseEnter(object sender, EventArgs e)
        {
            PibImprimir.Image = Properties.Resources.BotonFormImprimir02;

        }

        private void PibImprimir_MouseLeave(object sender, EventArgs e)
        {
            PibImprimir.Image = Properties.Resources.BotonFormImprimir01;

        }
    }
}
