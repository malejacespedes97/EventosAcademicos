using EventosAcedemicos.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace EventosAcademicos.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //Notación diamante es el nombre de la entidad <>, luego de esto se debe agregar la misma clase en plural
        public DbSet<EventoAcademico> EventosAcademicos { get; set; } 

        public DbSet<Participante> Participantes { get; set; }

        public DbSet<ProgramaEvento> ProgramaEventos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
