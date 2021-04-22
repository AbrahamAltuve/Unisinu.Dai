using System;
using System.Collections.Generic;
using System.Linq;

namespace Unisinu.Dai
{
    public static class servicioPersona
    {

        public static List<DiagramaPersona> listarPersonas()
        {
            Console.WriteLine("Listar personas");

            List<DiagramaPersona> listPersonas = new List<DiagramaPersona>();
            DiagramaPersona obpersona = null;

            using (personasEntities db = new personasEntities())
            {
                var persons = (from a in db.persona 
                               orderby a.apellido, a.nombre, a.documento descending
                               select a);

                foreach(persona person in persons)
                {
                    obpersona = new DiagramaPersona();
                    obpersona.id = person.id;
                    obpersona.nombre = person.nombre;
                    obpersona.apellido = person.apellido;
                    obpersona.documento = person.documento;
                    obpersona.email = person.email;
                    obpersona.telefono = person.telefono;
                    listPersonas.Add(obpersona);
                    string srep = person.apellido;
                    Console.WriteLine(srep);
                }
                
            }
            return listPersonas;
        }

        public static DiagramaPersona consultarPorCorreo(string email )
        {
            Console.WriteLine("Consultar por email");

            DiagramaPersona obpersona = null;
            using (personasEntities db = new personasEntities())
            {
                var personas = (from a in db.persona select a).Sum(b => b.documento); 
                                                         
                foreach (persona person in personas)
                {
                    obpersona = new DiagramaPersona();
                    obpersona.id = person.id;
                    obpersona.nombre = person.nombre;
                    obpersona.apellido = person.apellido;
                    obpersona.documento = person.documento;
                    obpersona.email = person.email;
                    obpersona.telefono = person.telefono;

                    //string srep = person.apellido;
                    //Console.WriteLine(srep);
                }
            }
            return obpersona;
        }

        public static DiagramaPersona consultarPorDocumento(string documento)
        {
            Console.WriteLine("Consultar por documento");
            DiagramaPersona obpersona = null;
            using (personasEntities db = new personasEntities())
            {
                var personas = (from a in db.persona where a.documento == documento select a);
                foreach (persona person in personas)
                {
                    obpersona = new DiagramaPersona();
                    obpersona.id = person.id;
                    obpersona.nombre = person.nombre;
                    obpersona.apellido = person.apellido;
                    obpersona.documento = person.documento;
                    obpersona.email = person.email;
                    obpersona.telefono = person.telefono;

                    //string srep = person.apellido;
                    //Console.WriteLine(srep);
                }
            }
            return obpersona;
        }

        public static List<DiagramaPersona> listarPersonasMismoApellido(string apellido)
        {
            Console.WriteLine("Listar personas con el mismo apellido");
            List<DiagramaPersona> personasApellido = new List<DiagramaPersona>();
            DiagramaPersona obpersona = null;
            using (personasEntities db = new personasEntities())
            {
                var personas =  (from a in db.persona where a.apellido == apellido select a);

                foreach (persona person in personas)
                {
                    obpersona = new DiagramaPersona();
                    obpersona.id = person.id;
                    obpersona.nombre = person.nombre;
                    obpersona.apellido = person.apellido;
                    obpersona.documento = person.documento;
                    obpersona.email = person.email;
                    obpersona.telefono = person.telefono;
                    personasApellido.Add(obpersona);
                    string srep = person.apellido;
                    Console.WriteLine(srep);
                }
            }
            return personasApellido;
        }
    }
}
