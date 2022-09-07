using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlumnoModel.Modelo;
using CatedraticoModel.Modelo;

namespace Tarea_ArqComp.Data
{
    public class Tarea_ArqCompContext : DbContext
    {
        public Tarea_ArqCompContext (DbContextOptions<Tarea_ArqCompContext> options)
            : base(options)
        {
        }

        public DbSet<AlumnoModel.Modelo.Alumno> Alumno { get; set; }

        public DbSet<CatedraticoModel.Modelo.Catedratico> Catedratico { get; set; }
    }
}
