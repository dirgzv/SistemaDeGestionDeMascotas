using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Especie
    {
        int idEspecie { get; set; }
        string nombre { get; set; }
        string descripcion { get; set; }
        List<Raza> razas { get; set; }

        public Especie() { }
        public Especie(int idEspecie, string nombre, string descripcion, List<Raza> razas)
        {
            this.idEspecie = idEspecie;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.razas = razas;
        }
    }
}
