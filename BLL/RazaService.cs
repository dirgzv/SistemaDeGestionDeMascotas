using DALL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLL
{
    public class RazaService : GenericService<Entity.Raza>
    {
        public RazaService(string ruta) : base(new RazaRepository(ruta))
        {
        }
    }
}
