namespace Microondas.BLL.ProgramasEstrategias
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
