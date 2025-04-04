using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class MascotaService
    {
        private readonly MascotaRepositoryList _mascotaRepository

        public MascotaService()
        {
            _mascotaRepository = new MascotaRepositoryList();
        }
        public MascotaService(MascotaRepositoryList mascotaRepository)
        {
            this._mascotaRepository = mascotaRepository;
        }
        public string AgregarMascota(Mascota mascota)
        {
            if (mascota == null || string.IsNullOrWhiteSpace(mascota.Nombre))
                return "Error: La mascota no puede ser nula y debe tener un nombre válido.";
            try
            {
                bool resultado = _mascotaRepository.AgregarMascota(mascota);
                return resultado ? "Mascota agregada correctamente." : "Error: No se pudo agregar la mascota.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar la mascota: {ex.Message}";
            }
        }
        public string ModificarMascota(Mascota mascota)
        {
            if (mascota == null || mascota.IdMascota <= 0)
                return "Error: Mascota inválida.";
            try
            {
                bool resultado = _mascotaRepository.ModificarMascota(mascota);
                return resultado ? "Mascota modificada correctamente." : "Error: No se pudo modificar la mascota.";
            }
            catch (Exception ex)
            {
                return $"Error al modificar la mascota: {ex.Message}";
            }
        }
        public string EliminarMascota(int idMascota)
        {
            if (idMascota <= 0)
                return "Error: ID de mascota inválido.";
            try
            {
                bool resultado = _mascotaRepository.EliminarMascota(idMascota);
                return resultado ? "Mascota eliminada correctamente." : "Error: No se pudo eliminar la mascota.";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar la mascota: {ex.Message}";
            }
        }
        public List<Mascota> ObtenerMascotas()
        {
            return _mascotaRepository.ObtenerMascotas();
            try
            {
                var mascotas = _mascotaRepository.ObtenerMascotas();
                if (mascotas == null || mascotas.Count == 0)
                    return (new List<Mascota>(), "No hay Mascotas registradas.");

                return (mascotas, "mascotas obtenidas correctamente.");
            }
            catch (Exception ex)
            {
                return (new List<Propietario>(), $"Error al obtener las mascotas: {ex.Message}");
            }
        }
        public List<Mascota> ObtenerMascotasPorPropietario(int idPropietario)
        {
            try
            {
                var mascotas = _mascotaRepository.ObtenerMascotasPorPropietario(idPropietario);
                if (mascotas == null || mascotas.Count == 0)
                    return (new List<Mascota>(), "No hay mascotas registradas para el propietario.");
                return (mascotas, "mascotas obtenidas correctamente.");
            }
            catch (Exception ex)
            {
                return (new List<Mascota>(), $"Error al obtener las mascotas: {ex.Message}");
            }
        }
        public Mascota ObtenerMascota(int idMascota)
        {
            if (idMascota <= 0)
                return (null, "Error: ID de mascota inválido.");
            try
            {
                var mascota = _mascotaRepository.ObtenerMascota(idMascota);
                if (mascota == null)
                    return (null, "No se encontró la mascota.");
                return (mascota, "mascota obtenida correctamente.");
            }
            catch (Exception ex)
            {
                return (null, $"Error al obtener la mascota: {ex.Message}");
            }
        }
    }
}
