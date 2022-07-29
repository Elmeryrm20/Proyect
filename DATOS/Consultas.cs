using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DATOS
{
    public class Consultas
    {
        D_Empleado Conexion = new D_Empleado();

        public void AbrirConexion()
        {
            
            try
            {
                Conexion.connection.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("No se ha podido establecer la conección.");
            }

        }
        public void CerrarConexion()
        {
            Conexion.connection.Close();
        }

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
        public DataTable D_Pertenencia()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Pertenencia", Conexion.connection);
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
        public DataTable D_MostrarColaboradores(string DNI)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_MostrarColaboradores", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("DNI", DNI);
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
        public DataTable D_MostrarCoordinadores(string DNI)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_MostrarCoordinadores", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("DNI", DNI);
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
            AbrirConexion();

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
        public DataTable D_Validacion_Pass(string DNI)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Verificar_Pass", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("texto", DNI);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Conexion.connection.Close();

            return dt;
        }
        #endregion

        #region Rellenar DatagridView
        public DataTable D_CategoriasMedicamentos()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_CategoriasMedicamentos", Conexion.connection);
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
        public DataTable D_MayoresEgresos()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_MayoresEgresos", Conexion.connection);
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

        public DataTable D_UltimosAgotados()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_UltimosAgotados", Conexion.connection);
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

        public DataTable D_UltimosEgresos()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_UltimosEgresos", Conexion.connection);
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
        public DataTable ConsultaMed( int Filial)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Consulta_Medicamento_Basico", Conexion.connection);
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
            Conexion.connection.Close();
            return tabla;
        }

        public DataTable D_HistorialIngreso(int Filial)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_HistorialIngreso", Conexion.connection);
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
            Conexion.connection.Close();
            return tabla;
        }

        public DataTable D_HistorialEgreso(int Filial)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_HistorialEgreso", Conexion.connection);
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
        public void D_AgregarDestino(string DNI, string Nombres, string Apellidos, string Nacionalidad, string Telefono, int TipoDNI)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("Sp_AgregarDestino", Conexion.connection);
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
            Conexion.connection.Close();
        }

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
        public void D_AgregarMedicamento(string Med_Composicion, int Med_Total_I, int Laboratorio, string fecha_v, int Tipo, int caja, string Fecha_I, int Med_Total_E, byte[] imagen, int Pertenencia)
        {

            Conexion.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SP_Ingresar_Medicamento", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Composicion", Med_Composicion);
            cmd.Parameters.AddWithValue("fecha_V", fecha_v);
            cmd.Parameters.AddWithValue("cantidad_I", Med_Total_I);
            cmd.Parameters.AddWithValue("fecha_i", Fecha_I);
            cmd.Parameters.AddWithValue("cantidad_E", Med_Total_E);
            cmd.Parameters.AddWithValue("lab", Laboratorio);
            cmd.Parameters.AddWithValue("tipo", Tipo);
            cmd.Parameters.AddWithValue("alm", caja);
            cmd.Parameters.AddWithValue("imagen", imagen);
            cmd.Parameters.AddWithValue("per", Pertenencia);
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
        public void D_Insertar_Trabajador(string DNI, string Nombre, string Apellido, string Fecha_N, string Direccion, string Telefono, int Tipo, int Cargo)
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
        public void D_Agregar_Pass(string DNI, string password)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Pass", Conexion.connection);
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

            Conexion.connection.Close();

        }
        public void D_ActualizarIngreso(string DNI, string Fecha, string Colaborador, string Coordinador)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("Sp_AgregarIngreso", Conexion.connection);
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
            Conexion.connection.Close();
            //return tabla;

        }

        public void SP_Agregar_Detalle_Ingreso(int Ing_Codigo, int Med_Codigo, int Cantidad, string FechaVencimiento, int Laboratorio)
        {
            //Conexion.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Detalle_Ingreso", Conexion.connection);
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
            Conexion.connection.Open();
            MySqlCommand cmd = new MySqlCommand("Sp_AgregarEgreso", Conexion.connection);
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
            Conexion.connection.Close();
            //return Convert.ToInt32(tabla.Rows[0][0]);
        }
        public void SP_Agregar_Detalle_Egreso(int Egr_Codigo, int Med_Codigo, int Cantidad, int Semana)
        {
            //Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Detalle_Egreso", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Egreso_Codigo", Egr_Codigo);
            cmd.Parameters.AddWithValue("Medicamento_Codigo", Med_Codigo);
            cmd.Parameters.AddWithValue("Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("Numero_Semana", Semana);
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
        public void SP_Editar_Producto(int codigo, string composicion, string fecha, int lab, int tip, int alm, byte[] imagen, int per)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Editar_Producto", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codigo", codigo);
            cmd.Parameters.AddWithValue("composicion", composicion);
            cmd.Parameters.AddWithValue("fecha", fecha);
            cmd.Parameters.AddWithValue("lab", lab);
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
            Conexion.connection.Close();
        }
        #endregion

        #region Consultas
        public bool D_VerificarPersona(string DNI)
        {
            Conexion.connection.Open();
            MySqlCommand comando = new MySqlCommand("SP_VerificarPersona", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("DNI", DNI);
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
            return Convert.ToBoolean(tabla.Rows[0][0]);
        }

        public int D_UltimoIdIngresado()
        {
            Conexion.connection.Open();
            MySqlCommand comando = new MySqlCommand("SP_UltimoIdInsertado", Conexion.connection);
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
            return Convert.ToInt32(tabla.Rows[0][0]);
        }

        public DataTable D_Consulta_Dinamica(string Busqueda ,int filial)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Busqueda_Dinamica", Conexion.connection);
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
        public DataTable SP_Consulta_Medicamento_Filtrado(string Tipo , int filial)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Consulta_Medicamento_Filtrado", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Tipo", Tipo);
            comando.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;

        }
        public DataTable D_DashBoard_Indicadores(string fecha1, string fecha2)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_DashBoard_Indicadores", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("fecha1", fecha1);
            comando.Parameters.AddWithValue("fecha2", fecha2);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }
        #endregion

        public void SP_Eliminar_U(String DNI, int Estado)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Eliminar_U", Conexion.connection);
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
            Conexion.connection.Close();
        }
        public DataTable SP_Existencia_T(string DNI)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Existencia_T", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("DNI", DNI);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }
        public DataTable P_AlmMedicamento()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("P_AlmMedicamento", Conexion.connection);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }
        public DataTable SP_Medicamento_Filtrado_Almacen(string Almacen ,int filial)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Medicamento_Filtrado_Almacen", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Almacen", Almacen);
            comando.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }
        public DataTable SP_Medicamento_Filtrado_Ambos(string Almacen, string tipo ,int filial)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SP_Medicamento_Filtrado_Ambos", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Almacen", Almacen);
            comando.Parameters.AddWithValue("tipo", tipo);
            comando.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }
        public DataTable Sp_Filtro_Fecha_HI(string Fecha1, string fecha2, int filial)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_Filtro_Fecha_HI", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Fecha1", Fecha1);
            comando.Parameters.AddWithValue("fecha2", fecha2);
            comando.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }
        public DataTable Sp_Filtro_Fecha_HE(string Fecha1, string fecha2, int filial)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_Filtro_Fecha_HE", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Fecha1", Fecha1);
            comando.Parameters.AddWithValue("fecha2", fecha2);
            comando.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }
        public DataTable Sp_Filtro_Dinamico_HI(string texto, int filial)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_Filtro_Dinamico_HI", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("texto", texto);
            comando.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }
        public DataTable Sp_Filtro_Dinamico_HE(string texto ,int filial)
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("Sp_Filtro_Dinamico_HE", Conexion.connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("texto", texto);
            comando.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }

        public void SP_Agregar_Almacen(String Almacen)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Almacen", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre", Almacen);
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
        public void SP_Agregar_Pertenencia(String Descripcion, string Telefono)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("SP_Agregar_Pertenencia", Conexion.connection);
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
            Conexion.connection.Close();
        }
        public DataTable Sp_Medicamentos_por_Ago_Ven( int filial)
        {
            Conexion.connection.Open();

            MySqlCommand cmd = new MySqlCommand("Sp_Medicamentos_por_Ago_Ven", Conexion.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Filial", filial);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.connection.Close();
            return dt;
        }

    }
}
