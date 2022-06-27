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
       public MySqlConnection connection = new MySqlConnection("Server=crp2022.mysql.database.azure.com; Port=3306; Database=inventario; Uid=admi@crp2022; Pwd=Cruz(123); SslMode=Preferred;");

        //public int conexionexitosa()
        //{
        //    try
        //    {
        //        connection.Open();
        //        //connection.Close();
        //        return 1;

        //    }
        //    catch (Exception)
        //    {
        //        return 0;
        //        throw;
        //    }
            
        //}

    }
}
