using System;
using System.Collections.Generic;
using System.Text;

namespace DataManagement1.model
{
    public class Estudiante
    {
        private int carnetEstudiante;
        private String nombreEstudiante;
        private String fechaNac;

        public int CarnetEstudiante { get => carnetEstudiante; set => carnetEstudiante = value; }
        public string NombreEstudiante { get => nombreEstudiante; set => nombreEstudiante = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
    }
}
