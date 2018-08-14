using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.BLL.ProgramasEstrategias
{
	class ProgramaCustomizavel : Programa
	{
		public override string Nome { get; set; }
		public override string Instrucoes { get; set; }
		public override Configuracao Configuracao { get; set; }
		public override char Caracter { get; set; }

		public ProgramaCustomizavel(string nome, string instrucoes, int tempo, int potencia, char caracter)
		{
			Nome = nome;
			Instrucoes = instrucoes;
			Configuracao = new Configuracao(tempo, potencia);
			Caracter = caracter;
		}
	}
}
