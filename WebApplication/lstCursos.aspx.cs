using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessManagement1;
using BussinessManagement1.data;

namespace WebApplication
{
    public partial class lstCursos : System.Web.UI.Page
    {
        CursoMat nuevo = new CursoMat();
        
        private void listar()
        {
            grilla.DataSource = nuevo.listarCurso();
            grilla.DataBind();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void eliminar(int id)
        {
            
        }

    }
}