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
    public partial class FormControldeEntradas : Form
    {
        public FormControldeEntradas()
        {
            InitializeComponent();
            RellenarDataGridView();
        }

        Consultas du = new Consultas();

        private void RellenarDataGridView()
        {
            DgvHistorialIngreso.DataSource = du.D_HistorialIngreso();
            DgvHistorialIngreso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void PibActualizar_Click(object sender, EventArgs e)
        {
            RellenarDataGridView();
            txt_Texto.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (dtp_FechaI.Value.Date<=dtp_FechaF.Value.Date)
            {
                DgvHistorialIngreso.DataSource = du.Sp_Filtro_Fecha_HI(dtp_FechaI.Value.ToString("yyyy-MM-dd"), dtp_FechaF.Value.ToString("yyyy-MM-dd"));
                DgvHistorialIngreso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                txt_Texto.Clear();
                txt_Error.Visible = false;
                DesignDataGridView();
            }
            else
            {
                txt_Error.Visible = true;
            }
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DgvHistorialIngreso.DataSource = du.Sp_Filtro_Dinamico_HI(txt_Texto.Text);
        }
        private void DesignDataGridView()
        {
            DgvHistorialIngreso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvHistorialIngreso.Columns[0].Visible = false;
            DgvHistorialIngreso.Columns[2].Width = 40;
            //dgb_Medicamentos.Columns[0].MinimumWidth = 25;
            //dgb_Medicamentos.Columns[1].Width = 250;
            DgvHistorialIngreso.ColumnHeadersHeight = 35;
            DgvHistorialIngreso.Columns[0].MinimumWidth = 90;
            DgvHistorialIngreso.Columns[1].MinimumWidth = 150;
            DgvHistorialIngreso.Columns[2].MinimumWidth = 40;
            DgvHistorialIngreso.Columns[3].MinimumWidth = 80;
            DgvHistorialIngreso.Columns[5].MinimumWidth = 80;
            DgvHistorialIngreso.Columns[2].HeaderText = "CANT.";
            DgvHistorialIngreso.RowHeadersWidth = 35;
        }
        private void FormControldeEntradas_Load(object sender, EventArgs e)
        {
            DesignDataGridView();
        }

        private void btn_Informe_Click(object sender, EventArgs e)
        {
            SLDocument documento = new SLDocument();
            int Cantidad = int.Parse(DgvHistorialIngreso.RowCount.ToString());
            documento.SetCellValue("A1","ID");
            documento.SetCellValue("B1", "MEDICAMENTO");
            documento.SetCellValue("C1", "CANTIDAD");
            documento.SetCellValue("D1", "FECHA DE INGRESO");
            documento.SetCellValue("E1", "HORA DE INGRESO");
            documento.SetCellValue("F1", "FECHA VENCIMIENTO");
            documento.SetCellValue("G1", "TRABAJADOR");

            for (int i = 0; i <Cantidad; i++)
            {
                int j = i + 2;
                documento.SetCellValue(j, 1, DgvHistorialIngreso.Rows[i].Cells[0].Value.ToString());
                documento.SetCellValue(j, 2, DgvHistorialIngreso.Rows[i].Cells[1].Value.ToString());
                documento.SetCellValue(j, 3, DgvHistorialIngreso.Rows[i].Cells[2].Value.ToString());
                documento.SetCellValue(j, 4, Convert.ToDateTime(DgvHistorialIngreso.Rows[i].Cells[3].Value.ToString()).ToString("yyyy/MM/dd"));
                documento.SetCellValue(j, 5, DgvHistorialIngreso.Rows[i].Cells[4].Value.ToString());
                documento.SetCellValue(j, 6, Convert.ToDateTime(DgvHistorialIngreso.Rows[i].Cells[5].Value.ToString()).ToString("yyyy/MM/dd"));
                documento.SetCellValue(j, 7, DgvHistorialIngreso.Rows[i].Cells[6].Value.ToString());
            }
            
            string direccion = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            direccion = direccion + "\\" + "Informe_Ingreso_"+ DateTime.Now.ToString("dd-MM-yy-HH-mm-ss") + ".xls";
            documento.SaveAs(direccion);
            label5.Text = Cantidad.ToString();
            MessageBox.Show("Exito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
