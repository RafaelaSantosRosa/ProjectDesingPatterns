using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDesingPatterns
{
    public class Governo
    {

        private static Governo eleicao = null;
        private Governo() { }
        public static Governo Eleicao
        {
            get
            {
                if (eleicao == null)
                    eleicao = new Governo();
                return eleicao;
            }
        }

        public void AdicionarVoto(string candidato)
        {
            var caminhoArquivoTxt = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\..\\..\\ResultadoVotacao.txt";
            
            var lines = new List<string>();
            lines = File.ReadAllLines(caminhoArquivoTxt).ToList();

            lines.Add(candidato);
            File.WriteAllLines(caminhoArquivoTxt, lines);
        }

        public void ResultadoEleicao()
        {
            string[] lines = LerArquivoVotacao();

            lines.ToList().ForEach(s => Console.WriteLine(s.ToString()));

            Console.Read();
        }

        private static string[] LerArquivoVotacao()
        {
            var caminhoArquivoTxt = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return File.ReadAllLines(caminhoArquivoTxt + "\\ResultadoVotacao.txt");
        }
    }
}
