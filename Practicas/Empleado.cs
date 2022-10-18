using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    class Empleado
    {
        string nombre;

        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }
    }
}
