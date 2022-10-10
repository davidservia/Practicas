using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una medida de un radio para calcular el area de un circulo");
            Double radio = Double.Parse(Console.ReadLine());
            Double area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine($"El area de la circunferencia es {area}  y el radio introducido es: {radio}");


        }
    }
}
