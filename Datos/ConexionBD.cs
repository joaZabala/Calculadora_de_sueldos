using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ConexionBD
    {
        string cadena = @"Data Source=DESKTOP-NMS8A8J\SQLEXPRESS;Initial Catalog=liquidacion_sueldo;Integrated Security=True";
        SqlConnection conexion;
        SqlCommand comando;

        public ConexionBD()
        {
            conexion = new SqlConnection(cadena);
            comando = new SqlCommand(); 
        }

        public void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType=CommandType.Text;
        }

        public DataTable consutartabla(string tabla)
        {
            DataTable dt = new DataTable();
            conectar();
            comando.CommandText = " SELECT * FROM " + tabla;
            dt.Load(comando.ExecuteReader());
            desconectar();
            return dt;
        }

        public int modificarBD( string consulta,Trabajador t)
        {
            int filas = 0;
            conectar();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@cuil", t.Cuil);
            comando.Parameters.AddWithValue("@nombre", t.Nombre);
            comando.Parameters.AddWithValue("@apellido", t.Apellido);
            comando.Parameters.AddWithValue("@sueldo_hora", t.SueldoXhora);
            comando.Parameters.AddWithValue("@id_puesto", t.Puesto);
            comando.Parameters.AddWithValue("@cant_hijos", t.CantidadHijos);
            comando.Parameters.AddWithValue("@sueldo", t.Sueldo);
            filas = comando.ExecuteNonQuery();
            desconectar();
            return filas;
        }
        public void desconectar()
        {
            conexion.Close();   
        }
    }
}
