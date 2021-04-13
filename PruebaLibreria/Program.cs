using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLibreria
{
    class Program
    {
        static void Main(string[] args)
        {
            Unisinu.Dai.servicioPersona.listarPersonas();
            Unisinu.Dai.servicioPersona.consultarPorCorreo("a@a.com");
            Unisinu.Dai.servicioPersona.consultarPorDocumento("12548851");
            Unisinu.Dai.servicioPersona.listarPersonasMismoApellido("Rodriguez");

        }
    }
}
