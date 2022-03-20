using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DATOS
{
    public class Consultas
    {
        D_Empleado Conexion = new D_Empleado();

        #region Rellenar ComboBox
        public DataTable D_TipoDNI()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("P_TipoDNI", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Conexion.connection.Close();
            return tabla;
        }
        public DataTable tipo()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_TipoMed", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Conexion.connection.Close();
            return tabla;
        }
        #endregion

        #region Login
        public DataTable D_Login(string DNI)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Login", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("DNI", DNI);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Conexion.connection.Close();

            return dt;
        }

        public DataTable D_Login(string DNI, string password)
        {
            Conexion.connection.Open();
            string query = "SELECT Tra_DNI AS 'DNI', Usu_PASS AS 'Constraseña', Usu_Tipo AS 'Tipo', concat(Tra_Nombre,' ',Tra_Apellido) AS 'Nombre' FROM trabajador WHERE Tra_DNI='" + DNI + "';";
            MySqlCommand comando = new MySqlCommand(query, Conexion.connection);
            comando.ExecuteNonQuery();
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Conexion.connection.Close();
            return dt;

        } 
        #endregion

        #region Rellenar DatagridView
        public DataTable ConsultaMed()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Consulta_Medicamento_Basico", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Conexion.connection.Close();
            return tabla;
        }
        #endregion

        #region Insertar o Actualizar Base de Datos
        public void SP_Editar_Usuario(string DNI, string Nombre, string Apellido, string fecha_N, string Correo, string Telefono, int Tipo, int Cargo, int Estado)
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
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Conexion.connection.Close();

        }
        public void SP_Restablecer_C(string DNI)
        {
            Conexion.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SP_Restablecer_C", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("DNI", DNI);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Conexion.connection.Close();
        }
        public void D_AgregarMedicamento(string Med_Composicion, int Med_Total_I, int Laboratorio, string fecha_v, int Tipo, int caja, string Fecha_I, int Med_Total_E, int Pre_C, byte[] imagen)
        {

            Conexion.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SP_Ingresar_Medicamento", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Composicion", Med_Composicion);
            cmd.Parameters.AddWithValue("fecha_V", fecha_v);
            cmd.Parameters.AddWithValue("cantidad_I", Med_Total_I);
            cmd.Parameters.AddWithValue("fecha_i", Fecha_I);
            cmd.Parameters.AddWithValue("cantidad_E", Med_Total_E);
            cmd.Parameters.AddWithValue("pre", Pre_C);
            cmd.Parameters.AddWithValue("lab", Laboratorio);
            cmd.Parameters.AddWithValue("tipo", Tipo);
            cmd.Parameters.AddWithValue("alm", caja);
            cmd.Parameters.AddWithValue("imagen", imagen);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Conexion.connection.Close();

        }
        public void D_Insertar_Trabajador(string DNI, string Nombre, string Apellido, string Fecha_N, string Direccion, String Telefono, int Tipo, int Cargo)
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

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Conexion.connection.Close();


        }
        public void D_Insertar_Laboratorio(string Nombre, string Direccion, string Telefono)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Insertar_Laboaratorio", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Descripcion", Nombre);
            comando.Parameters.AddWithValue("Direccion", Direccion);
            comando.Parameters.AddWithValue("Telefono", Telefono);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Conexion.connection.Close();

        }
        public void D_Agregar_Contraseña(string DNI, string password)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Contraseña", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("DNI", DNI);
            cmd.Parameters.AddWithValue("Contraseña", password);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            Conexion.connection.Close();

        }
        public void SP_Agregar_Ingreso_Medicamento(int Cod_Medicamento, int Cantidad, string Fecha_Actual)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Ingreso_Medicamento", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Cod_Medicamento", Cod_Medicamento);
            cmd.Parameters.AddWithValue("Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("Fecha_Actual", Fecha_Actual);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            Conexion.connection.Close();

        }
        public void D_ActualizarEgreso(int Med_id, int CantidadEgresada)
        {
            Conexion.connection.Open();
            MySqlCommand cmd = new MySqlCommand("Sp_ActualizarEgreso", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Med_id", Med_id);
            cmd.Parameters.AddWithValue("Cantidad", CantidadEgresada);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Conexion.connection.Close();
        }

        public void SP_Agregar_Detalle_Ingreso(int Med_Codigo, int Cantidad, string Ing_Fecha, string Tra_DNI, string Dei_Fecha_V)
        {
            Conexion.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Detalle_Ingreso", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Med_Codigo", Med_Codigo);
            cmd.Parameters.AddWithValue("Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("Ing_Fecha", Ing_Fecha);
            cmd.Parameters.AddWithValue("Tra_DNI", Tra_DNI);
            cmd.Parameters.AddWithValue("Dei_Fecha_V", Dei_Fecha_V);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Conexion.connection.Close();

        }

        public void SP_Agregar_Detalle_Egreso(int Med_Codigo, int Cantidad, string Egr_Fecha, string Tra_DNI, int Dee_N_Semana)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Detalle_Egreso", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Med_Codigo", Med_Codigo);
            cmd.Parameters.AddWithValue("Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("Egr_Fecha", Egr_Fecha);
            cmd.Parameters.AddWithValue("Tra_DNI", Tra_DNI);
            cmd.Parameters.AddWithValue("Dee_N_Semana", Dee_N_Semana);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Conexion.connection.Close();

        }
        public void SP_Editar_Producto(int codigo, string composicion, string fecha, int pre, int lab, int tip, int alm, byte[] imagen)
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
            cmd.Parameters.AddWithValue("imagen", imagen);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Conexion.connection.Close();
        }
        #endregion

        public DataTable D_Consulta_Dinamica(string Busqueda)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Busqueda_Dinamica", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("texto", Busqueda);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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

        public DataTable SP_Consulta_Medicamento_Filtrado(string Tipo)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Consulta_Medicamento_Filtrado", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Tipo", Tipo);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;

        }
    }
}
