using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PropietarioService
    {
        private readonly PropietarioRepositoryList _propietarioRepository;
        public PropietarioService()
        {
            _propietarioRepository = new PropietarioRepositoryList();
        }
        public PropietarioService(PropietarioRepositoryList propietarioRepository)
        {
            _propietarioRepository = propietarioRepository;
        }
        public string AgregarPropietario(Propietario propietario)
        {
            if (propietario == null || string.IsNullOrWhiteSpace(propietario.Nombre))
                return "Error: El propietario no puede ser nulo y debe tener un nombre válido.";
            try
            {
                bool resultado = _propietarioRepository.AgregarPropietario(propietario);
                return resultado ? "Propietario agregado correctamente." : "Error: No se pudo agregar el propietario.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar el propietario: {ex.Message}";
            }
        }
        public string ModificarPropietario(Propietario propietario)
        {
            if (propietario == null || propietario.Id <= 0)
                return "Error: Propietario inválido.";
            try
            {
                bool resultado = _propietarioRepository.ModificarPropietario(propietario);
                return resultado ? "Propietario modificado correctamente." : "Error: No se pudo modificar el propietario.";
            }
            catch (Exception ex)
            {
                return $"Error al modificar el propietario: {ex.Message}";
            }
        }
        public string EliminarPropietario(int idPropietario)
        {
            if (idPropietario <= 0)
                return "Error: ID de propietario inválido.";
            try
            {
                bool resultado = _propietarioRepository.EliminarPropietario(idPropietario);
                return resultado ? "Propietario eliminado correctamente." : "Error: No se pudo eliminar el propietario.";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar el propietario: {ex.Message}";
            }
        }
        public List<Propietario> ObtenerPropietarios()
        {
            try
            {
                var propietarios = _propietarioRepository.ObtenerPropietarios();
                if (propietarios == null || propietarios.Count == 0)
                    return (new List<Propietario>(), "No hay propietarios registrados.");

                return (propietarios, "propietarios obtenidos correctamente.");
            }
            catch (Exception ex)
            {
                return (new List<Propietario>(), $"Error al obtener los propietarios: {ex.Message}");
            }
        }
        public Propietario ObtenerPropietario(int idPropietario)
        {
            if(idPropietario <= 0)
                return (null, "Error: ID de Propietario inválido.");
            try
            {
                var propietario = _propietarioRepository.ObtenerPropietario(idPropietario);
                if (propietario == null)
                    return (null, "Error: propietario no encontrado.");

                return (propietario, "propietario obtenido correctamente.");
            }
            catch (Exception ex)
            {
                return (null, $"Error al obtener el propietario: {ex.Message}");
            }
        }
    }
}
