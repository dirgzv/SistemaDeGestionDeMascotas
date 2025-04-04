using DALL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLL
{
    public class MascotaService : GenericService<Mascota>
    {
        // public MascotaService(IMascotaRepository repository) : base(repository) { }
        public MascotaService(string ruta) : base(new MascotaRepository(ruta)) { }


    }

}
