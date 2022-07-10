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
        private int numeroVotosCandidato1 = 0;
        private int numeroVotosCandidato2 = 0;

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
            var lines = new List<string>();
            lines = LerArquivoVotacao();

            lines.Add(candidato);

            var caminhoArquivoTxt = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\..\\..\\ResultadoVotacao.txt";
            File.WriteAllLines(caminhoArquivoTxt, lines);
        }

        public string ResultadoEleicao()
        {
            List<string> linhas = new List<string>();
            linhas = LerArquivoVotacao();

            foreach (var line in linhas)
            {
                if (line.Equals("jose", StringComparison.OrdinalIgnoreCase))
                    numeroVotosCandidato1 += 1;

                else if(line.Equals("maria", StringComparison.OrdinalIgnoreCase))
                    numeroVotosCandidato2 += 2;
            }

            if(numeroVotosCandidato1 > numeroVotosCandidato2)
                return $"José venceu, com {numeroVotosCandidato1} votos";

            else
                return $"Maria venceu, com {numeroVotosCandidato2} votos";
        }

        private static List<string> LerArquivoVotacao()
        {
            var caminhoArquivoTxt = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\..\\..\\ResultadoVotacao.txt";
            return File.ReadAllLines(caminhoArquivoTxt).ToList();
        }
    }
}
