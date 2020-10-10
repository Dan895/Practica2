using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using DataManagement1.model;

namespace DataManagement1.access
{
    public class DBConnection
    { 
        SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Escuela;Integrated Security=True");

        public Response openConnection()
        {
            Response response = new Response();

            try
            {
                connection.Open();
                response.success = true;
                response.message = "Conexión a DB abierta";
            }
            catch (Exception ex)
            {
                response.success = false;
                response.message = ex.Message;
            }
            return response;
        }

        public Response closeConnection()
        {
            Response response = new Response();

            try
            {
                connection.Close();
                response.success = true;
                response.message = "Conexión a DB cerrada";
            }
            catch (Exception ex)
            {
                response.success = false;
                response.message = ex.Message;
            }
            return response;
        }

        //Estudiante
        public Response addEstudiante(int carnet, String Name, String fecha)
        {
            Response response = new Response();
            try
            {
                String sql = "insert into Estudiante (carnet_Estudiante, nombre_Estudiante, fecha_Nac) values (@carnet, @Name, @fecha);";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.Parameters.AddWithValue("@carnet", carnet);
                sqlCommand.Parameters.AddWithValue("@Name", Name);
                sqlCommand.Parameters.AddWithValue("@fecha", fecha);

                sqlCommand.ExecuteNonQuery();

                response.success = true;
                response.message = "Estudiante creado con éxito";

            }
            catch (SqlException ex)
            {
                response.success = false;
                response.message = ex.Message;
            }

            return response;

        }
        
        public List<Estudiante> LstEstudiante()
        {
            Response response = new Response();
            List<Estudiante> listar = new List<Estudiante>();
            openConnection();
            try
            {
                SqlDataReader reader = null;
                String sql = "select * from Estudiante;";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);

                reader = sqlCommand.ExecuteReader();

                //por si arreglo la fecha para el alumno
                DateTime fecha = new DateTime(1995, 1, 23);
                string fecha2 = "12/08/95";

                int ed = DateTime.Today.AddTicks(-fecha.Ticks).Year - 1;
                fecha.ToShortDateString().ToString();
                DateTime dat = Convert.ToDateTime(fecha2);

                while (reader.Read())
                {
                    Estudiante ne = new Estudiante()
                    {
                        CarnetEstudiante = Int32.Parse(reader[0] + ""),
                        NombreEstudiante = reader[1] + "",
                        FechaNac = reader[2] + "" 
                    };
                    listar.Add(ne);
                }
                response.success = true;
                response.message = "Estudiante listado";
                closeConnection();
                reader.Close();
                return listar;
            }
            catch (SqlException ex)
            {
                response.success = false;
                response.message = ex.Message;
            }
            return listar;
        }

        public void EditaEstudiante(int carnet, string nombre, string fechaNac)
        {
            openConnection();
            String sql = "update Estudiante set nombre_Estudiante=@nombre, fecha_Nac=@fechaNac where carnet_Estudiante=@carnet;";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@carnet", carnet);
            sqlCommand.Parameters.AddWithValue("@nombre", nombre);
            sqlCommand.Parameters.AddWithValue("@fechaNac", fechaNac);

            sqlCommand.ExecuteNonQuery();
            closeConnection();
        }

        public void EliminarEstudiante(int carnet)
        {
            openConnection();
            String sql = "delete from Estudiante where carnet_Estudiante=@carnet;";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@carnet", carnet);

            sqlCommand.ExecuteNonQuery();
            closeConnection();
        }

        //Maestro
        public Response addMaestro(int carnet, String Name, String fechaNac)
        {
            Response response = new Response();
            try
            {
                String sql = "insert into Maestro (carnet_Maestro, nombre, fecha_Nac) values (@carnet, @Name, @fechaNac);";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.Parameters.AddWithValue("@carnet", carnet);
                sqlCommand.Parameters.AddWithValue("@Name", Name);
                sqlCommand.Parameters.AddWithValue("@fechaNac", fechaNac);

                sqlCommand.ExecuteNonQuery();

                response.success = true;
                response.message = "Maestro creado con éxito";

            }
            catch (SqlException ex)
            {
                response.success = false;
                response.message = ex.Message;
            }

            return response;

        }

        public List<Maestro> LstMaestro()
        {
            Response response = new Response();
            List<Maestro> listar = new List<Maestro>();
            openConnection();
            try
            {
                SqlDataReader reader = null;
                String sql = "select * from Maestro;";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);

                reader = sqlCommand.ExecuteReader();
  
                while (reader.Read())
                {
                    Maestro nc = new Maestro()
                    {
                        CarnetMaestro = Int32.Parse(reader[0] + ""),
                        Nombre= reader[1] + "",
                        FechaNac = reader[2] + ""
                    };
                    listar.Add(nc);
                }
                response.success = true;
                response.message = "Maestro listado";
                closeConnection();
                reader.Close();
                return listar;
            }
            catch (SqlException ex)
            {
                response.success = false;
                response.message = ex.Message;
            }
            return listar;
        }


        public void EditarMaestro(int carnet, string nombre, string fechaNac)
        {
            openConnection();
            String sql = "update Maestro set nombre=@nombre, fecha_Nac=@fechaNac where carnet_Maestro=@carnet;";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@carnet", carnet);
            sqlCommand.Parameters.AddWithValue("@nombre", nombre);
            sqlCommand.Parameters.AddWithValue("@fechaNac", fechaNac);

            sqlCommand.ExecuteNonQuery();
            closeConnection();
        }

        public void EliminarMaestro(int carnet)
        {
            openConnection();
            SqlCommand sqlCommand = new SqlCommand("delete from Maestro where carnet_Maestro=@carnet;", connection);
            sqlCommand.Parameters.AddWithValue("@carnet", carnet);

            sqlCommand.ExecuteNonQuery();
            closeConnection();
        }

        //Curso
        public Response addCurso(int codigo, String Name, String desc)
        {
            Response response = new Response();
            try
            {
                String sql = "insert into Curso (codigo_Curso, nombre_Curso, descripcion) values (@codigo, @Name, @desc);";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.Parameters.AddWithValue("@codigo", codigo);
                sqlCommand.Parameters.AddWithValue("@Name", Name);
                sqlCommand.Parameters.AddWithValue("@desc", desc);

                sqlCommand.ExecuteNonQuery();

                response.success = true;
                response.message = "Curso creado con éxito";

            }
            catch (SqlException ex)
            {
                response.success = false;
                response.message = ex.Message;
            }

            return response;

        }

        public List<Curso> lstCurso ()
        {
            Response response = new Response();
            List<Curso> listar = new List<Curso>();
            openConnection();
            try
            {
                
                SqlDataReader reader = null;
                String sql = "select * from Curso;";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);

                reader = sqlCommand.ExecuteReader();
                
                while (reader.Read())
                {
                    Curso nc = new Curso() {
                        CodigoCurso = Int32.Parse(reader[0] + ""),
                        CursoNombre = reader[1] + "",
                        Descripcion = reader[2] + ""
                    };
                    listar.Add(nc);
                }
                response.success = true;
                response.message = "Curso listado";

                closeConnection();
                reader.Close();
                return listar;
            }
            catch (SqlException ex)
            {
                response.success = false;
                response.message = ex.Message;
            }
            return listar;
        }

        public void editaCurso (int codigo, string nombre, string desc)
        {
            openConnection();
            String sql = "update curso set nombre_Curso=@nombre, descripcion=@desc where codigo_Curso=@codigo;";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@codigo", codigo);
            sqlCommand.Parameters.AddWithValue("@nombre", nombre);
            sqlCommand.Parameters.AddWithValue("@desc", desc);
            sqlCommand.ExecuteNonQuery();
            closeConnection();
            
        }

        public void eliminarCurso (int codigo)
        {
            openConnection();
            SqlCommand sqlCommand = new SqlCommand("delete from Curso where codigo_Curso=@codigo;", connection);
            sqlCommand.Parameters.AddWithValue("@codigo", codigo);

            sqlCommand.ExecuteNonQuery();
            closeConnection();
        }

    }
}
