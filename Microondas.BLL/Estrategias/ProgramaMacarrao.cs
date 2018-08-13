using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.BLL.Estrategias
{
	class ProgramaMacarrao : Programa
	{
		public override string Nome { get; set; } = "Programa Macarrão";
		public override string Instrucoes { get; set; } = "Esse programa deve ser utilizado para aquecer macarrão";
		public override Configuracao Configuracao { get; set; } = new Configuracao(45, 6);
		public override char Caracter { get; set; } = 'M';

		public ProgramaMacarrao()
		{

		}
	}
}
