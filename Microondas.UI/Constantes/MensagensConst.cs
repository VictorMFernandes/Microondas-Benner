using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroondasBenner
{
	class MensagensConst
	{
		public static readonly string fontePrincipal = "Microsoft Sans Serif";
		public static readonly List<string> msgInicial = new List<string>()
		{
			"-Bem-Vindo!",
			"-Utilize os campos \"Potência\" e \"Tempo de Cozimento\" para parametrizar seu aquecimento, " +
			"em seguida aperte o botão \"Aquecer\" para iniciá-lo.",
			"-Se preferir, utilize um dos programas pré-definidos digitando o nome do alimento que deseja aquecer, " +
			"em seguida aperte o botão \"Aquecer\" para iniciar o aquecimento.",
			"-Você pode parar o aquecimento clicando no botão \"Parar\", então você pode retomá-lo clicando no botão " +
			"\"Aquecer\", ou cancelar o aquecimento clicando em \"Parar\" novamente",
			"-Se quiser utilizar um dos arquivos encontrados na pasta ArquivosEntrada para aquecer, digite o nome desse" +
			" arquivo e aperte o botão \"Aquecer\"",
			"-Você também pode enviar mensagens pelo campo entrada para executar as seguintes funções:",
			"--programas ->  mostra todos os programas pré-definidos do microondas",
			"--nomeDoAlimento ->  mostra o programa pré-definido para o alimento especificado, caso exista",
			"--criar nome,instrucoes,tempo,potencia,caracter->  cria um programa que poderá ser usado posteriormente " +
			"com as características escolhidas"
		};
	}
}
