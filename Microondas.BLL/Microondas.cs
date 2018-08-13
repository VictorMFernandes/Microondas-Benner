using Microondas.BLL.Estrategias;
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
		public string TextoEntrada { get; set; }
		static public readonly int potenciaPadrao = 8;
		static public readonly int tempoPadrao = 30;
		public Programa Programa { get; set; }

		public HashSet<string> LogErros { get; set; }

		private Microondas()
		{
			LogErros = new HashSet<string>();
		}

		static public Microondas PegarInstancia()
		{
			return instancia ?? new Microondas();
		}

		public Programa Aquecer(string tempo, string potencia, string txEntrada = "")
		{
			TextoEntrada = txEntrada.ToLower();

			if (!string.IsNullOrEmpty(TextoEntrada))
			{
				return Programa = DefinirPrograma();
			}

			return Programa = new ProgramaPadrao(ValidarTempo(tempo), ValidarPotencia(potencia));
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
				if (resultado > 120 || resultado < 1)
				{
					LogErros.Add("-Tempo inválido, escolha um valor entre 1 e 120 segundos.");
				}
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
				if (resultado > 10 || resultado < 1)
				{
					LogErros.Add("-Potência inválida, escolha um valor entre 1 e 10.");
				}

				return resultado;
			}
			else
			{
				LogErros.Add("-Potência inválida.");
				return 0;
			}
		}

		private Programa DefinirPrograma()
		{
			if (TextoEntrada.Contains("frango"))
			{
				return new ProgramaFrango();
			}
			else if (TextoEntrada.Contains("peixe"))
			{
				return new ProgramaPeixe();
			}
			else if (TextoEntrada.Contains("arroz"))
			{
				return new ProgramaArroz();
			}
			else if (TextoEntrada.Contains("costela"))
			{
				return new ProgramaCostela();
			}
			else if (TextoEntrada.Contains("macarrão"))
			{
				return new ProgramaMacarrao();
			}

			LogErros.Add("-Alimento incompatível com o programa.");
			return null;
		}
	}
}
