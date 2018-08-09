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

		private Microondas()
		{

		}

		static public Microondas PegarInstancia()
		{
			return instancia ?? new Microondas();
		}

		public void Aquecer(int tempo, int potencia)
		{

		}
	}
}
