using System;
using System.Collections.Generic;
using System.Text;
using DataManagement1;
using DataManagement1.access;
using DataManagement1.model;

namespace BussinessManagement1.data
{
    public class MaestroBuss
    {
        DBConnection connection = new DBConnection();
        Response response = new Response();


        public String addNuevoMaestro(String id, String Name, String fecha_Nac)
        {
            String result = "";
            response = connection.openConnection();

            if (response.success)
            {
                response = connection.addMaestro(Int32.Parse(id), Name, fecha_Nac);

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

        public List<Maestro> listarMaestro()
        {
            List<Maestro> nm = new List<Maestro>();
            String result = "";
            response = connection.openConnection();
            if (response.success)
            {
                result = "<br>"+response.message;
                //nm = connection.LstMaestro();
            }
            response = connection.closeConnection();
            return connection.LstMaestro();
        }

        public void editarMaestro(int carnet, string nombre, string fechaNac)
        {
            
            connection.editaCurso(carnet, nombre, fechaNac);
            
        }

        public void eliminarMaestro(int carnet)
        {
            
            connection.EliminarMaestro(carnet);
            
        }
    }
}
