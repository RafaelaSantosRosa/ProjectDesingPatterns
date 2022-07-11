using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDesingPatterns.Telas
{
    public class TelaPrincipal
    {
        public void TelaEleicao()
        {
            string opcao;

            do
            {

                Console.WriteLine("Votar - 1");
                Console.WriteLine("Ver resultado - 2");
                Console.WriteLine("Sair - 0");

                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Cidadao cidadao = new Cidadao();
                        Console.WriteLine("\nRegistre seu nome: ");
                        cidadao.nome = Console.ReadLine();
                        Console.WriteLine("\nEscolha o candidato: \nJosé - 1 \nMaria - 2");
                        var candidatoEscolhido = Console.ReadLine();
                        cidadao.candidato = candidatoEscolhido == "1" ? "Jose" : candidatoEscolhido == "2" ? "Maria" : "Erro";
                        if(cidadao.candidato == "Erro")
                        {
                            Console.WriteLine("Erro! Candidato inválido.");
                            break;
                        }
                        Fachada fachada = new Fachada();
                        fachada.registrarVoto(cidadao);
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine($"\n{Governo.Eleicao.ResultadoEleicao()}\nPressione qualquer tecla para encerrar.");
                        Console.ReadLine();
                        opcao = "0";
                        break;

                    case "0": break;

                    default: Console.WriteLine("\nOpção inválida!\n");
                        break;
                }
            } while (opcao != "0");
        }
    }
}
