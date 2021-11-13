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
    public class EstadoTicketDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
       

        public bool InsertarEstadoTicket(EstadoTicket estado)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ESTADOTICKET ");
                sql.Append(" VALUES (@NombreCliente, @FechaSolicitud, @Estado); ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@NombreCliente", SqlDbType.NVarChar, 100).Value = estado.NombreCliente; 
                comando.Parameters.Add("@FechaSolicitud", SqlDbType.DateTime).Value = estado.FechaSolicitud;
                comando.Parameters.Add("@Estado", SqlDbType.NVarChar, 80).Value = estado.Estado;
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

        public string ConsultaNombre()
        {
            string query = "SELECT * FROM TIPODESOPORTE";
            comando.Connection = MiConexion;
            //MiConexion.Open();
            SqlCommand cmd = new SqlCommand(query, MiConexion);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                return reg["NOMBRECLIENTE"].ToString();
            }
            else
            {
                return "NULL";
            }
            //MiConexion.Close();

        }
    }
}
