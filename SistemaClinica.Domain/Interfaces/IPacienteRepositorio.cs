using SistemaClinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinica.Domain.Interfaces
{
    public interface IPacienteRepositorio
    {
        void Agregar(Paciente paciente);
        IEnumerable<Paciente> ObtenerTodos();
        Paciente ObtenerPorId(int id);
        void Actualizar(Paciente paciente);
        void Eliminar(int id);
    }

}
