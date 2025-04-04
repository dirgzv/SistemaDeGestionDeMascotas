using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DALL
{
    public class RazaRepository : FileRepository<Raza>
    {
        public RazaRepository(string ruta) : base(ruta)
        {
        }

        public override List<Raza> Consultar()
        {
            try
            {
                List<Raza> listaR = new List<Raza>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    listaR.Add(Mappear(sr.ReadLine()));
                }
                return listaR;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override Raza Mappear(string datos)
        {
            Raza raza = new Raza();
            raza.idRaza = int.Parse(datos.Split(';')[0]);
            raza.nombre = datos.Split(';')[1];

            var especie = new EspecieRepository("especie.txt").BuscarPorId(int.Parse(datos.Split(';')[2]));
            raza.AsignarEspecie(especie);
            return raza;
        }
    }
}
