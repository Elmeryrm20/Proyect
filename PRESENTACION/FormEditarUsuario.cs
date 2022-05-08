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
    public partial class FormEditarUsuario : Form
    {
        Consultas consultas = new Consultas();
        public FormEditarUsuario()
        {
            InitializeComponent();
        }
        public FormEditarUsuario(string DNI)
        {
            InitializeComponent();
            this.DNI = DNI;
            CargoTrabajador();
            TipoTrabajador();
            EstadoTrabajador();
            Consulta_Editar_Trabajador();

        }
        readonly string DNI;

        void CargoTrabajador()
        {
            cmb_Cargo.DisplayMember = "Car_Descripcion";
            cmb_Cargo.DataSource = consultas.D_CargoTrabajador();
        }
        void TipoTrabajador()
        {
            cmb_Tipo.DisplayMember = "tiu_desc";
            cmb_Tipo.DataSource = consultas.D_TipoTrabajador();
        }
        void EstadoTrabajador()
        {
            cmb_Estado.DisplayMember = "Esu_Descripcion";
            cmb_Estado.DataSource = consultas.D_EstadoTrabajador();
        }
        void Consulta_Editar_Trabajador()
        {

            try
            {
                txt_DNI.Text = consultas.SP_ListaU_Para_Edit(DNI).Rows[0]["Tra_DNI"].ToString();
                txt_Nombre.Text = consultas.SP_ListaU_Para_Edit(DNI).Rows[0]["Tra_Nombre"].ToString();
                txt_Apellido.Text = consultas.SP_ListaU_Para_Edit(DNI).Rows[0]["Tra_Apellido"].ToString();
               txt_Fecha.Text = ((DateTime)consultas.SP_ListaU_Para_Edit(DNI).Rows[0]["Tra_Nacimiento"]).ToString("D");
                txt_Correo.Text = consultas.SP_ListaU_Para_Edit(DNI).Rows[0]["Tra_Correo"].ToString();
                txt_Telefono.Text = consultas.SP_ListaU_Para_Edit(DNI).Rows[0]["Tra_Telefono"].ToString();
                cmb_Tipo.Text = consultas.SP_ListaU_Para_Edit(DNI).Rows[0]["TIPO"].ToString();
                cmb_Estado.Text = consultas.SP_ListaU_Para_Edit(DNI).Rows[0]["ESTADO"].ToString();
                cmb_Cargo.Text = consultas.SP_ListaU_Para_Edit(DNI).Rows[0]["CARGO"].ToString();
                

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnSerrar_Click(object sender, EventArgs e)
        {
            FormUsuarios fr = Owner as FormUsuarios;
            fr.mostrarUsuario();
            this.Close();
        }
        
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {

                consultas.SP_Editar_Usuario(DNI, (txt_Nombre.Text).ToUpper(), (txt_Apellido.Text).ToUpper(),txt_Fecha.Value.ToString("yyyy-MM-dd"), txt_Correo.Text, txt_Telefono.Text, cmb_Tipo.SelectedIndex + 1, cmb_Cargo.SelectedIndex + 1, cmb_Estado.SelectedIndex + 1);
                MessageBox.Show("Los cambios Guardados", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Consulta_Editar_Trabajador();

            }
            catch (Exception)
            {

                MessageBox.Show("Error", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }

        private void btn_Editar_MouseEnter(object sender, EventArgs e)
        {
            btn_Editar.Image = Properties.Resources.BotonFormConfirmar02;
        }

        private void btn_Editar_MouseLeave(object sender, EventArgs e)
        {
            btn_Editar.Image = Properties.Resources.BotonFormConfirmar01;

        }

        private void btnSerrar_MouseEnter(object sender, EventArgs e)
        {
            btnSerrar.Image = Properties.Resources.BotonFormCancelar02;

        }

        private void btnSerrar_MouseLeave(object sender, EventArgs e)
        {
            btnSerrar.Image = Properties.Resources.BotonFormCancelar02;
        }
    }
}
