namespace Microondas.BLL.ProgramasEstrategias
{
	class ProgramaCostela : Programa
	{
		public override string Nome { get; set; } = "Programa Costela";
		public override string Instrucoes { get; set; } = "Esse programa deve ser utilizado para aquecer costelas";
		public override Configuracao Configuracao { get; set; } = new Configuracao(120, 9);
		public override char Caracter { get; set; } = 'C';

		public ProgramaCostela()
		{

		}
	}
}
