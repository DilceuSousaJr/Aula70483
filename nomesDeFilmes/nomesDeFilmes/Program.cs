using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomesDeFilmes
{
    class Program
    {
        static List<string> ListaDeNomes = new List<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("******************");
            Console.WriteLine("**NOME DE FILMES**");
            Console.WriteLine("******************");

            var menuSelecionado = "0";

            while (menuSelecionado != "5")
            { 
            Console.WriteLine("Digite o numero para opção desejada:");
            Console.WriteLine("1 - Registrar nome do filme");
            Console.WriteLine("2 - Listar nomes");
            Console.WriteLine("3 - Editar um nome");
            Console.WriteLine("4 - Excluir nomes");
            Console.WriteLine("5 - Sair do sistema");

            menuSelecionado = Console.ReadLine();

            switch (menuSelecionado)
            {
                case "1":
                    Console.WriteLine("Registro de Nome Selecionado");
                    Console.WriteLine("Informa um Nome:");
                    var nomeInformado = Console.ReadLine();


                    ListaDeNomes.Add(nomeInformado);

                    Console.WriteLine("Filme Informado com Sucesso!");
                    Console.ReadKey(true);
                    break;
                case "2":
                    Console.WriteLine("Listagem de Filme Selecionado");

                    ListaDeNomes.ForEach(x => Console.WriteLine($"Filme: {x}"));

                    Console.WriteLine("Listagem de filme finalizada");
                    Console.ReadKey(true);
                    break;
                default:
                    Console.WriteLine("Menu Invalido");
                    break;
            }

            Console.Clear();
        }

        Console.ReadKey(true);

        }
    }
}
