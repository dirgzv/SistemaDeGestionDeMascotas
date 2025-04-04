using System;
using System.Collections.Generic;
using Entity;
using DAL;

namespace BLL
{
    public class VeterinarioService
    {
        private readonly VeterinarioRepositoryList _veterinarioRepository;

        public VeterinarioService()
        {
            _veterinarioRepository = new VeterinarioRepositoryList();
        }
        public VeterinarioService(VeterinarioRepositoryList veterinarioRepository)
        {
            _veterinarioRepository = veterinarioRepository;
        }

        public string AgregarVeterinario(Veterinario veterinario)
        {
            if (veterinario == null || string.IsNullOrWhiteSpace(veterinario.Nombre))
                return "Error: El veterinario no puede ser nulo y debe tener un nombre válido.";

            try
            {
                bool resultado = _veterinarioRepository.AgregarVeterinario(veterinario);
                return resultado ? "Veterinario agregado correctamente." : "Error: No se pudo agregar el veterinario.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar el veterinario: {ex.Message}";
            }
        }

        public string ModificarVeterinario(Veterinario veterinario)
        {
            if (veterinario == null || veterinario.Id <= 0)
                return "Error: Veterinario inválido.";

            try
            {
                bool resultado = _veterinarioRepository.ModificarVeterinario(veterinario);
                return resultado ? "Veterinario modificado correctamente." : "Error: No se pudo modificar el veterinario.";
            }
            catch (Exception ex)
            {
                return $"Error al modificar el veterinario: {ex.Message}";
            }
        }

        public string EliminarVeterinario(int idVeterinario)
        {
            if (idVeterinario <= 0)
                return "Error: ID de veterinario inválido.";

            try
            {
                bool resultado = _veterinarioRepository.EliminarVeterinario(idVeterinario);
                return resultado ? "Veterinario eliminado correctamente." : "Error: No se pudo eliminar el veterinario.";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar el veterinario: {ex.Message}";
            }
        }

        public (List<Veterinario> veterinarios, string mensaje) ObtenerVeterinarios()
        {
            try
            {
                var veterinarios = _veterinarioRepository.ObtenerVeterinarios();
                if (veterinarios == null || veterinarios.Count == 0)
                    return (new List<Veterinario>(), "No hay veterinarios registrados.");

                return (veterinarios, "Veterinarios obtenidos correctamente.");
            }
            catch (Exception ex)
            {
                return (new List<Veterinario>(), $"Error al obtener los veterinarios: {ex.Message}");
            }
        }

        public (Veterinario veterinario, string mensaje) ObtenerVeterinario(int idVeterinario)
        {
            if (idVeterinario <= 0)
                return (null, "Error: ID de veterinario inválido.");

            try
            {
                var veterinario = _veterinarioRepository.ObtenerVeterinario(idVeterinario);
                if (veterinario == null)
                    return (null, "Error: Veterinario no encontrado.");

                return (veterinario, "Veterinario obtenido correctamente.");
            }
            catch (Exception ex)
            {
                return (null, $"Error al obtener el veterinario: {ex.Message}");
            }
        }
    }
}
