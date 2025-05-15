using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaClinica.Domain.Entities;


namespace SistemaClinica.Infrastructure.Context
{
    public class ClinicaDbContext : DbContext
    {
        public ClinicaDbContext(DbContextOptions<ClinicaDbContext> options)
            : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
    }
}
