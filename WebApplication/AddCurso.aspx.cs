using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessManagement1;
using BussinessManagement1.data;

namespace WebApplication.Paginas.Curso
{
    public partial class addCurso : System.Web.UI.Page
    {
        CursoMat nuevoCurso = new CursoMat();

        public String msg = "Iniciando...";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void guardarCurso_Click(object sender, EventArgs e) 
        {
            this.msg = nuevoCurso.addNuevoCurso(txtId.Text, txtCurso.Text, txtDesc.Text);
        }
    }
}