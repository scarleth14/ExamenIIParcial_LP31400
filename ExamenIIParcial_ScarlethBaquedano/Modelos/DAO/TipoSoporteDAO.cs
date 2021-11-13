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
    public class TipoSoporteDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarTipoSoporte(TipoDeSoporte soporte)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TIPODESOPORTE ");
                sql.Append(" VALUES (@NombreCliente, @IdentidadCliente, @Fecha, @TipoSoporte, @SoporteCelular, @SoporteComputadora); ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@NombreCliente", SqlDbType.NVarChar, 100).Value = soporte.NombreCliente;
                comando.Parameters.Add("@IdentidadCliente", SqlDbType.NVarChar, 30).Value = soporte.IdentidadCliente;
                comando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = soporte.Fecha;
                comando.Parameters.Add("@TipoSoporte", SqlDbType.NVarChar, 80).Value = soporte.TipoSoporte;
                comando.Parameters.Add("@SoporteCelular", SqlDbType.NVarChar, 80).Value = soporte.SoporteCelular;
                comando.Parameters.Add("@SoporteComputadora", SqlDbType.NVarChar, 80).Value = soporte.SoporteComputadora;
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
