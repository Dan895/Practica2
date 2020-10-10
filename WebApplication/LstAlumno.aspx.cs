using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessManagement1.data;

namespace WebApplication
{
    public partial class lstAlumno : System.Web.UI.Page
    {
        EstudianteBuss estudiante = new EstudianteBuss();

        private void listar()
        {
            grilla.DataSource = estudiante.ListarEstudiante();
            grilla.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar();
            }
        }

        protected void RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grilla.EditIndex = -1;
            listar();
        }

        protected void RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int codigo = Convert.ToInt32(grilla.DataKeys[e.RowIndex].Values[0]);
            estudiante.eliminarEstudiante(codigo);
            grilla.EditIndex = -1;
            listar();
        }
        protected void RowEditing(object sender, GridViewEditEventArgs e)
        {
            grilla.EditIndex = e.NewEditIndex;
            listar();
        }
        protected void RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow fila = grilla.Rows[e.RowIndex];
            int carnet = Convert.ToInt32(grilla.DataKeys[e.RowIndex].Values[0]);
            String nombre = (fila.FindControl("txtNombre") as TextBox).Text.ToUpper();
            String fechaNac = (fila.FindControl("txtFechaNac") as TextBox).Text.ToUpper();

            estudiante.editarEstudiante(carnet, nombre, fechaNac);
            grilla.EditIndex = -1;
            listar();
        }
    }
}