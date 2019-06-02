using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EjemploBD
{
    public class PersonaDAO
    {
        //private static String cadenaDeConexion = Properties.Settings.Default.MiCadenaDeConexion;
        private static String cadenaDeConexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=mibase;Integrated Security=True";
        private static SqlConnection conexion;
        private static SqlCommand comando;
        
        static PersonaDAO()
        {
            conexion = new SqlConnection(cadenaDeConexion);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public static void Guardar(Persona p)
        {
            try
            {
                conexion.Open();
                comando.CommandText = "INSERT INTO Persona (nombre, apellido) VALUES('" + p.Nombre + "','" + p.Apellido + "')";
                comando.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        public static List<Persona> Leer()
        {
            List<Persona> listaPersonas = new List<Persona>();
            try
            {
                comando.CommandText = "SELECT * FROM Persona";
                conexion.Open();
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    listaPersonas.Add(new Persona(int.Parse(dr["id"].ToString()), dr["nombre"].ToString(), dr["apellido"].ToString()));
                }

            }catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return listaPersonas;
        }

        public static Persona LeerPorID(int id)
        {
            try
            {
                Persona p = null;
                comando.CommandText = $"SELECT * FROM Persona WHERE id = '{id}'";
                conexion.Open();

                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    p = new Persona(id, dr["Nombre"].ToString(), dr["Apellido"].ToString());
                }

                return p;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
        }

        public static void Modificar(Persona p)
        {
            try
            {
                conexion.Open();
                comando.CommandText = "UPDATE Persona set nombre = '" + p.Nombre + "' , apellido = '" + p.Apellido + "' WHERE id = " + p.ID;
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        public static void Borrar(int id)
        {
            String query = "DELETE FROM Persona WHERE id = " + id;
            try
            {
                conexion.Open();
                comando.CommandText = query;
                comando.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
    }
}
