using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.BLL
{
	public class Configuracao
	{
		public int Tempo { get; set; }
		public int Potencia { get; set; }

		public Configuracao(int tempo, int potencia)
		{
			Tempo = tempo;
			Potencia = potencia;
		}
	}
}
