using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IMascotaRepository
    {
        bool AgregarMascota(Mascota mascota);
        bool ModificarMascota(Mascota mascota);
        bool EliminarMascota(int idMascota);
        List<Mascota> ObtenerMascotas();
        List<Mascota> ObtenerMascotasPorPropietario(int idPropietario);
        Mascota ObtenerMascota(int idMascota);
    }
}
