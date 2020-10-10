using System;
using System.Collections.Generic;
using System.Text;

namespace DataManagement1.model
{
    public class Maestro
    {

        private int carnetMaestro;
        private String nombre;
        private String fechaNac;

        public int CarnetMaestro { get => carnetMaestro; set => carnetMaestro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
    }
}
