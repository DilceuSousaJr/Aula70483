using System;
using System.Collections.Generic;

namespace Meu_projeto_git1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> minhaLista = new List<string>
            {
                "Felipe",
                "Bruno",
                "Dilceu",
                "Rafael",
                "Eduardo",
                "Bruna"
            };

            minhaLista.ForEach(x => Console.WriteLine(x));



            Console.ReadKey(true);
        }
    }
}
