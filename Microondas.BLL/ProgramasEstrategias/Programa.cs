using System.Collections.Generic;

namespace Microondas.BLL.ProgramasEstrategias
{
	abstract public class Programa
	{
		abstract public string Nome { get; set; }
		abstract public string Instrucoes { get; set; }
		abstract public Configuracao Configuracao { get; set; }
		abstract public char Caracter { get; set; }

		public List<string> PegarInfo()
		{
			List<string> info = new List<string>()
			{
				$"-{Nome}",
				$"--{Instrucoes}",
				$"--Tempo: {Configuracao.Tempo} | Potência: {Configuracao.Potencia}",
				$"--Caracter: {Caracter}"
			};
			return info;
		}
	}
}
