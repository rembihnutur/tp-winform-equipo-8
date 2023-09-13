using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Negocio
{
    public class AccesoDatos
    {
        private readonly SqlConnection conn;
        private readonly SqlCommand cmd;

        public AccesoDatos()
        {
            conn = new SqlConnection("Server=.\\SQLExpress;Database=CATALOGO_P3_DB;Trusted_Connection=True;");
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;   
        }

        private void Preparar(string consulta)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = consulta;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public SqlDataReader Leer(string consulta) 
        {
            Preparar(consulta);
            return cmd.ExecuteReader();
        }

        public int Ejecutar(string consulta)
        {
            Preparar(consulta);
            return cmd.ExecuteNonQuery();
        }

        public void Close()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }
}