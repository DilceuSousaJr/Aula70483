using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeCores
{
    class Program
    {
        static void Main(string[] args)

        {

            List<string> ListaDeCores = new List<string>();

            Console.WriteLine("*****COLOR SPEED*****");

            var numeroInformado = "0";

            while (numeroInformado != "3")
            {

                numeroInformado = MostrarMenu();

                switch (numeroInformado)
                {

                    case "1":
                        AdicionarCores();
                        break;
                    case "2":
                        ListarCores();
                        break;
                    default:
                        Console.WriteLine("Menu invalido");
                        Console.ReadKey(true);
                        break;
                }

                Console.Clear();

            }


            {
            
                    Console.WriteLine("Registro de Cor Selecionada");
                    Console.WriteLine("Informa uma Cor:");
                    var corInformada = Console.ReadLine();


                    ListaDeCores.Add(corInformada);

                    Console.WriteLine("Cor Informada com Sucesso!");
                    Console.ReadKey(true);

                    {
                        Console.WriteLine("Listagem de cores Selecionada");

                        ListaDeCores.ForEach(x => Console.WriteLine($"Cor: {x}"));

                        Console.WriteLine("Listagem de cores finalizada!");
                        Console.ReadKey(true);
                    }
                
            }

        }
        static void ListarCores()
        {

        }
        static void AdicionarCores()
        {

        }
        static string MostrarMenu()
        {

            Console.WriteLine("Digite a cor desejada:");
            Console.WriteLine("1 - Registrar Cor");
            Console.WriteLine("2 - Listar Cor");

            return Console.ReadLine();
        }


    }
}
