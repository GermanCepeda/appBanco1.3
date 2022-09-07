using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace appBanco1._3
{
    internal class DBHelper
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-M3PQNHH\SQLEXPRESS;Initial Catalog=BancoPO;Integrated Security=True");
        SqlCommand comando = new SqlCommand();

        public void Conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }

        public void Desconectar()
        {
            conexion.Close();
        }

        public DataTable ConsultaSQL(string NombreSP)
        {
            Conectar();
            DataTable tabla = new DataTable();
            comando.CommandText = NombreSP;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public DataTable BuscarID(string NombreSP, string dni)
        {
            Conectar();
            DataTable tabla = new DataTable();
            comando.CommandText = NombreSP;
            comando.Parameters.AddWithValue("@dni", dni);
            tabla.Load(comando.ExecuteReader());
            comando.Parameters.Clear();
            Desconectar();
            return tabla;
        }

        public DataTable BuscarCuenta(string NombreSP, int idCliente)
        {
            Conectar();
            DataTable tabla = new DataTable();
            comando.CommandText = NombreSP;
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            tabla.Load(comando.ExecuteReader());
            comando.Parameters.Clear();
            Desconectar();
            return tabla;
        }

        public void InsertarCliente(string nombre, string apellido, int dni,int id_tipo_cuenta)
        {
            Conectar();
            comando.CommandText = "spInsertarCliente";
            comando.Parameters.AddWithValue("@nom_cliente", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@dni", dni);
            comando.Parameters.AddWithValue("@id_tipo_cuenta", id_tipo_cuenta);
            comando.Parameters.AddWithValue("@Activo", "");
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            Desconectar();
        }

        public void InsertarCuenta(int id_cliente, double saldo, int id_tipo_cuenta)
        {
            Conectar();
            comando.Parameters.Clear();
            comando.CommandText = "spInsertarCuenta2";
            comando.Parameters.AddWithValue("@id_cliente", id_cliente);
            comando.Parameters.AddWithValue("@saldo", saldo);
            comando.Parameters.AddWithValue("@id_tipo_cuenta", id_tipo_cuenta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            Desconectar();
        }

        public void DarBaja (int id_cliente)
        {
            Conectar();
            comando.CommandText = "spDarBaja";
            comando.Parameters.AddWithValue("@id_cliente", id_cliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            Desconectar();

        }

        public void DarAlta(int id_cliente)
        {
            Conectar();
            comando.CommandText = "spDarAlta";
            comando.Parameters.AddWithValue("@id_cliente", id_cliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            Desconectar();

        }
    }
}
