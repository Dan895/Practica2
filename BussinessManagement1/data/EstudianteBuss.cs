using System;
using System.Collections.Generic;
using System.Text;
using DataManagement1;
using DataManagement1.access;
using DataManagement1.model;

namespace BussinessManagement1.data
{
    public class EstudianteBuss
    {
        DBConnection connection = new DBConnection();
        Response response = new Response();


        public String addNuevoEstudiante(String id, String Name, String fechaNac)
        {
            String result = "";
            response = connection.openConnection();

            if (response.success)
            {
                response = connection.addEstudiante(Int32.Parse(id), Name, fechaNac);

                result = response.message;

                response = connection.closeConnection();

                if (!response.success)
                {
                    result = "<br>" + response.message;
                }
            }
            else
            {
                result = response.message;
            }

            return result;
        }

        public List<Estudiante> ListarEstudiante()
        {
            List<Estudiante> nu = new List<Estudiante>();

            //String result = "";
            response = connection.openConnection();
            if (response.success)
            {
                nu = connection.LstEstudiante();
                
            }
            response = connection.closeConnection();
            return connection.LstEstudiante();
        }

        public void editarEstudiante(int carnet, string nombre, string fechaNac)
        {
            connection.openConnection();
            connection.editaCurso(carnet, nombre, fechaNac);
            connection.closeConnection();
        }

        public void eliminarEstudiante(int carnet)
        {
            connection.openConnection();
            connection.EliminarEstudiante(carnet);
            connection.closeConnection();
        }
    }
}
