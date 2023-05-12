using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGEscalonachaSopaLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SopaLetras sopaLetras = new SopaLetras();
           
           
          
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Bienvenido al Menu");
                Console.WriteLine("1. OrdenAlfabetico 1 ");
                Console.WriteLine("2. SimboloSimple 2 ");
            
                Console.WriteLine("5. Salir");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine();
                        sopaLetras.OrdenAlfabetico();


                        break;
                    case 2:

                        Console.WriteLine();
                     

                        break;
                  


                    case 5:
                        Console.WriteLine("Has elegido salir de la aplicación");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 4");
                        break;
                }

            }
        }
}
    }