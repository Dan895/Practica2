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
        public Response addEstudiante(int carnet, String Name, String fecha, int edad)
        {
            Response response = new Response();
            try
            {
                String sql = "insert into Estudiante (carnet_Estudiante, nombre_Estudiante, fecha_Nac, edad) values (@carnet, @Name, @fecha, @edad);";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.Parameters.AddWithValue("@carnet", carnet);
                sqlCommand.Parameters.AddWithValue("@Name", Name);
                sqlCommand.Parameters.AddWithValue("@fecha", fecha);
                sqlCommand.Parameters.AddWithValue("@edad", edad);

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

            try
            {
                openConnection();
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

        public void editaCurso (Curso cur)
        {
            SqlCommand sqlCommand = new SqlCommand("update curso where codigo_curso=@cur.CodigoCurso", connection);
            sqlCommand.Parameters.AddWithValue("@codigo_curso", cur.CodigoCurso);
            sqlCommand.Parameters.AddWithValue("@nombre_curso", cur.CursoNombre);
            sqlCommand.Parameters.AddWithValue("@descripcion", cur.Descripcion);

            sqlCommand.ExecuteNonQuery();
        }

        public void eliminarCurso (Curso cur)
        {
            SqlCommand sqlCommand = new SqlCommand("delete from table curso where codigo_curso=@cur.CodigoCurso", connection);
            sqlCommand.Parameters.AddWithValue("@codigo_Curso", cur.CodigoCurso);

            sqlCommand.ExecuteNonQuery();
        }

    }
}
