using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DALL
{
    public class PropietarioRepository:FileRepository<Propietario>
    {
        public PropietarioRepository(string ruta) : base(ruta)
        {

        }

        public override List<Propietario> Consultar()
        {
            try
            {
                List<Propietario> listaP = new List<Propietario>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    listaP.Add(Mappear(sr.ReadLine()));
                }
                return listaP;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override Propietario Mappear(string datos)
        {
            // Declaramos todos los parametros obteniendolos de datos
            // Llamamos el constructor que asigna los datos a propietario
            // y a persona
            int idPropietario = int.Parse(datos.Split(';')[0]);
            int idPersona = int.Parse(datos.Split(';')[1]);
            string tipoDocumento = datos.Split(';')[2];
            string nroDocumento = datos.Split(';')[3];
            string nombreCompleto = datos.Split(';')[4];
            string direccion = datos.Split(';')[5];
            string telefono = datos.Split(';')[6];
            string email = datos.Split(';')[7];
            //new list<Mascota>() es una lista vacía porque el prop se crea cuando no hay mascotas
            Propietario prop = new Propietario(idPersona, tipoDocumento, nroDocumento, nombreCompleto, direccion, telefono, email, idPropietario,new List<Mascota>());
            return prop;

        }
    }
}
