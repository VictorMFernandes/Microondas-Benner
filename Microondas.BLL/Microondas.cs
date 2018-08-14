using Microondas.BLL.ProgramasEstrategias;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Microondas.BLL
{
	public class Microondas
	{
		static private Microondas instancia;
		public string TextoEntrada { get; set; }
		static public readonly int potenciaPadrao = 8;
		static public readonly int tempoPadrao = 30;
		public Programa Programa { get; set; }
		public List<Programa> ProgramasPreDefinidos { get; set; }
		public string CaminhoArquivo { get; set; }

		public HashSet<string> LogErros { get; set; }

		private Microondas()
		{
			LogErros = new HashSet<string>();

			//Inscreve os programas pré-definidos que já existem
			ProgramasPreDefinidos = new List<Programa>()
			{
				new ProgramaArroz(),
				new ProgramaCostela(),
				new ProgramaFrango(),
				new ProgramaPipoca(),
				new ProgramaNuggets()
			};
		}

		static public Microondas PegarInstancia()
		{
			return instancia ?? new Microondas();
		}

		public Programa Aquecer(string tempo, string potencia, string txEntrada = "")
		{
			//Se txEntrada for o caminho para algum arquivo
			if (File.Exists(txEntrada))
			{
				CaminhoArquivo = txEntrada;
				TextoEntrada = File.ReadAllText(txEntrada).ToLower();
			}
			else
			{
				TextoEntrada = txEntrada.ToLower();
			}			

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

		public void RegistrarPrograma(string linhaComando)
		{
			var comandos = linhaComando.Split(',');

			if (int.TryParse(comandos[2], out int tempo))
			{
				if (int.TryParse(comandos[3], out int potencia))
				{
					if (ValidarTempo(tempo.ToString()) == 0 || ValidarPotencia(potencia.ToString()) == 0)
					{
						return;
					}
					ProgramasPreDefinidos.Add(new ProgramaCustomizavel(comandos[0].Trim(), comandos[1].Trim(), tempo, potencia, comandos[4].Trim()[0]));
				}
				else
				{
					LogErros.Add("-Potência deve ser um número");
				}
			}
			else
			{
				LogErros.Add("-Tempo deve ser um número");
			}
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
			if (ProgramasPreDefinidos.Any(p => p.Nome.ToLower().Contains(TextoEntrada)))
			{
				return ProgramasPreDefinidos
								.FirstOrDefault(p => p.Nome.ToLower().Contains(TextoEntrada));
			}

			LogErros.Add("-Alimento incompatível com o programa.");
			return null;
		}
	}
}
