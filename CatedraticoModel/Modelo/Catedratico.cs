using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CatedraticoModel.Modelo
{
    public class Catedratico
    {
        [Key]
        public int IdCatedratico { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Especialidad { get; set; }
        public string Email { get; set; }
    }
}
