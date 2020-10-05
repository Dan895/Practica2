using System;
using System.Collections.Generic;
using System.Text;

namespace DataManagement1.model
{
    public class Curso
    {
        private int codigoCurso;
        private String cursoNombre;
        private String descripcion;

        public int CodigoCurso { get => codigoCurso; set => codigoCurso = value; }
        public string CursoNombre { get => cursoNombre; set => cursoNombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
