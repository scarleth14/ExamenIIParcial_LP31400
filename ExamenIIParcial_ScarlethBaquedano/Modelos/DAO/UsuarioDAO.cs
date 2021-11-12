using ExamenIIParcial_ScarlethBaquedano.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIIParcial_ScarlethBaquedano.Modelos.DAO
{
    public class UsuarioDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool ValidarUsuario(Usuario user)
        {
            bool valido = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT 1 FROM USUARIO WHERE EMAIL = @Email AND CONTRASENA = @Contrasena;");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = user.Email;
                comando.Parameters.Add("@Contrasena", SqlDbType.NVarChar, 100).Value = user.Contrasena;
                valido = Convert.ToBoolean(comando.ExecuteScalar());
            }
            catch (Exception)
            {

            }
            return valido;
        }

        public bool CrearNuevoUsuario(Usuario user)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO USUARIO ");
                sql.Append(" VALUES (@Nombre, @Email, @Contrasena ); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = user.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = user.Email;
                comando.Parameters.Add("@Contrasena", SqlDbType.NVarChar, 100).Value = user.Contrasena;
                comando.ExecuteNonQuery();
                inserto = true;
                MiConexion.Close();
                
            }
            catch (Exception)
            {
                inserto = false;
            }
            return inserto;

        }


    }
}
