namespace Microondas.BLL.ProgramasEstrategias
{
	class ProgramaPeixe : Programa
	{
		public override string Nome { get; set; } = "Programa Peixe";
		public override string Instrucoes { get; set; } = "Esse programa deve ser utilizado para aquecer peixes";
		public override Configuracao Configuracao { get; set; } = new Configuracao(50, 3);
		public override char Caracter { get; set; } = 'P';

		public ProgramaPeixe()
		{

		}
	}
}
