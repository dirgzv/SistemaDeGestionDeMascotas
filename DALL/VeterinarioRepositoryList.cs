using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class VeterinarioRepositoryList : IVeterinarioRepository
    {
        private static List<Veterinario> veterinarios = new List<Veterinario>();

        public bool AgregarVeterinario(Veterinario veterinario)
        {
            if (veterinario == null || veterinarios.Any(v => v.idPersona == veterinario.idPersona))
                return false; 

            veterinarios.Add(veterinario);
            return true;
        }

        public bool ModificarVeterinario(Veterinario veterinario)
        {
            var vet = veterinarios.FirstOrDefault(v => v.idPersona == veterinario.idPersona);
            if (vet == null)
                return false; 

            vet.idPersona = veterinario.idPersona;
            vet.tipoDocumento = veterinario.tipoDocumento;
            vet.nroDocumento = veterinario.nroDocumento;
            vet.nombreCompleto = veterinario.nombreCompleto;
            vet.Direccion = veterinario.Direccion;
            vet.Telefono = veterinario.Telefono;
            vet.Email = veterinario.Email;
            return true;
        }

        public bool EliminarVeterinario(int idVeterinario)
        {
            var vet = veterinarios.FirstOrDefault(v => v.idPersona == idVeterinario);
            if (vet == null)
                return false; 

            veterinarios.Remove(vet);
            return true;
        }

        public List<Veterinario> ObtenerVeterinarios()
        {
            return veterinarios.ToList(); 
        }

        public Veterinario ObtenerVeterinario(int idVeterinario)
        {
            return veterinarios.FirstOrDefault(v => v.idPersona == idVeterinario); 
        }
    }
}
