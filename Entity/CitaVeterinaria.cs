using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CitaVeterinaria
    {
        int idCita { get; set; }
        Mascota mascota { get; set; }
        DateTime fecha { get; set; }
        string diagnostico { get; set; }
        string tratamiento { get; set; }
        string observaciones { get; set; }

        public CitaVeterinaria() { }
        public CitaVeterinaria(int idCita, Mascota mascota, DateTime fecha, string diagnostico, string tratamiento, string observaciones)
        {
            this.idCita = idCita;
            this.mascota = mascota;
            this.fecha = fecha;
            this.diagnostico = diagnostico;
            this.tratamiento = tratamiento;
            this.observaciones = observaciones;
        }
    }
}
