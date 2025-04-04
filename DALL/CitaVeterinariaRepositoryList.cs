using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CitaVeterinariaRepositoryList : ICitaVeterinariaRepository
    {
        private static List<CitaVeterinaria> citasVeterinarias = new List<CitaVeterinaria>();

        public CitaVeterinariaRepositoryList()
        {
        }
        public bool AgregarCitaVeterinaria(CitaVeterinaria citaVeterinaria)
        {
            if (citaVeterinaria == null)
                return false;
            citasVeterinarias.Add(citaVeterinaria);
            return true;
        }
        public bool ModificarCitaVeterinaria(CitaVeterinaria citaVeterinaria)
        {
            if (citaVeterinaria == null)
                return false;
            CitaVeterinaria citaVeterinariaEncontrada = ConsultarCitaVeterinaria(citaVeterinaria.IdCitaVeterinaria);
            if (citaVeterinariaEncontrada == null)
                return false;
            citaVeterinariaEncontrada.Fecha = citaVeterinaria.Fecha;
            citaVeterinariaEncontrada.Hora = citaVeterinaria.Hora;
            citaVeterinariaEncontrada.Mascota = citaVeterinaria.Mascota;
            citaVeterinariaEncontrada.Veterinario = citaVeterinaria.Veterinario;
            return true;
        }
        public bool EliminarCitaVeterinaria(int idCitaVeterinaria)
        {
            CitaVeterinaria citaVeterinaria = ConsultarCitaVeterinaria(idCitaVeterinaria);
            if (citaVeterinaria == null)
                return false;
            citasVeterinarias.Remove(citaVeterinaria);
            return true;
        }
        public List<CitaVeterinaria> ConsultarCitasVeterinaria()
        {
            return citasVeterinarias;
        }
        public CitaVeterinaria ConsultarCitaVeterinaria(int idCitaVeterinaria)
        {
            return citasVeterinarias.FirstOrDefault(c => c.IdCitaVeterinaria == idCitaVeterinaria);
        }
        public List<CitaVeterinaria> ConsultarCitasVeterinariaPorMascota(int idMascota)
        {
            return citasVeterinarias.Where(c => c.Mascota.IdMascota == idMascota).ToList();
        }
    }
}
