using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Raza
    {
        int idRaza { get; set; }
        string nombre { get; set; }
        string descripcion { get; set; }
        Especie especie { get; set; }
        public Raza() { }
        public Raza(int idRaza, string nombre, string descripcion, Especie especie)
        {
            this.idRaza = idRaza;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.especie = especie;
        }
    }
}
