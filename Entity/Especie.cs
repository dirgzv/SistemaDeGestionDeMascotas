using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Especie
    {
        public int idEspecie { get; set; }
        public string nombre { get; set; }
        List<Raza> razas { get; set; }

        public Especie() { }
        public Especie(int idEspecie, string nombre, List<Raza> razas)
        {
            this.idEspecie = idEspecie;
            this.nombre = nombre;
            this.razas = razas;
        }

        public override string ToString()
        {
            return $"{idEspecie};{nombre};{string.Join("-",razas.Select(raza=>raza.nombre))}";
        }
    }
}
