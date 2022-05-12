using DATOS;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


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
            this.valor = valor;
            Medicamentos_Detallados();
        }
        int valor;

        private void btnSerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Medicamentos_Detallados()
        {

            //lbl_Nombre.Text=consultas.D_Medicamento_Detallado(valor).Rows[0]["COMPOSICIÓN"].ToString();
            //lbl_Ingeso.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL INGRESADO"].ToString();
            //lbl_Egreso.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL EGRESADO"].ToString();
            //lbl_Almacen.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["ALMACÉN"].ToString();
            //lbl_F_Vencimiento.Text = ((DateTime)consultas.D_Medicamento_Detallado(valor).Rows[0]["FEC. VENCIMIENTO"]).ToString("D");
            //lbl_Tipo.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["TIPO"].ToString();
            //lbl_Laboratorio.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["LABORATORIO"].ToString();
            //lbl_Presentacion.Text = consultas.D_Medicamento_Detallado(valor).Rows[0]["PRESENTACIÓN"].ToString();
            //int Ingreso = (int)consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL INGRESADO"];
            //int Egreso = (int)consultas.D_Medicamento_Detallado(valor).Rows[0]["TOTAL EGRESADO"];

            DataTable dt = consultas.D_Medicamento_Detallado(valor);
            lbl_Nombre.Text = dt.Rows[0][0].ToString();
            lbl_Ingeso.Text = dt.Rows[0][1].ToString();
            int Ingreso = int.Parse(dt.Rows[0][1].ToString());
            lbl_Egreso.Text = dt.Rows[0][2].ToString();
            int Egreso = int.Parse(dt.Rows[0][2].ToString());
            lbl_Almacen.Text = dt.Rows[0][3].ToString();
            lbl_F_Vencimiento.Text = Convert.ToDateTime(dt.Rows[0][4]).ToShortDateString();
            lbl_Tipo.Text = dt.Rows[0][5].ToString();
            lbl_Laboratorio.Text = dt.Rows[0][6].ToString();
            LblPertenencia.Text = dt.Rows[0][7].ToString();


            lbl_Existencia.Text = (Ingreso - Egreso).ToString();
            double Porcentaje = Convert.ToDouble((Ingreso - Egreso) * 100 / Ingreso);
            lbl_Porcentage.Text = Math.Round(Porcentaje).ToString() + "%";

            //-----------------Imagen--------------------------
            try
            {
                //MemoryStream img = new MemoryStream((byte[])consultas.D_Medicamento_Detallado(valor).Rows[0]["imagen"]);
                MemoryStream img = new MemoryStream((byte[])dt.Rows[0][9]);
                Bitmap imagen = new Bitmap(img);
                ptb_Imagen.Image = imagen;
                ptb_Imagen.SizeMode = PictureBoxSizeMode.CenterImage;
                ptb_Imagen.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception)
            {

                ptb_Imagen.Image = Properties.Resources.Imagen01;
                //if (dt.Rows[0][9] == null)
                //{
                //    ptb_Imagen.Image = Properties.Resources.Imagen01;
                //}
                //else
                //{
                //string Nombre_Imagen = consultas.D_Medicamento_Detallado(valor).Rows[0]["COMPOSICIÓN"].ToString();
                //string str = Convert.ToString(Directory.GetCurrentDirectory());
                //str = str.Replace(@"\bin\Debug", "");
                //ptb_Imagen.Image = Image.FromFile(str + @"\Resources\Error.jpg");
                //ptb_Imagen.SizeMode = PictureBoxSizeMode.CenterImage;
                //ptb_Imagen.SizeMode = PictureBoxSizeMode.Zoom;

                //}

            }
            //-----------------------------------------------
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSerrar_MouseEnter(object sender, EventArgs e)
        {
            btnSerrar.Image = Properties.Resources.BotonFormVolver02;
        }

        private void btnSerrar_MouseLeave(object sender, EventArgs e)
        {
            btnSerrar.Image = Properties.Resources.BotonFormVolver01;

        }
    }
}
