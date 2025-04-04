using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLL
{
    public abstract class GenericService<T> : IGenericService<T>
    {
        protected readonly IRepository<T> _repository;

        public GenericService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual string Agregar(T entidad)
        {
            if (entidad == null)
                return "Error: La entidad no puede ser nula.";

            try
            {
                bool resultado = _repository.Agregar(entidad);
                return resultado ? $"{typeof(T).Name} agregado correctamente." : $"Error: No se pudo agregar el {typeof(T).Name}.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar el {typeof(T).Name}: {ex.Message}";
            }
        }

        public virtual string Modificar(T entidad)
        {
            if (entidad == null)
                return "Error: Entidad inválida.";

            try
            {
                bool resultado = _repository.Modificar(entidad);
                return resultado ? $"{typeof(T).Name} modificado correctamente." : $"Error: No se pudo modificar el {typeof(T).Name}.";
            }
            catch (Exception ex)
            {
                return $"Error al modificar el {typeof(T).Name}: {ex.Message}";
            }
        }

        public virtual string Eliminar(int id)
        {
            if (id <= 0)
                return "Error: ID inválido.";

            try
            {
                bool resultado = _repository.Eliminar(id);
                return resultado ? $"{typeof(T).Name} eliminado correctamente." : $"Error: No se pudo eliminar el {typeof(T).Name}.";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar el {typeof(T).Name}: {ex.Message}";
            }
        }

        public virtual List<T> ObtenerTodos()
        {
            try
            {
                return _repository.ObtenerTodos() ?? new List<T>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener {typeof(T).Name}s: {ex.Message}");
                return new List<T>();
            }
        }

        public virtual T ObtenerPorId(int id)
        {
            if (id <= 0)
                return default;

            try
            {
                return _repository.ObtenerPorId(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener {typeof(T).Name}: {ex.Message}");
                return default;
            }
        }
    }

}
