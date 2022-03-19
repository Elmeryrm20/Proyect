using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace DATOS
{
    public class Consultas
    {
        D_Empleado Conexion = new D_Empleado();

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

            MySqlCommand cmd = new MySqlCommand("SP_Login", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("DNI", DNI);
            cmd.Parameters.AddWithValue("PASS", password);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Conexion.connection.Close();

            return dt;
        }
        public DataTable D_Login(string DNI)
        {
            Conexion.connection.Open();
            string query = "SELECT Tra_DNI AS 'DNI', Usu_PASS AS 'Constraseña', Usu_Tipo AS 'Tipo', concat(Tra_Nombre,' ',Tra_Apellido) AS 'Nombre' FROM trabajador WHERE Tra_DNI='" + DNI + "';";
            MySqlCommand comando = new MySqlCommand(query, Conexion.connection);
            comando.ExecuteNonQuery();
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
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
            comando.Parameters.AddWithValue("texto", Busqueda);
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
        public DataTable D_TipoTrabajador()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("P_TipoTrabajador", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Conexion.connection.Close();
            return tabla;
        }
        public DataTable D_EstadoTrabajador()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("P_EstadoTrabajador", Conexion.connection);
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
            comando.Parameters.AddWithValue("Id_Medicamento", ID_Medicamento);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Conexion.connection.Close();
            return dt;
        }
        public DataTable D_Insertar_Trabajador(string DNI, string Nombre, string Apellido, string Fecha_N, string Direccion, String Telefono, int Tipo, int Cargo)
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
        public DataTable D_Validacion_Contraseña(string DNI)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Viricar_Contraseña", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("texto", DNI);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Conexion.connection.Close();

            return dt;
        }
        public DataTable D_Agregar_Contraseña(string DNI, string password)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Contraseña", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("DNI", DNI);
            cmd.Parameters.AddWithValue("Contraseña", password);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();

            return dt;
        }
        public DataTable SP_Agregar_Ingreso_Medicamento(string Cod_Medicamento, string Cantidad, string Fecha_Actual)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Ingreso_Medicamento", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Cod_Medicamento", Cod_Medicamento);
            cmd.Parameters.AddWithValue("Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("Fecha_Actual", Fecha_Actual);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();

            return dt;
        }
        public DataTable SP_Agregar_Egreso_Medicamento(string Med_Codigo, string Cantidad)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Egreso_Medicamento", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Med_Codigo", Med_Codigo);
            cmd.Parameters.AddWithValue("Cantidad", Cantidad);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }
        public DataTable SP_Agregar_Detalle_Ingreso(string Med_Codigo, string Cantidad,string Ing_Fecha,string Tra_DNI,string Dei_Fecha_V)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Detalle_Ingreso", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Med_Codigo", Med_Codigo);
            cmd.Parameters.AddWithValue("Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("Ing_Fecha", Ing_Fecha);
            cmd.Parameters.AddWithValue("Tra_DNI", Tra_DNI);
            cmd.Parameters.AddWithValue("Dei_Fecha_V", Dei_Fecha_V);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }
        public DataTable SP_Agregar_Detalle_Egreso(string Med_Codigo, string Cantidad, string Egr_Fecha, string Tra_DNI, int Dee_N_Semana)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Detalle_Egreso", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Med_Codigo", Med_Codigo);
            cmd.Parameters.AddWithValue("Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("Egr_Fecha", Egr_Fecha);
            cmd.Parameters.AddWithValue("Tra_DNI", Tra_DNI);
            cmd.Parameters.AddWithValue("Dee_N_Semana", Dee_N_Semana);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }
        public DataTable SP_Editar_Producto(int codigo, string composicion, string fecha, int pre, int lab, int tip, int alm)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Editar_Producto", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codigo", codigo);
            cmd.Parameters.AddWithValue("composicion", composicion);
            cmd.Parameters.AddWithValue("fecha", fecha);
            cmd.Parameters.AddWithValue("pre", pre);
            cmd.Parameters.AddWithValue("lab", lab);
            cmd.Parameters.AddWithValue("tip", tip);
            cmd.Parameters.AddWithValue("alm", alm);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }
        public DataTable SP_ListaU_Para_Edit(string Med_Codigo)
        {
            Conexion.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SP_ListaU_Para_Edit", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Codigo", Med_Codigo);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }

        public DataTable SP_Editar_Usuario(string DNI, string Nombre, string Apellido, string fecha_N, string Correo, string Telefono, int Tipo, int Cargo, int Estado)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Editar_Usuario", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("DNI", DNI);
            cmd.Parameters.AddWithValue("Nombre", Nombre);
            cmd.Parameters.AddWithValue("Apellido", Apellido);
            cmd.Parameters.AddWithValue("fecha_N", fecha_N);
            cmd.Parameters.AddWithValue("Correo", Correo);
            cmd.Parameters.AddWithValue("Telefono", Telefono);
            cmd.Parameters.AddWithValue("Tipo", Tipo);
            cmd.Parameters.AddWithValue("Cargo", Cargo);
            cmd.Parameters.AddWithValue("Estado", Estado);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }
        public DataTable SP_Restablecer_C(string DNI)
        {
            Conexion.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SP_Restablecer_C", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("DNI", DNI);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }
    }
}
