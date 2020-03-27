using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class Conexion
    {
        //defino la cadena de conexión 

        private readonly string cadenaConexion; //= @"Data Source = localhost; User ID = BD_Sindicato; Password=sys";

        public Conexion()
        {
            cadenaConexion = @"Data Source = localhost; User ID = CARCLICK; Password = oracle";
        }

        protected OracleConnection GetConexion()
        {
            return new OracleConnection(cadenaConexion);
        }   

        // ir a explorador de soluciones, referencias dar click derecho y agregar referencia, buscar Oracle.DataAccess y le damos agregar la 4.11
        /*public int ejecutarDML(string consulta)
        {
            int filasAfectadas;
            //paso 1: creo una conexion
            OracleConnection miConexion = new OracleConnection(cadenaConexion);
            //paso 2: creo un comando
            OracleCommand comando = new OracleCommand(consulta, miConexion);
            //paso 3: abrir la conexión
            miConexion.Open();
            //paso 4: ejecuto el comando, este devuelve 
            //un número que representa el número de las filas que se afectaron con el insert, update o delete
            filasAfectadas = comando.ExecuteNonQuery();
            miConexion.Close();
            return filasAfectadas;
        }
        //método para ejecutar consulta de tipo select
        public DataSet ejecutarSELECT(string consulta)
        {
            //paso 1: creo un objeto DataSet vacío
            DataSet ds = new DataSet();
            //paso 2: crear un objeto de tipo Adaptador
            OracleDataAdapter adaptador = new OracleDataAdapter(consulta, cadenaConexion);
            //paso 3: lleno el dataset a través del adaptador 
            adaptador.Fill(ds, "ResultadoDatos");
            return ds;
        }*/
    }
}
