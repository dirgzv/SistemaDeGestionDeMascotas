using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PropietarioRepositoryList : IPropietarioRepository
    {
        private static List<Propietario> propietarios = new List<Propietario>();
        public bool AgregarPropietario(Propietario propietario)
        {
            if (propietario == null || propietarios.Any(p => p.idPersona == propietario.IdidPersona)
                return false;
            propietarios.Add(propietario);
            return true;
        }
        public bool ModificarPropietario(Propietario propietario)
        {
            var prop = propietarios.FirstOrDefault(p => p.idPersona == propietario.idPersona);
            if (prop == null)
                return false;
            prop.idPersona = propietario.Id;
            prop.TipoDocumento = propietario.TipoDocumento;
            prop.NroDocumento = propietario.NroDocumento;
            prop.NombreCompleto = propietario.NombreCompleto;
            prop.Direccion = propietario.Direccion;
            prop.Telefono = propietario.Telefono;
            prop.Email = propietario.Email;
            prop.Mascotas = propietario.Mascotas;
            return true;
        }
        public bool EliminarPropietario(int idPropietario)
        {
            var prop = propietarios.FirstOrDefault(p => p.idPersona == idPropietario);
            if (prop == null)
                return false;
            propietarios.Remove(prop);
            return true;
        }
        public List<Propietario> ObtenerPropietarios()
        {
            return propietarios.ToList();
        }
        public Propietario ObtenerPropietario(int idPropietario)
        {
            return propietarios.FirstOrDefault(p => p.idPersona == idPropietario);
        }
    }
}
