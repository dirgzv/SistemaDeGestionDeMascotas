using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CitaVeterinariaServices()
    {
        private readonly CitaVeterinariaRepositoryList _citaVeterinariaRepository;
        public CitaVeterinariaServices()
        {
            _citaVeterinariaRepository = new CitaVeterinariaRepositoryList();
        }
        public CitaVeterinariaServices(CitaVeterinariaRepositoryList citaVeterinariaRepository)
        {
            this._citaVeterinariaRepository = citaVeterinariaRepository;
        }
        public string AgregarCitaVeterinaria(CitaVeterinaria citaVeterinaria)
        {
            if (citaVeterinaria == null || citaVeterinaria.Mascota == null || citaVeterinaria.Veterinario == null)
                return "Error: La cita veterinaria no puede ser nula y debe tener una mascota y un veterinario válidos.";
            try
            {
                bool resultado = _citaVeterinariaRepository.AgregarCitaVeterinaria(citaVeterinaria);
                return resultado ? "Cita veterinaria agregada correctamente." : "Error: No se pudo agregar la cita veterinaria.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar la cita veterinaria: {ex.Message}";
            }
        }
        public string ModificarCitaVeterinaria(CitaVeterinaria citaVeterinaria)
        {
            if (citaVeterinaria == null || citaVeterinaria.IdCitaVeterinaria <= 0)
                return "Error: Cita veterinaria inválida.";
            try
            {
                bool resultado = _citaVeterinariaRepository.ModificarCitaVeterinaria(citaVeterinaria);
                return resultado ? "Cita veterinaria modificada correctamente." : "Error: No se pudo modificar la cita veterinaria.";
            }
            catch (Exception ex)
            {
                return $"Error al modificar la cita veterinaria: {ex.Message}";
            }
        }
        public string EliminarCitaVeterinaria(int idCitaVeterinaria) {
            if (idCitaVeterinaria <= 0)
                return "Error: ID de la cita es inválida.";
            try
            {
                bool resultado = _citaVeterinariaRepository.EliminarCitaVeterinaria(idCitaVeterinaria);
                return resultado ? "cita eliminada correctamente." : "Error: No se pudo eliminar la cita.";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar la cita: {ex.Message}";
            }
        }
        public List<CitaVeterinaria> ConsultarCitasVeterinaria()
        {
            try
            {
                var citaVeterinarias = _citaVeterinariaRepository.ConsultarCitasVeterinaria();
                if (citaVeterinarias == null || citaVeterinarias.Count == 0)
                    return (new List<Propietario>(), "No hay citas registradas.");

                return (citaVeterinarias, "citas obtenidas correctamente.");
            }
            catch (Exception ex)
            {
                return (new List<Propietario>(), $"Error al obtener las citas: {ex.Message}");
            }
        }
        public CitaVeterinaria ConsultarCitaVeterinaria(int idCitaVeterinaria)
        {
            if (idCitaVeterinaria <= 0)
                return (null, "Error: ID de cita inválido.");
            try
            {
                var citaVeterinaria = _citaVeterinariaRepository.ConsultarCitaVeterinaria(idCitaVeterinaria);
                if (citaVeterinaria == null)
                    return (null, "Error: cita no encontrado.");

                return (propietario, "cita obtenida correctamente.");
            }
            catch (Exception ex)
            {
                return (null, $"Error al obtener la cita: {ex.Message}");
            }
        }
        public List<CitaVeterinaria> ConsultarCitasVeterinariaPorMascota(int idMascota)
        {
            if (idMascota <= 0)
                return (new List<Propietario>(), "Error: ID de mascota inválido.");
            try
            {
                var citasVeterinaria = _citaVeterinariaRepository.ConsultarCitasVeterinariaPorMascota(idMascota);
                if (citasVeterinaria == null || citasVeterinaria.Count == 0)
                    return (new List<Propietario>(), "No hay citas registradas para esta mascota.");
                return (citasVeterinaria, "citas obtenidas correctamente.");
            }
            catch (Exception ex)
            {
                return (new List<Propietario>(), $"Error al obtener las citas: {ex.Message}");
            }
        }
    }
}
