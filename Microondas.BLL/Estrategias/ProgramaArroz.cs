using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.BLL.Estrategias
{
	class ProgramaArroz : Programa
	{
		public override string Nome { get; set; } = "Programa Arroz";
		public override string Instrucoes { get; set; } = "Esse programa deve ser utilizado para aquecer arroz";
		public override Configuracao Configuracao { get; set; } = new Configuracao(100, 8);
		public override char Caracter { get; set; } = 'A';

		public ProgramaArroz()
		{

		}
	}
}
