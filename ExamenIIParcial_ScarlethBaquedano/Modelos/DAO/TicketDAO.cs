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
    public class TicketDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarTicket(Ticket ticket)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TICKET ");
                sql.Append(" VALUES (@NumeroTicket); ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@NumeroTicket", SqlDbType.VarChar, 100).Value = ticket.NumeroTicket;
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable GetTicket()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TICKET");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
            }
            return dt;
        }

        public string ConsultaNombre()
        {
            string query = "SELECT * FROM TIPODESOPORTE";
            comando.Connection = MiConexion;
            MiConexion.Close();
            MiConexion.Open();
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

        public string ConsultaTipoSoporte()
        {
            string query = "SELECT * FROM TIPODESOPORTE";
            comando.Connection = MiConexion;
            MiConexion.Close();
            MiConexion.Open();
            // MiConexion.Open();
            SqlCommand cmd = new SqlCommand(query, MiConexion);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                return reg["TIPOSOPORTE"].ToString();
            }
            else
            {
                return "NULL";
            }
            //MiConexion.Close();
        }

        public string ConsultaEstadoTicket()
        {
            string query = "SELECT * FROM ESTADOTICKET";
            comando.Connection = MiConexion;
            MiConexion.Close();
            MiConexion.Open();
            //MiConexion.Open();
            SqlCommand cmd = new SqlCommand(query, MiConexion);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                return reg["ESTADO"].ToString();
            }
            else
            {
                return "NULL";
            }
            //MiConexion.Close();
        }
    }
}
