using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IVeterinarioRepository
    {
        bool AgregarVeterinario(Veterinario veterinario);
        bool ModificarVeterinario(Veterinario veterinario);
        bool EliminarVeterinario(int idVeterinario);
        List<Veterinario> ObtenerVeterinarios();
        Veterinario ObtenerVeterinario(int idVeterinario);
    }

}
