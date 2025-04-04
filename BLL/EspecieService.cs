using DALL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLL
{
    public class EspecieService : GenericService<Especie>
    {
        public EspecieService(string ruta) : base(new EspecieRepository(ruta))
        {
        }
    }
}
