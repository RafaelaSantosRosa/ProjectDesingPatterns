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

        public int i = 1;
        public static Governo Eleicao
        {
            get
            {
                if (eleicao == null)
                    eleicao = new Governo();
                return eleicao;
            }
        }

        public void DoSomething()
        {
            var a = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); 
            string[] lines = File.ReadAllLines(a + "\\ResultadoVotacao.txt");
        }

    }
}
