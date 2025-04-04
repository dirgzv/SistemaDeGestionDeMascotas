using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IPropietarioRepository
    {
        bool AgregarPropietario(Propietario propietario);
        bool ModificarPropietario(Propietario propietario);
        bool EliminarPropietario(int idPropietario);
        List<Propietario> ObtenerPropietarios();
        Propietario ObtenerPropietario(int idPropietario);
    }
}
