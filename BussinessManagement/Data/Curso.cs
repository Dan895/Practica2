using System;
using System.Collections.Generic;
using System.Text;
using DataManagement.access;
using DataManagement.model;

namespace BussinessManagement.Data
{
    class Curso
    {
        DBConnection connection = new DBConnection();
        Response response = new Response();


        public String addNewStudent(String id, String lastName, String firstName)
        {
            String result = "";
            response = connection.openConnection();

            if (response.success)
            {
                response = connection.insertStudent(Int32.Parse(id), lastName, firstName);

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
