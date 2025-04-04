using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DALL
{
    public class EspecieRepository:FileRepository<Especie>
    {
        public EspecieRepository(string ruta) : base(ruta)
        {

        }

        public Especie BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault<Especie>(x => x.idEspecie == id);
        }

        public override List<Especie> Consultar()
        {
            try
            {
                List<Especie> lista = new List<Especie>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    lista.Add(Mappear(sr.ReadLine()));
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override Especie Mappear(string datos)
        {
            Especie especie = new Especie();
            especie.idEspecie = int.Parse(datos.Split(';')[0]);
            especie.nombre = datos.Split(';')[1];
            return especie;
        }
    }
}
