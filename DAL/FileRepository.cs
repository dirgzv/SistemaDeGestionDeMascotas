using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DALL
{
    public abstract class FileRepository<T>
    {
        protected string ruta;

        public FileRepository(string ruta)
        {
            this.ruta = ruta;
        }

        public string Guardar(T entity)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(entity.ToString());
                sw.Close();
                return "Guardado con exito";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public abstract List<T> Consultar();
        public abstract T Mappear(string datos);
    }
}
