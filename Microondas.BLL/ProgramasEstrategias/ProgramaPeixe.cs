namespace Microondas.BLL.ProgramasEstrategias
{
	class ProgramaNuggets : Programa
	{
		public override string Nome { get; set; } = "Programa Nuggets";
		public override string Instrucoes { get; set; } = "Esse programa deve ser utilizado para fazer nuggets";
		public override Configuracao Configuracao { get; set; } = new Configuracao(50, 3);
		public override char Caracter { get; set; } = 'N';

		public ProgramaNuggets()
		{

		}
	}
}
