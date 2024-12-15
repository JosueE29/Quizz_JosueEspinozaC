using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Configuration;

namespace QuizzProgra.Logica
{
    public class CLASS
    {
        public static int InsertarClass(int SchoolId, string ClassName, string Descripcion)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("InsertarClass", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@SchoolId", SchoolId));
                    cmd.Parameters.Add(new SqlParameter("@ClassName", ClassName));
                    cmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }
            return retorno;
        }

        public static int BorrarClass(int ClassId)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("BorrarClass", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@id", ClassId));
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }
            return retorno;
        }
    }
}