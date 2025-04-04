using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Mascota
    {
        int idMascota { get; set; }
        string nombre { get; set; }
        char sexo { get; set; }
        int edad { get; set; }
        decimal peso { get; set; }
        decimal altura { get; set; }
        Raza raza { get; set; }
        Propietario propietario { get; set; }

        public Mascota() { }

        public Mascota(int idMascota, string nombre, char sexo, int edad, decimal peso, decimal altura, Raza raza, Propietario propietario)
        {
            this.idMascota = idMascota;
            this.nombre = nombre;
            this.sexo = sexo;
            this.edad = edad;
            this.peso = peso;
            this.altura = altura;
            this.raza = raza;
            this.propietario = propietario;
        }

        public void AsignarPropietario(Propietario prop)
        {
            this.propietario = prop;
        }
    }
}
