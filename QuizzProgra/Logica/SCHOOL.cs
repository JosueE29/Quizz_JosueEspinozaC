using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;


    namespace QuizzProgra.Logica
    {
        public class SCHOOL
        {

            public static int InsertarSchool(string SchoolName, string Descripcion, string Correo, string Phone, string PostCode, string PostAddress)
            {
                int retorno = 0;
                SqlConnection Conn = new SqlConnection();
                try
                {
                    using (Conn = DBconn.obtenerConexion())
                    {
                        SqlCommand cmd = new SqlCommand("InsertarSchool", Conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add(new SqlParameter("@SchoolName", SchoolName));
                        cmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));
                        cmd.Parameters.Add(new SqlParameter("@Correo", Correo));
                        cmd.Parameters.Add(new SqlParameter("@Phone", Phone));
                        cmd.Parameters.Add(new SqlParameter("@PostCode", PostCode));
                        cmd.Parameters.Add(new SqlParameter("@PostAddress", PostAddress));
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

            public static int BorrarSchool(int SchoolId)
            {
                int retorno = 0;
                SqlConnection Conn = new SqlConnection();
                try
                {
                    using (Conn = DBconn.obtenerConexion())
                    {
                        SqlCommand cmd = new SqlCommand("BorrarSchool", Conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add(new SqlParameter("@id", SchoolId));
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

            public static int ModificarSchool(int SchoolId, string SchoolName, string Descripcion, string Correo, string Phone, string PostCode, string PostAddress)
            {
                int retorno = 0;
                SqlConnection Conn = new SqlConnection();
                try
                {
                    using (Conn = DBconn.obtenerConexion())
                    {
                        SqlCommand cmd = new SqlCommand("ModificarSchool", Conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add(new SqlParameter("@id", SchoolId));
                        cmd.Parameters.Add(new SqlParameter("@SchoolName", SchoolName));
                        cmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));
                        cmd.Parameters.Add(new SqlParameter("@Correo", Correo));
                        cmd.Parameters.Add(new SqlParameter("@Phone", Phone));
                        cmd.Parameters.Add(new SqlParameter("@PostCode", PostCode));
                        cmd.Parameters.Add(new SqlParameter("@PostAddress", PostAddress));
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
