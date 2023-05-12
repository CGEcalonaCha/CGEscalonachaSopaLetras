using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGEscalonachaSopaLetras
{
    internal class SopaLetras
    {
        string palabra;
        public void OrdenAlfabetico()
        {
            Console.WriteLine("Escriba la Palabra");
            string palabra = Console.ReadLine();

            string orden = new string(palabra.OrderBy(x => x).ToArray());
            Console.WriteLine(orden);
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
