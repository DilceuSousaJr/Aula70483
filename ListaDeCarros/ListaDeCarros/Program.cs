using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCarros
{
    class Program
    {

        static List<string> ListaCarros = new List<string>
        {
                "Golf Sapão 2004",
                "Bmw E39 1998",
                "Jetta TSI 2015",
                "Mercedez AMG 2015",
                "Civic EXL 1994"
            };
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de carros");
            ListaCarros.ForEach(x => Console.WriteLine(x));

            Console.ReadKey(true);
        }
        

    }
    
}
