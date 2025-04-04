using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface MacotarepositoryList : IMascotaRepository
    {
        private List<Mascota> mascotas = new List<Mascota>();

        public bool AgregarMascota(Mascota mascota)
        {
            if (mascota == null || mascotas.Any(m => m.idMascota == mascota.idMascota))
                return false;
            mascotas.Add(mascota);
            return true;
        }
        public bool ModificarMascota(Mascota mascota)
        {
            var masc = mascotas.Find(x => x.idMascota == mascota.idMascota);
            if (masc == null)
                return false;
            masc.idMascota = mascota.idMascota;
            masc.Nombre = mascota.Nombre;
            masc.Sexo = mascota.Sexo;
            masc.Edad = mascota.Edad;
            masc.Peso = mascota.Peso;
            masc.Altura = mascota.Altura;
            masc.Raza = mascota.Raza;
            masc.Propietario = mascota.Propietario;
            return true;
        }
        public bool EliminarMascota(int idMascota)
        {
            var masc = mascotas.Find(x => x.idMascota == idMascota);
            if (masc == null)
                return false;
            mascotas.Remove(masc);
            return true;
        }
        public List<Mascota> ObtenerMascotas()
        {
            return mascotas.ToList();
        }
        public List<Mascota> ObtenerMascotasPorPropietario(int idPropietario)
        {
            return mascotas.FindAll(x => x.Propietario.idPersona == idPropietario);
        }
        public Mascota ObtenerMascota(int idMascota)
        {
            return mascotas.Find(x => x.idMascota == idMascota);
        }
    }
}
