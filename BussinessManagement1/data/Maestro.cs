using System;
using System.Collections.Generic;
using System.Text;
using DataManagement1.access;
using DataManagement1.model;

namespace BussinessManagement1.data
{
    public class Maestro
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
    }
}
