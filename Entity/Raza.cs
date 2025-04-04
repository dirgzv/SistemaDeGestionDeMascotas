using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Raza
    {
        public int idRaza { get; set; }
        public string nombre { get; set; }
        public Especie especie { get; private set; }
        public Raza() { }
        public Raza(int idRaza, string nombre, Especie especie)
        {
            this.idRaza = idRaza;
            this.nombre = nombre;
            this.especie = especie;
        }

        public void AsignarEspecie(Especie especie)
        {
            this.especie = especie;
        }

        public override string ToString()
        {
            return $"{idRaza};{nombre};{especie.idEspecie}";
        }
    }
}
