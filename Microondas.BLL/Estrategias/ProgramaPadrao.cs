﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.BLL.Estrategias
{
	class ProgramaPadrao : Programa
	{
		public override string Nome { get; set; } = "Programa Padrão";
		public override string Instrucoes { get; set; } = "Você pode configurar esse programa preenchendo os parâmetros abaixo";
		public override Configuracao Configuracao { get; set; }
		public override char Caracter { get; set; } = '.';

		public ProgramaPadrao(int tempo, int potencia)
		{
			Configuracao = new Configuracao(tempo, potencia);
		}
	}
}
