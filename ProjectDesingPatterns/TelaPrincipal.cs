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

                opcao = Console.ReadLine();

                if (opcao == "1")
                {

                    Cidadao cidadao = new Cidadao();
                    Console.WriteLine("Registre seu nome: ");
                    cidadao.nome = Console.ReadLine();
                    Console.WriteLine("Escolha o candidato: \nJosé - 1 \nMaria - 2");
                    cidadao.candidato = Console.ReadLine() == "1" ? "Jose" : "Maria";

                    Fachada fachada = new Fachada();
                    fachada.registrarVoto(cidadao);
                }
                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("\n" + Governo.Eleicao.ResultadoEleicao());
                }
            } while (opcao != "0");
        }
    }
}
