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

    }
}
