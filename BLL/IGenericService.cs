using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLL
{
    public interface IGenericService<T>
    {
        string Agregar(T entidad);
        string Modificar(T entidad);
        string Eliminar(int id);
        List<T> ObtenerTodos();
        T ObtenerPorId(int id);
    }

}
