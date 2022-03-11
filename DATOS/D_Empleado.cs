using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DATOS
{
    public class D_Empleado
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=inventario; Uid=root2;Pwd=root2;");

        public int conexionexitosa()
        {
            try
            {
                connection.Open();
                //connection.Close();
                return 1;

            }
            catch (Exception)
            {
                return 0;
                throw;
            }
            
        }

    }
}
