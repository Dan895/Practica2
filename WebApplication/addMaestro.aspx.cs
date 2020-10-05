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
    public partial class addMaestro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        Maestro nuevoMaestro = new Maestro();

        public String msg = "Iniciando...";

        protected void guardarMaestro_Click(object sender, EventArgs e)
        {
            this.msg = nuevoMaestro.addNuevoMaestro(txtId.Text, txtNombre.Text, txtFechaNac.Text);
        }
    }
}