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
    public partial class addAlumno : System.Web.UI.Page
    {

        EstudianteBuss nuevoEstudiante = new EstudianteBuss();

        public String msg = "Iniciando...";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void guardarEstudiante_Click(object sender, EventArgs e)
        {
            this.msg = nuevoEstudiante.addNuevoEstudiante(txtId.Text, txtNombre.Text, txtFechaNac.Text);
        }
    }
}