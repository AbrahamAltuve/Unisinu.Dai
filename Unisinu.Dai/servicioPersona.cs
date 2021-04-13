using System;
using System.Linq;

namespace Unisinu.Dai
{
    public static class servicioPersona
    {

        public static void listarPersonas()
        {
            Console.WriteLine("Listar personas");
            
            using (personaEntities db = new personaEntities())
            {
                var personas = (from a in db.persona select a);

                foreach(persona person in personas)
                {
                    string srep = person.apellido;
                    Console.WriteLine(srep);
                }
                
            }
        }

        public static void consultarPorCorreo(string email )
        {
            Console.WriteLine("Consultar por email");
            using (personaEntities db = new personaEntities())
            {
                var personas = (from a in db.persona where a.email == email select a);
                foreach (persona person in personas)
                {
                    string srep = person.apellido;
                    Console.WriteLine(srep);
                }
            }
        }

        public static void consultarPorDocumento(string documento)
        {
            Console.WriteLine("Consultar por documento");
            using (personaEntities db = new personaEntities())
            {
                var personas = (from a in db.persona where a.documento == documento select a);
                foreach (persona person in personas)
                {
                    string srep = person.apellido;
                    Console.WriteLine(srep);
                }
            }
        }

        public static void listarPersonasMismoApellido(string apellido)
        {
            Console.WriteLine("Listar personas con el mismo apellido");
            using (personaEntities db = new personaEntities())
            {
                var personas = (from a in db.persona where a.apellido == apellido select a);
                foreach (persona person in personas)
                {
                    string srep = person.apellido;
                    Console.WriteLine(srep);
                }
            }
        }
    }
}
