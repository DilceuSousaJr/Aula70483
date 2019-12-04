using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCivilDeNomes
{
    class Program
    {
        static List<string> ListaDeNomes = new List<string>();
        static void Main(string[] args)
        {




            var menuEscolhido = "0";

            while(menuEscolhido != "5")
            {
                menuEscolhido = MostrarMenu();

                menuEscolhido = Console.ReadLine();


                switch (menuEscolhido)
                {
                    case "1":
;
                        break;
                    case "2":

                        break;
                    case "3":
                        EditarUmNome();
                        break;
                    default:
                        Console.WriteLine("Menu Invalido");
                        Console.ReadKey(true);
                        break;
                }

                Console.Clear();
            }

            Console.ReadKey(true);
        }
        static void EditarUmNome()

        {
            Console.Write("Edição de nomes do sisitema de registros");

            var numerador = 0;

            ListaDeNomes.ForEach(x => Console.WriteLine("Nome:{0,-10}Número:{1,-10}",x,"numero" + numerador++));

            Console.WriteLine("Informe o numero para edição");

            var index = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um novo nome para registro");

            var novoNome = Console.ReadLine();

            ListaDeNomes[index] = novoNome;

            Console.WriteLine("Registro alterado com sucesso!");

            Console.ReadKey(true);
        }

        static void MensagemInicial()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**SISTEMA DE REGISTRO**");
            Console.WriteLine("***********************");
        }
        static void ListarNome()
        {
            Console.WriteLine("Listagem de Nome Selecionado");

            ListaDeNomes.ForEach(x => Console.WriteLine($"Nome: {x}"));

            Console.WriteLine("Listagem de nomes finalizada");
            Console.ReadKey(true);
        }
        static void RegistrarNome()
        {
            Console.WriteLine("Registro de Nome Selecionado");
            Console.WriteLine("Informa um Nome:");
            var nomeInformado = Console.ReadLine();


            ListaDeNomes.Add(nomeInformado);

            Console.WriteLine("Nome Informado com Sucesso!");
            Console.ReadKey(true);
        }
        static string MostrarMenu()
        {
            Console.WriteLine("Digite o numero para opção desejada:");
            Console.WriteLine("1 - Registrar Nome");
            Console.WriteLine("2 - Listar Nomes");
            Console.WriteLine("3 - Editar Um Nome");
            Console.WriteLine("4 - Excluir Nomes");
            Console.WriteLine("5 - Sair do Sistema");

            return Console.ReadLine();
        }
    }
}
