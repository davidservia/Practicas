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
            #region Practica 5
            /*System.IO.StreamReader archivo = null;
            string linea = string.Empty;
            int valor;

            try
            {
                archivo = new System.IO.StreamReader(PATH);
                linea = archivo.ReadLine();
                while(!String.IsNullOrEmpty(linea))
                {
                    Console.WriteLine(linea);
                    linea = archivo.ReadLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (archivo != null)
                {
                    archivo.Close();
                }

                Console.WriteLine();
            }*/
            #endregion
            #region Practica 4
            /*static void Excepciones()
            {
                try {
                    Console.WriteLine("Introduce un número");
                    int valor = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Se ha leido {valor}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("El formato del número no es correcto");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("El número introducido es demasiado grande");
                }
            }*/
            #endregion
            #region Practica 3

            /*static void Practica3() {

                string respuesta = string.Empty;

                respuesta = LeerRespuesta2();

                (String.Equals(respuesta, REPETIR_BUCLE))
            {
                    respuesta = LeerRespuesta();


                }
                Console.WriteLine("Has salido del bucle");
            }

            static string LeerRespuesta2()
            {
                string respuesta = string.Empty;

                do
                {
                    Console.WriteLine("¿ Quieres entrar al bucle? (S/N)");
                    respuesta = Console.ReadLine().ToUpper();
                    if (!respuesta.Equals(REPETIR_BUCLE) && !respuesta.Equals(NO_REPETIR_BUCLE))
                    {
                        Console.WriteLine("Debes introducir N o S");
                    } while (!respuesta.Equals(REPETIR_BUCLE) && !respuesta.Equals(NO_REPETIR_BUCLE)) ;

                    return respuesta;
                }
            }*/
            #endregion
            #region Practica 2 
            /*Console.WriteLine("Introduzca tu edad, por favor");
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
            } */
            #endregion
            #region Practica 1
            /* Console.WriteLine("Introduzca una medida de un radio para calcular el area de un circulo");
                 Double radio = Double.Parse(Console.ReadLine());
                 Double area = Math.PI * Math.Pow(radio, 2);
                 Console.WriteLine($"El area de la circunferencia es {area}  y el radio introducido es: {radio}");
            */
            #endregion
        }
        static void Tarea1()
        {
            Empleado emple = new Empleado("David");
            Console.WriteLine(emple.GetNombre());
        }






    }
}
