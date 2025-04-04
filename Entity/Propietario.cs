﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Propietario : Persona
    {
        List<Mascota> mascotas { get; set; }
        public Propietario() { }
        public Propietario(int idPersona, string tipoDocumento, string nroDocumento, string nombreCompleto, string direccion, string telefono, string email, List<Mascota> mascotas)
        {
            this.idPersona = idPersona;
            this.tipoDocumento = tipoDocumento;
            this.nroDocumento = nroDocumento;
            this.nombreCompleto = nombreCompleto;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.mascotas = mascotas;
        }

    }
}
