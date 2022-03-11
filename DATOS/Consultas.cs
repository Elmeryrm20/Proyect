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

            MySqlCommand comando = new MySqlCommand("SELECT * FROM medicamento", Conexion.connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Conexion.connection.Close();
            return tabla;
        }

    }
}
