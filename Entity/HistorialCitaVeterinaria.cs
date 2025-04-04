using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HistorialCitaVeterinaria
    {
        List<CitaVeterinaria> citaVeterinarias { get; set; }

        public HistorialCitaVeterinaria() { }
        public HistorialCitaVeterinaria(List<CitaVeterinaria> citaVeterinarias)
        {
            this.citaVeterinarias = citaVeterinarias;
        }
    }
}
