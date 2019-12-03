using System;
using System.Collections.Generic;

namespace ListaComNomesDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> carros = new List<string>;
            {
                "Megane",
                "s10",
                "Jetta",
                "Golf",
            };

            carros.ForEach(x => Console.WriteLine(x));

            Console.ReadKey(true);
        }
    }
}
