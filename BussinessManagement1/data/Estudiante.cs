using System;
using System.Collections.Generic;
using System.Text;
using DataManagement1.access;
using DataManagement1.model;

namespace BussinessManagement1.data
{
    public class Estudiante
    {
        DBConnection connection = new DBConnection();
        Response response = new Response();


        public String addNuevoEstudiante(String id, String Name, String fechaNac, String edad)
        {
            String result = "";
            response = connection.openConnection();

            if (response.success)
            {
                response = connection.addEstudiante(Int32.Parse(id), Name, fechaNac, Int32.Parse(edad));

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
    }
}
