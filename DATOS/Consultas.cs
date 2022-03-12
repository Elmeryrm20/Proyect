﻿using System;
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
        //public DataTable ConsultaMed(string Nombre, int Cantidad, string Laboratorio, string fecha_v, string Gramage,string Tipo,string caja)
        //{

        //    Conexion.connection.Open();

        //    string query= "INSERT INTRO medicamento(Med_Composicion, Med_Fecha_V, Med_Total_I, Med_Fecha_I, Med_Total_E, Pre_C, Lab_C, Tip_C, Alm_C) value ('"+Nombre +"','"+Cantidad +"');";
        //    MySqlCommand comando = new MySqlCommand(query, Conexion.connection);
        //    comando.ExecuteNonQuery();
        //    Conexion.connection.Close();
        //}
        public DataTable tipo()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SELECT Tip_Descripcion FROM TipoMed", Conexion.connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Conexion.connection.Close();
            return tabla;
        }
        public DataTable caja()
        {
            Conexion.connection.Open();

            MySqlCommand comando = new MySqlCommand("SELECT Alm_Descripcion FROM Almacen", Conexion.connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Conexion.connection.Close();
            return tabla;
        }
    }
}
