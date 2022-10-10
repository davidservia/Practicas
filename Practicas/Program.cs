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
            #region Practica2
            Console.WriteLine("Introduzca tu edad, por favor");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Puede conducir, tiene carnet?");
                String siono;
                siono = Console.ReadLine();
                if (siono.Equals("si"))
                {
                    Console.WriteLine("Confirmado, puedes conducir");
                }
                else if (siono.Equals("no"))
                {
                    Console.WriteLine("No puedes conducir");
                }
            }
            else if (edad < 18)
            {
                Console.WriteLine("No puedes conducir ");
            }
            #endregion
        }
        #region Practica1
        /* Console.WriteLine("Introduzca una medida de un radio para calcular el area de un circulo");
             Double radio = Double.Parse(Console.ReadLine());
             Double area = Math.PI * Math.Pow(radio, 2);
             Console.WriteLine($"El area de la circunferencia es {area}  y el radio introducido es: {radio}");
        */
        #endregion



    }
}
