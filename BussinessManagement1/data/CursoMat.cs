using System;
using System.Collections.Generic;
using System.Text;
using DataManagement1;
using DataManagement1.access;
using DataManagement1.model;


namespace BussinessManagement1.data
{
    public class CursoMat
    {
        DBConnection connection = new DBConnection();
        Response response = new Response();


        public String addNuevoCurso(String id, String Name, String desc)
        {
            String result = "";
            response = connection.openConnection();

            if (response.success)
            {
                response = connection.addCurso(Int32.Parse(id), Name, desc);

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

        public List<Curso> listarCurso()
        {
            List<Curso> cu = new List<Curso>();
            //String result = "";
            response = connection.openConnection();
            if (response.success)
            {
                cu = connection.lstCurso();
            }
            response = connection.closeConnection();
            return connection.lstCurso();
        }

        public void editarCurso(int codigo, string nombre, string desc)
        {
            connection.openConnection();
            connection.editaCurso(codigo, nombre, desc);
            connection.closeConnection();
        }

        public void eliminarCurso(int codigo)
        {
            connection.openConnection();
            connection.eliminarCurso(codigo);
            connection.closeConnection();
        }

    }
}
