using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AlumnoModel.Modelo
{
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Facultad { get; set; }
        public string Carrera { get; set; }
    }
}
