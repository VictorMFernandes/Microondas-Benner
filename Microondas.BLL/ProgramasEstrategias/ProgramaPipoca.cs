namespace Microondas.BLL.ProgramasEstrategias
{
	class ProgramaPipoca : Programa
	{
		public override string Nome { get; set; } = "Programa Pipoca";
		public override string Instrucoes { get; set; } = "Esse programa deve ser utilizado para fazer pipoca";
		public override Configuracao Configuracao { get; set; } = new Configuracao(45, 6);
		public override char Caracter { get; set; } = 'P';

		public ProgramaPipoca()
		{

		}
	}
}
