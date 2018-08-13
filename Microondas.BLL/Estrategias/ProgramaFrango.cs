using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.BLL.Estrategias
{
	class ProgramaFrango : Programa
	{
		public override string Nome { get; set; } = "Programa Frango";
		public override string Instrucoes { get; set; } = "Esse programa deve ser utilizado para aquecer frangos";
		public override Configuracao Configuracao { get; set; } = new Configuracao(30, 8);
		public override char Caracter { get; set; } = 'F';

		public ProgramaFrango()
		{

		}
	}
}
