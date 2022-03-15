using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace DATOS
{
    public class Consultas
    {
        D_Empleado Conexion= new D_Empleado();

        //public DataTable ConsultaMed(int codigo, string composicion, string fecha_v, int total_i, string fecha_i, int total_e,)
        //{

        //}
        public DataTable ConsultaMed()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Consulta_Medicamento_Basico", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Conexion.connection.Close();
            return tabla;
        }

        public void D_AgregarMedicamento(string Med_Composicion, int Med_Total_I, int Laboratorio, string fecha_v, int Tipo, int caja, string Fecha_I, int Med_Total_E, int Pre_C)
        {

            Conexion.connection.Open();
            string query = "INSERT INTO medicamento(Med_Composicion, Med_Fecha_V, Med_Total_I, Med_Fecha_I, Med_Total_E, Pre_C, Lab_C, Tip_C, Alm_C) value ('" + Med_Composicion + "','" + fecha_v + "','" + Med_Total_I + "','" + Fecha_I + "','" + Med_Total_E + "','" + Pre_C + "','" + Laboratorio + "','" + Tipo + "','" + caja + "');";
            MySqlCommand comando = new MySqlCommand(query, Conexion.connection);
            comando.ExecuteNonQuery();
            Conexion.connection.Close();

        }

        public DataTable tipo()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_TipoMed", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Conexion.connection.Close();
            return tabla;
        }

        public DataTable presentacion()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Presentacion", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Conexion.connection.Close();
            return tabla;
        }

        public DataTable caja()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Almacen", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Conexion.connection.Close();
            return tabla;
        }
        public DataTable D_Laboratorio()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Laboratorio", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Conexion.connection.Close();
            return tabla;
        }
        public DataTable D_Login(string DNI, string password)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT Tra_DNI,Usu_Pass,Usu_Tipo FROM usuario WHERE Tra_DNI = @DNI AND Usu_Pass = @password", Conexion.connection);
            cmd.Parameters.AddWithValue("DNI", DNI);
            cmd.Parameters.AddWithValue("password", password);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Conexion.connection.Close();

            return dt;
        }
        public DataTable D_Consulta_Dinamica(string Busqueda)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Busqueda_Dinamica", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("texto",Busqueda);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Conexion.connection.Close();
            return tabla;

        }
        public DataTable ConsultaUsuario()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_ListaUsuario", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Conexion.connection.Close();
            return tabla;
        }
        public DataTable D_Insertar_Laboratorio(string Nombre, string Direccion, string Telefono)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Insertar_Laboaratorio", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Descripcion", Nombre);
            comando.Parameters.AddWithValue("Direccion", Direccion);
            comando.Parameters.AddWithValue("Telefono", Telefono);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Conexion.connection.Close();

            return dt;

        }
        public DataTable D_TipoDNI()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("P_TipoDNI", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Conexion.connection.Close();
            return tabla;
        }
        public DataTable D_CargoTrabajador()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("P_CargoTrabajador", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Conexion.connection.Close();
            return tabla;
        }
        public DataTable D_Medicamento_Detallado(int ID_Medicamento)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("P_Detalles_Medicamento", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Medicamento_ID", ID_Medicamento);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Conexion.connection.Close();
            return dt;
        }
        public DataTable D_Insertar_Trabajador(string DNI,string Nombre, string Apellido, string Fecha_N,string Direccion,String Telefono,int Tipo,int Cargo)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Ingresar_Trabajador", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Tra_DNI", DNI);
            comando.Parameters.AddWithValue("Tra_Nombre", Nombre);
            comando.Parameters.AddWithValue("Tra_Apellido", Apellido);
            comando.Parameters.AddWithValue("Tra_Nacimiento", Fecha_N);
            comando.Parameters.AddWithValue("Tra_Correo", Direccion);
            comando.Parameters.AddWithValue("Tra_Telefono", Telefono);
            comando.Parameters.AddWithValue("Tid_Codigo", Tipo);
            comando.Parameters.AddWithValue("Car_Codigo", Cargo);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Conexion.connection.Close();

            return dt;

        }



    }
}
