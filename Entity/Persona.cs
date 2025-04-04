using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Persona
    {
        protected int idPersona { get; set; }
        protected string tipoDocumento { get; set; }
        protected string nroDocumento { get; set; }
        protected string nombreCompleto { get; set; }
        protected string direccion { get; set; }
        protected string telefono { get; set; }
        protected string email { get; set; }
    }

}
