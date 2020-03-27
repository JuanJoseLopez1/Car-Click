using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace DataAccess
{
    public class UserDao : Conexion
    {
        public bool Login(string usermail, string pass)
        {
            using (var conexion = GetConexion())
            {
                conexion.Open();
                using (var comandoSQL = new OracleCommand())
                {
                    comandoSQL.Connection = conexion;
                    comandoSQL.CommandText = "SELECT * FROM USUARIO WHERE ucorreo = " + "'" + usermail + "'" + " AND uclave = " + "'" + pass + "'";
                    comandoSQL.CommandType = CommandType.Text;
                    OracleDataReader objReader = comandoSQL.ExecuteReader();
                    if (objReader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public int InsertUser(string parNombreU, string parApellidoU, string parTelefonoU, string parMailU, string parClaveU)
        {
            int filasAfectadas;
            using (var conexion = GetConexion())
            {
                conexion.Open();
                using (var comandoSQL = new OracleCommand())
                {
                    comandoSQL.Connection = conexion;
                    comandoSQL.CommandText = "INSERT INTO USUARIO VALUES(" + "'" + parNombreU + "'," + " '" + parApellidoU + "'," + " '" + parTelefonoU + "'," + " '" + parMailU + "'," + " '" + parClaveU + "')";
                    comandoSQL.CommandType = CommandType.Text;
                    filasAfectadas = comandoSQL.ExecuteNonQuery();
                    return filasAfectadas;
                }
            }
        }

        public int InsertVehicle(string ubicacionveh, string tipoveh, string placaveh, string marcaveh, string anioveh, int kmveh, string versionveh, string tpcombustible, int puertasveh, string tptransmision, string colorveh, string tpdireccion, string traccion, int cilindraje, string tpcarroceria, string MailUsuario)
        {
            int filasAfectadas;
            using (var conexion = GetConexion())
            {
                conexion.Open();
                using (var comandoSQL = new OracleCommand())
                {
                    comandoSQL.Connection = conexion;
                    comandoSQL.CommandText = "INSERT INTO VEHICULO VALUES(" + "'" + ubicacionveh + "'," + " '" + tipoveh + "'," + " '" + placaveh + "'," + " '" + marcaveh + "'," + " '" + anioveh + "'," + kmveh + "," + " '" + versionveh + "'," + " '" + tpcombustible + "'," + puertasveh + "," + " '" + tptransmision + "'," + " '" + colorveh + "'," + " '" + tpdireccion + "'," + " '" + traccion + "'," + cilindraje + "," + " '" + tpcarroceria + "'," + "'" + MailUsuario + "')" ;
                    comandoSQL.CommandType = CommandType.Text;
                    filasAfectadas = comandoSQL.ExecuteNonQuery();
                    return filasAfectadas;
                }
            }
        }

        public int ActualizarUserDao(string Consulta)
        {
            int filasAfectadas;
            using (var conexion = GetConexion())
            {
                conexion.Open();
                using (var comandoSQL = new OracleCommand())
                {
                    comandoSQL.Connection = conexion;
                    comandoSQL.CommandText = Consulta;
                    comandoSQL.CommandType = CommandType.Text;
                    filasAfectadas = comandoSQL.ExecuteNonQuery();
                    return filasAfectadas;
                }
            }
        }

        public DataTable ejecutarSelectUserDao(string consulta)
        {
            using (var conexion = GetConexion())
            {
                conexion.Open();
                using (var adaptadorSQL = new OracleCommand())
                {
                    adaptadorSQL.Connection = conexion;
                    adaptadorSQL.CommandText = consulta;
                    adaptadorSQL.CommandType = CommandType.Text;
                    OracleDataReader Reader = adaptadorSQL.ExecuteReader();
                    DataTable objTable = new DataTable();
                    objTable.Load(Reader);
                    Reader.Close();
                    return objTable;                          
                }
            }
        }

        public int InsertPublicacion(string usermail, string placaveh, string marcaveh, string submarcaveh, string precio)
        {
            int filasAfectadas;
            using (var conexion = GetConexion())
            {
                conexion.Open();
                using (var comandoSQL = new OracleCommand())
                {

                    comandoSQL.Connection = conexion;
                    comandoSQL.CommandText = "INSERT INTO PUBLICACION VALUES(" + "'" + usermail + "'," + " '" + placaveh + "'," + " '" + marcaveh + "'," + " '" + submarcaveh + "'," + Convert.ToInt32(precio) + ")";
                    comandoSQL.CommandType = CommandType.Text;
                    filasAfectadas = comandoSQL.ExecuteNonQuery();
                    return filasAfectadas;
                }
            }
        }

        public int EliminarPublicacionUserDao(string parPlacaveh) {
            int filasAfectadas;
            using (var conexion = GetConexion())
            {
                conexion.Open();
                using (var comandoSQL = new OracleCommand())
                {

                    comandoSQL.Connection = conexion;
                    comandoSQL.CommandText = " DELETE FROM PUBLICACION WHERE UCORREO = '" + parPlacaveh + "'";
                    comandoSQL.CommandType = CommandType.Text;
                    filasAfectadas = comandoSQL.ExecuteNonQuery();
                    return filasAfectadas;
                }
            }
        }

        public int EliminarVehiculoUserDao(string parUsuario, string parPlacaveh) {
            int filasAfectadas;
            using (var conexion = GetConexion())
            {
                conexion.Open();
                using (var comandoSQL = new OracleCommand())
                {
                    comandoSQL.Connection = conexion;
                    comandoSQL.CommandText = " DELETE FROM VEHICULO WHERE PLACAVEH = '" + parPlacaveh +"' AND DUENIO = '"+ parUsuario + "'";
                    comandoSQL.CommandType = CommandType.Text;
                    filasAfectadas = comandoSQL.ExecuteNonQuery();
                    return filasAfectadas;
                }
            }
        }
    }
}
