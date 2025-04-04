using DALL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLL
{
    public class PropietarioService : GenericService<Propietario>
    {
        public PropietarioService(string ruta) : base(new PropietarioRepository(ruta)) { }
    }
}
