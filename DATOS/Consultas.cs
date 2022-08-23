using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DATOS
{
    public class Consultas
    {
        D_Empleado de = new D_Empleado();

        #region Abrir y Cerrar Conección
        public void AbrirConexion()
        {

            try
            {
                de.connection.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("No se ha podido establecer la conección.");
            }

        }
        public void CerrarConexion()
        {
            de.connection.Close();
        }
        #endregion

        #region Rellenar ComboBox
        public DataTable D_TipoDNI()
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_TipoDNI", de.connection);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_CargoTrabajador()
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_CargoTrabajador", de.connection);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_TipoTrabajador()
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_TipoTrabajador", de.connection);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_EstadoTrabajador()
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_EstadoTrabajador", de.connection);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_ListaPresentacion()
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Lista_Presentacion", de.connection);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_Lista_Almacen(byte Filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Lista_Almacen", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("CodigoFilial", Filial);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_Pertenencia()
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Pertenencia", de.connection);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_Laboratorio()
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Laboratorio", de.connection);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_Lista_Filial()
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Lista_Filial", de.connection);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_MostrarColaboradores(string DNI, int Filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_MostrarColaboradores", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("DNI", DNI);
            comando.Parameters.AddWithValue("CodigoFilial", Filial);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_MostrarCoordinadores(string DNI, int Filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_MostrarCoordinadores", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("DNI", DNI);
            comando.Parameters.AddWithValue("CodigoFilial", Filial);

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
            de.connection.Close();
            return tabla;
        }
        #endregion

        #region Login
        public DataTable D_Login(string DNI)
        {
            AbrirConexion();

            MySqlCommand cmd = new MySqlCommand("SP_Login", de.connection);
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
            de.connection.Close();

            return dt;
        }
        public DataTable D_Login(string DNI, string password)
        {
            de.connection.Open();
            string query = "SELECT Tra_DNI AS 'DNI', Usu_PASS AS 'Constraseña', Usu_Tipo AS 'Tipo', concat(Tra_Nombre,' ',Tra_Apellido) AS 'Nombre' FROM trabajador WHERE Tra_DNI='" + DNI + "';";
            MySqlCommand comando = new MySqlCommand(query, de.connection);
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
            de.connection.Close();
            return dt;

        }
        public DataTable D_Validacion_Pass(string DNI)
        {
            de.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Verificar_Pass", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("texto", DNI);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            de.connection.Close();

            return dt;
        }
        #endregion

        #region Rellenar DatagridView
        public DataTable D_CategoriasMedicamentos()
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_CategoriasMedicamentos", de.connection);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_MayoresEgresos()
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_MayoresEgresos", de.connection);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_UltimosAgotados()
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_UltimosAgotados", de.connection);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_UltimosEgresos()
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_UltimosEgresos", de.connection);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable ConsultaMed(int Filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Consulta_Medicamento_Basico", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Filial", Filial);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_HistorialIngreso(int Filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_HistorialIngreso", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Filial", Filial);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_HistorialEgreso(int Filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_HistorialEgreso", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Filial", Filial);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_Lista_Stock(int CodigoMedicamento)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Lista_Stock", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Medicamento_Codigo", CodigoMedicamento);
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
            de.connection.Close();
            return tabla;
        }
        public DataTable D_Lista_Usuario(byte Filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_ListaUsuario", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("CodigoFilial", Filial);
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
            de.connection.Close();
            return tabla;
        }
        #endregion

        #region Insertar o Actualizar Base de Datos
        public void D_AgregarDestino(string DNI, string Nombres, string Apellidos, string Nacionalidad, string Telefono, int TipoDNI)
        {
            de.connection.Open();

            MySqlCommand cmd = new MySqlCommand("Sp_AgregarDestino", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("DNI", DNI);
            cmd.Parameters.AddWithValue("Nombres", Nombres);
            cmd.Parameters.AddWithValue("Apellidos", Apellidos);
            cmd.Parameters.AddWithValue("Nacionalidad", Nacionalidad);
            cmd.Parameters.AddWithValue("Telefono", Telefono);
            cmd.Parameters.AddWithValue("Tipo_DNI", TipoDNI);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            de.connection.Close();
        }
        public void SP_Editar_Usuario(string DNI, string Nombre, string Apellido, string fecha_N, string Correo, string Telefono, int Tipo, int Cargo, int Estado, int Filial)
        {
            de.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Editar_Usuario", de.connection);
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
            cmd.Parameters.AddWithValue("CodigoFilial", Filial);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            de.connection.Close();

        }
        public void SP_Restablecer_C(string DNI)
        {
            de.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SP_Restablecer_C", de.connection);
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
            de.connection.Close();
        }
        public void D_AgregarMedicamento(string Med_Composicion, int Med_Total_I, int Laboratorio, string fecha_v, int Tipo, int caja, int Med_Total_E, byte[] imagen, int Pertenencia, int Filial)
        {

            de.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SP_Ingresar_Medicamento", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Composicion", Med_Composicion);
            cmd.Parameters.AddWithValue("fecha_V", fecha_v);
            cmd.Parameters.AddWithValue("cantidad_I", Med_Total_I);
            cmd.Parameters.AddWithValue("cantidad_E", Med_Total_E);
            cmd.Parameters.AddWithValue("lab", Laboratorio);
            cmd.Parameters.AddWithValue("tipo", Tipo);
            cmd.Parameters.AddWithValue("alm", caja);
            cmd.Parameters.AddWithValue("imagen", imagen);
            cmd.Parameters.AddWithValue("per", Pertenencia);
            cmd.Parameters.AddWithValue("filial", Filial);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            de.connection.Close();

        }
        public void D_Insertar_Trabajador(string DNI, string Nombre, string Apellido, string Fecha_N, string Direccion, string Telefono, int Tipo, int Cargo, int Filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Ingresar_Trabajador", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Tra_DNI", DNI);
            comando.Parameters.AddWithValue("Tra_Nombre", Nombre);
            comando.Parameters.AddWithValue("Tra_Apellido", Apellido);
            comando.Parameters.AddWithValue("Tra_Nacimiento", Fecha_N);
            comando.Parameters.AddWithValue("Tra_Correo", Direccion);
            comando.Parameters.AddWithValue("Tra_Telefono", Telefono);
            comando.Parameters.AddWithValue("Tid_Codigo", Tipo);
            comando.Parameters.AddWithValue("Car_Codigo", Cargo);
            comando.Parameters.AddWithValue("Fil_Codigo", Filial);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            de.connection.Close();


        }
        public void D_Insertar_Laboratorio(string Nombre, string Direccion, string Telefono)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Insertar_Laboratorio", de.connection);
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
            de.connection.Close();

        }
        public void D_Agregar_Pass(string DNI, string password)
        {
            de.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Pass", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("DNI", DNI);
            cmd.Parameters.AddWithValue("Pass", password);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            de.connection.Close();

        }
        public void D_ActualizarIngreso(string DNI, string Fecha, string Colaborador, string Coordinador)
        {
            de.connection.Open();

            MySqlCommand cmd = new MySqlCommand("Sp_AgregarIngreso", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Ingreso_Fecha", Fecha);
            cmd.Parameters.AddWithValue("Trabajador_DNI", DNI);
            cmd.Parameters.AddWithValue("Colaborador_DNI", Colaborador);
            cmd.Parameters.AddWithValue("Coordinador_DNI", Coordinador);
            //MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd); 
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            de.connection.Close();
            //return tabla;

        }
        public void SP_Agregar_Detalle_Ingreso(int Ing_Codigo, int Med_Codigo, int Cantidad, string FechaVencimiento, int Laboratorio)
        {
            //Conexion.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Detalle_Ingreso", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Ingreso_Codigo", Ing_Codigo);
            cmd.Parameters.AddWithValue("Medicamento_Codigo", Med_Codigo);
            cmd.Parameters.AddWithValue("Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("Fecha_Vencimiento", FechaVencimiento);
            cmd.Parameters.AddWithValue("Laboratorio_Codigo", Laboratorio);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            //Conexion.connection.Close();
        }
        public void D_ActualizarEgreso(string Fecha, string Tra_DNI, string Nacionalidad, string Colaborador, string Coordinador)
        {
            de.connection.Open();
            MySqlCommand cmd = new MySqlCommand("Sp_AgregarEgreso", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Egreso_Fecha", Fecha);
            cmd.Parameters.AddWithValue("Trabajador_DNI", Tra_DNI);
            cmd.Parameters.AddWithValue("Egreso_Nacionalidad", Nacionalidad);
            cmd.Parameters.AddWithValue("Colaborador_DNI", Colaborador);
            cmd.Parameters.AddWithValue("Coordinador_DNI", Coordinador);
            //MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            de.connection.Close();
            //return Convert.ToInt32(tabla.Rows[0][0]);
        }
        public void SP_Agregar_Detalle_Egreso(int Egr_Codigo, int Med_Codigo, int Cantidad, int Semana, int Laboratorio)
        {
            //Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Detalle_Egreso", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Egreso_Codigo", Egr_Codigo);
            cmd.Parameters.AddWithValue("Medicamento_Codigo", Med_Codigo);
            cmd.Parameters.AddWithValue("Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("Numero_Semana", Semana);
            cmd.Parameters.AddWithValue("Laboratorio_Codigo", Laboratorio);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //Conexion.connection.Close();

        }
        public void SP_Editar_Producto(int codigo, string composicion, string fecha, int tip, int alm, byte[] imagen, int per)
        {
            de.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Editar_Producto", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codigo", codigo);
            cmd.Parameters.AddWithValue("composicion", composicion);
            cmd.Parameters.AddWithValue("fecha", fecha);
            cmd.Parameters.AddWithValue("tip", tip);
            cmd.Parameters.AddWithValue("alm", alm);
            cmd.Parameters.AddWithValue("imagen", imagen);
            cmd.Parameters.AddWithValue("per", per);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            de.connection.Close();
        }
        public void SP_Agregar_Almacen(string Almacen, int Filial)
        {
            de.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Almacen", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre", Almacen);
            cmd.Parameters.AddWithValue("CodigoFilial", Filial);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            de.connection.Close();
        }
        public void SP_Agregar_Pertenencia(string Descripcion, string Telefono)
        {
            de.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Pertenencia", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Descripcion", Descripcion);
            cmd.Parameters.AddWithValue("Telefono", Telefono);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            de.connection.Close();
        }
        public void SP_Eliminar_U(string DNI, int Estado)
        {
            de.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Eliminar_U", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("DNI", DNI);
            cmd.Parameters.AddWithValue("ESTADO", Estado);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            de.connection.Close();
        }
        public void D_Agregar_Nuevo_Stock(int CodigoMedicamento, int CodigoLaboratorio, string FechaVencimiento, int Cantidad)
        {
            //Conexion.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Nuevo_Stock", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Medicamento_Codigo", CodigoMedicamento);
            cmd.Parameters.AddWithValue("Laboratorio_Codigo", CodigoLaboratorio);
            cmd.Parameters.AddWithValue("Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("Fecha_Vencimiento", FechaVencimiento);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //Conexion.connection.Close();
        }
        public void D_Actualizar_Stock(int CodigoMedicamento, int CodigoLaboratorio, string FechaVencimiento, int Cantidad)
        {
            //Conexion.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SP_Actualizar_Stock", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Medicamento_Codigo", CodigoMedicamento);
            cmd.Parameters.AddWithValue("Laboratorio_Codigo", CodigoLaboratorio);
            cmd.Parameters.AddWithValue("Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("Fecha_Vencimiento", FechaVencimiento);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //Conexion.connection.Close();
        }
        #endregion

        #region Consultas
        public bool D_Verificar_Stock(int CodigoMedicamento, int CodigoLaboratorio, string FechaVencimiento)
        {
            //Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Verificar_Stock", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Medicamento_Codigo", CodigoMedicamento);
            comando.Parameters.AddWithValue("Laboratorio_Codigo", CodigoLaboratorio);
            comando.Parameters.AddWithValue("Fecha_Vencimiento", FechaVencimiento);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Conexion.connection.Close();
            return Convert.ToBoolean(dt.Rows[0][0]);
        }
        public DataTable SP_Existencia_T(string DNI)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Existencia_T", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("DNI", DNI);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            de.connection.Close();
            return dt;
        }
        public int D_UltimoIdIngresado()
        {
            de.connection.Open();
            MySqlCommand comando = new MySqlCommand("SP_UltimoIdInsertado", de.connection);
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
            de.connection.Close();
            return Convert.ToInt32(tabla.Rows[0][0]);
        }
        public DataTable D_Busqueda_Dinamica(string Busqueda, int filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Busqueda_Dinamica", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("texto", Busqueda);
            comando.Parameters.AddWithValue("Filial", filial);
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
            de.connection.Close();
            return tabla;

        }
        public DataTable D_Detalles_Medicamento(int ID_Medicamento)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Detalles_Medicamento", de.connection);
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
            de.connection.Close();
            return dt;
        }
        public DataTable SP_ListaU_Para_Edit(string Med_Codigo)
        {
            de.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SP_ListaU_Para_Edit", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Codigo", Med_Codigo);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            de.connection.Close();
            return dt;
        }
        public DataTable D_DashBoard_Indicadores(string fecha1, string fecha2)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_DashBoard_Indicadores", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("fecha1", fecha1);
            comando.Parameters.AddWithValue("fecha2", fecha2);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            de.connection.Close();
            return dt;
        }
        #endregion

        #region Filtros
        public DataTable D_Filtro_Medicamento_Presentacion(int Presentacion, int filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Filtro_Medicamento_Presentacion", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Presentacion", Presentacion);
            comando.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            de.connection.Close();
            return dt;

        }
        public DataTable D_Filtro_Medicamento_Almacen(int Almacen, int filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Filtro_Medicamento_Almacen", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Almacen", Almacen);
            comando.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            de.connection.Close();
            return dt;
        }
        public DataTable D_Filtro_Medicamento_Ambos(int Almacen, int Presentacion, int filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Filtro_Medicamento_Ambos", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Almacen", Almacen);
            comando.Parameters.AddWithValue("Presentacion", Presentacion);
            comando.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            de.connection.Close();
            return dt;
        }
        public DataTable Sp_Filtro_Fecha_HI(string Fecha1, string fecha2, int filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_Filtro_Fecha_HI", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Fecha1", Fecha1);
            comando.Parameters.AddWithValue("fecha2", fecha2);
            comando.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            de.connection.Close();
            return dt;
        }
        public DataTable Sp_Filtro_Fecha_HE(string Fecha1, string fecha2, int filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_Filtro_Fecha_HE", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Fecha1", Fecha1);
            comando.Parameters.AddWithValue("fecha2", fecha2);
            comando.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            de.connection.Close();
            return dt;
        }
        public DataTable Sp_Filtro_Dinamico_HI(string texto, int filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_Filtro_Dinamico_HI", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("texto", texto);
            comando.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            de.connection.Close();
            return dt;
        }
        public DataTable Sp_Filtro_Dinamico_HE(string texto, int filial)
        {
            de.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_Filtro_Dinamico_HE", de.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("texto", texto);
            comando.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            de.connection.Close();
            return dt;
        }
        public DataTable Sp_Medicamentos_por_Ago_Ven(int filial)
        {
            de.connection.Open();

            MySqlCommand cmd = new MySqlCommand("Sp_Medicamentos_por_Ago_Ven", de.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            de.connection.Close();
            return dt;
        }
        #endregion

    }
}
