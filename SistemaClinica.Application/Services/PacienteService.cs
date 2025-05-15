using SistemaClinica.Domain.Entities;
using SistemaClinica.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinica.Application.Services
{
    public class PacienteService
    {
        private readonly IPacienteRepositorio _repositorio;

        public PacienteService(IPacienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void RegistrarPaciente(Paciente paciente) { }
        public IEnumerable<Paciente> ListarPacientes()
        {
            return _repositorio.ObtenerTodos();
        }

    }

}
