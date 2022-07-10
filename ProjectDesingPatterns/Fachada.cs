using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDesingPatterns
{
	public class Fachada
	{
		private Cidadao cidadao;

		public Fachada()
		{
			this.cidadao = new Cidadao();
		}

		public void registrarVoto(Cidadao cidadao)
		{
			Console.WriteLine("Olá, cidadão, seu nome é " + cidadao.nome);
			Console.WriteLine("Você votou no candidato(a) " + cidadao.candidato);
			var a = Governo.Eleicao;
			a.AdicionarVoto(cidadao.candidato);
			Console.WriteLine("O candidato " + cidadao.candidato + " recebeu seu voto!");
		}			

		public Cidadao getCidadao()
		{
			return cidadao;
		}

		public void setCidadao(Cidadao cidadao)
		{
			this.cidadao = cidadao;
		}
	}
}
