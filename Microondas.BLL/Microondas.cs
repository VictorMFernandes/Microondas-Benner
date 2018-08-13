using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.BLL
{
	public class Microondas
	{
		static private Microondas instancia;
		private readonly int potenciaPadrao = 8;

		public HashSet<string> LogErros { get; set; }

		private Microondas()
		{
			LogErros = new HashSet<string>();
		}

		static public Microondas PegarInstancia()
		{
			return instancia ?? new Microondas();
		}

		public Configuracao Aquecer(string tempo, string potencia)
		{
			return new Configuracao(ValidarTempo(tempo), ValidarPotencia(potencia));
		}

		public void Resetar()
		{
			LogErros = new HashSet<string>();
		}

		private int ValidarTempo(string tempo)
		{
			if (string.IsNullOrWhiteSpace(tempo))
			{
				LogErros.Add("-Por favor, insira um tempo de aquecimento.");
				return 0;
			}

			if (int.TryParse(tempo, out int resultado))
			{
				return resultado;
			}
			else
			{
				LogErros.Add("-Tempo de aquecimento inválido.");
				return 0;
			}
		}

		private int ValidarPotencia(string potencia)
		{
			if (string.IsNullOrWhiteSpace(potencia))
			{
				return potenciaPadrao;
			}

			if (int.TryParse(potencia, out int resultado))
			{
				return resultado;
			}
			else
			{
				LogErros.Add("-Potência inválida.");
				return 0;
			}
		}
	}
}
