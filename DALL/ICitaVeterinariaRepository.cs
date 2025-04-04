using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICitaVeterinariaRepository
    {
        bool AgregarCitaVeterinaria(CitaVeterinaria citaVeterinaria);
        bool ModificarCitaVeterinaria(CitaVeterinaria citaVeterinaria);
        bool EliminarCitaVeterinaria(int idCitaVeterinaria);
        List<CitaVeterinaria> ConsultarCitasVeterinaria();
        CitaVeterinaria ConsultarCitaVeterinaria(int idCitaVeterinaria);
        List<CitaVeterinaria> ConsultarCitasVeterinariaPorMascota(int idMascota);
    }
}
