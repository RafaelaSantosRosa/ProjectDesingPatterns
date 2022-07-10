using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Cidadao cidadao = new Cidadao();
                Console.WriteLine("Registre seu nome: ");
                cidadao.nome = Console.ReadLine();
                Console.WriteLine("Nome do seu candidato: ");
                cidadao.candidato = Console.ReadLine();

                Console.WriteLine("Votar - 1");
                Console.WriteLine("Ver resultado - 2");

               opcao  = Console.ReadLine();

                if (opcao == "1")
                {
                    Fachada fachada = new Fachada();
                    fachada.registrarVoto(cidadao);
                }
            }while(opcao != "0");
        }
    }

}

