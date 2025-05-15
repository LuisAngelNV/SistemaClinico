using SistemaClinica.Domain.Entities;
using SistemaClinica.Domain.Interfaces;
using SistemaClinica.Infrastructure.Context;

namespace SistemaClinica.Infrastructure.Repositories
{
    public class PacienteRepositorioEF : IPacienteRepositorio
    {
        private readonly ClinicaDbContext _context;

        public PacienteRepositorioEF(ClinicaDbContext context)
        {
            _context = context;
        }

        public void Agregar(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
            _context.SaveChanges();
        }

        public void Actualizar(Paciente paciente)
        {
            _context.Pacientes.Update(paciente);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var paciente = _context.Pacientes.Find(id);
            if (paciente != null)
            {
                _context.Pacientes.Remove(paciente);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Paciente> ObtenerTodos()
        {
            return _context.Pacientes.ToList();
        }

        public Paciente ObtenerPorId(int id)
        {
            return _context.Pacientes.Find(id);
        }
    }
}
