using MicroondasBenner;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Microondas.UI
{
	public partial class Principal : Form
	{
		private BLL.Microondas microondas;
		private Timer timer;
		private bool parado;
		private string caminhoArquivos;

		public Principal()
		{
			InitializeComponent();
			Inicializacao();
		}

		private void Inicializacao()
		{
			//Pega o singleton Microondas
			microondas = BLL.Microondas.PegarInstancia();
			//Cuida do cronômetro
			timer = new Timer();
			timer.Tick += new EventHandler(AtualizarInterface);
			timer.Interval = 1000;
			//Mostra a mensagem inicial no console do Microondas
			MostrarMsgConsole(MensagensConst.msgInicial);
			//Traz o label que mostra a potência selecionada para frente
			LblPotencia.BringToFront();
			//Pega o caminho para a pasta de arquivos
			var caminhoExe = Path.GetDirectoryName(Application.ExecutablePath);
			var caminhoApp = Path.GetFullPath(Path.Combine(caminhoExe, @"..\..\.."));
			caminhoArquivos = Path.Combine(caminhoApp, @"Microondas.BLL\ArquivosEntrada");
		}

		#region Métodos de controle dos botões
		private void BtnAquecerClick(object sender, System.EventArgs e)
		{
			//Caso o microondas esteja pausado, retomar o aquecimento
			if (parado)
			{
				timer.Start();
				parado = false;
				return;
			}
			//Testa o texto de entrada para ver se é um arquivo
			if (File.Exists(Path.Combine(caminhoArquivos, TxEntrada.Text)))
			{
				PrepararInterface(microondas.Aquecer(TxTempo.Text, TxPotencia.Text, Path.Combine(caminhoArquivos, TxEntrada.Text)));
				return;
			}
			//Caso o campo entrada seja o caminho para um arquivo
			PrepararInterface(microondas.Aquecer(TxTempo.Text, TxPotencia.Text, TxEntrada.Text));
		}
		private void BtnAquecerRapidoClick(object sender, System.EventArgs e)
		{
			PrepararInterface(microondas.Aquecer(BLL.Microondas.tempoPadrao.ToString(), BLL.Microondas.potenciaPadrao.ToString()));
		}
		private void BtnEnviarClick(object sender, EventArgs e)
		{
			DecidirComando();
		}
		private void BtnResetarConsoleClick(object sender, EventArgs e)
		{
			MostrarMsgConsole(MensagensConst.msgInicial);
		}
		private void BtnPararClick(object sender, EventArgs e)
		{
			if (!parado)
			{
				timer.Stop();
				parado = true;
			}
			//Se já estiver parado, resetar a interface
			else
			{
				ResetarInterface();
				parado = false;
			}
		}
		#endregion

		#region Métodos de manipulação da interface
		private void PrepararInterface(BLL.ProgramasEstrategias.Programa programa)
		{
			LimparMsgConsole();

			if (microondas.LogErros.Count > 0)
			{
				MostrarMsgConsole(microondas.LogErros.ToList(), MicroondasConst.modoErro);
				microondas.Resetar();
				return;
			}

			LigarInterface(programa);
		}

		private void LigarInterface(BLL.ProgramasEstrategias.Programa programa)
		{
			timer.Start();
			MostrarMsgConsole(programa.Configuracao.Tempo.ToString(), MicroondasConst.modoAquecimento);
			LblPotencia.Text = $"Potência: {programa.Configuracao.Potencia.ToString()}";
		}

		private void AtualizarInterface(Object sender, EventArgs e)
		{
			if (int.TryParse(TxConsole.Text, out int res))
			{
				if (res <= 0)
				{
					MostrarMsgConsole("Aquecida", MicroondasConst.modoAquecimento);
					timer.Stop();
					TxEntrada.Text = string.Empty;
					LblPotencia.Text = string.Empty;
					return;
				}

				StringBuilder sb;

				sb = new StringBuilder(TxEntrada.Text);

				for (int i = 0; i < microondas.Programa.Configuracao.Potencia; i++)
				{
					sb.Append(microondas.Programa.Caracter);
				}
				sb.Append(" ");

				TxEntrada.Text = sb.ToString();
				
				if (!string.IsNullOrWhiteSpace(microondas.CaminhoArquivo))
				{
					AlterarArquivo(sb.ToString());
				}

				//Atualizar Cronômetro
				MostrarMsgConsole((--res).ToString(), MicroondasConst.modoAquecimento);
			}
		}

		private void ResetarInterface()
		{
			TxEntrada.Text = microondas.TextoEntrada;
			LimparMsgConsole();
			LblPotencia.Text = string.Empty;
		}
		#endregion

		#region Métodos do console
		private void MostrarMsgConsole(string mensagem, char? modo = null)
		{
			TxConsole.Text = string.Empty;

			modo = modo ?? MicroondasConst.modoConsole;

			var texto = string.Join("\r\n", mensagem);

			if (modo == MicroondasConst.modoConsole)
			{
				TxConsole.Font = new System.Drawing.Font(MensagensConst.fontePrincipal, 14f);
				TxConsole.ForeColor = System.Drawing.Color.White;
				TxConsole.TextAlign = HorizontalAlignment.Left;
				TxConsole.Text = texto;
			}
			else if (modo == MicroondasConst.modoAquecimento)
			{
				TxConsole.Font = new System.Drawing.Font(MensagensConst.fontePrincipal, 70f);
				TxConsole.ForeColor = System.Drawing.Color.Red;
				TxConsole.TextAlign = HorizontalAlignment.Center;
				TxConsole.Text = texto;
			}
			else if (modo == MicroondasConst.modoErro)
			{
				TxConsole.Font = new System.Drawing.Font(MensagensConst.fontePrincipal, 20f);
				TxConsole.ForeColor = System.Drawing.Color.Red;
				TxConsole.TextAlign = HorizontalAlignment.Left;
				TxConsole.Text = texto;
			}
		}

		private void MostrarMsgConsole(List<string> mensagem, char? modo = null)
		{
			var texto = string.Join("\r\n", mensagem);

			MostrarMsgConsole(texto, modo);
		}

		private void LimparMsgConsole()
		{
			MostrarMsgConsole(MensagensConst.msgInicial);
		}

		private void DecidirComando(string texto = "")
		{
			if (!string.IsNullOrWhiteSpace(texto))
			{
				TxEntrada.Text = texto;
			}

			//Se for o comando programas
			if (TxEntrada.Text.ToLower() == "programas")
			{
				StringBuilder sb = new StringBuilder();

				foreach (var programa in microondas.ProgramasPreDefinidos)
				{
					sb.Append(string.Join("\r\n", programa.PegarInfo()));
					sb.Append("\r\n");
				}

				MostrarMsgConsole(sb.ToString());
			}
			//Se o comando para pegar informações de um programa
			else if (microondas.ProgramasPreDefinidos.Any(p => p.Nome.ToLower().Contains(TxEntrada.Text.ToLower())))
			{
				var programa = microondas
								.ProgramasPreDefinidos
								.FirstOrDefault(p => p.Nome.ToLower().Contains(TxEntrada.Text.ToLower()));
				MostrarMsgConsole(programa.PegarInfo());
			}
			//Se for o comando criar programa
			else if (TxEntrada.Text.ToLower().StartsWith("criar "))
			{
				var comando = TxEntrada.Text.Substring("criar ".Length - 1);

				microondas.RegistrarPrograma(comando);

				if (microondas.LogErros.Count > 0)
				{
					MostrarMsgConsole(microondas.LogErros.ToList(), MicroondasConst.modoErro);
					microondas.Resetar();
					return;
				}
				else
				{
					MostrarMsgConsole("-Programa criado com sucesso!");
					TxEntrada.Text = string.Empty;
				}
			}
			//Se for um arquivo válido
			else if (File.Exists(Path.Combine(caminhoArquivos, TxEntrada.Text)))
			{
				DecidirComando(File.ReadAllText(Path.Combine(caminhoArquivos, TxEntrada.Text)).ToLower());
			}
		}
		#endregion

		#region Métodos de Arquivo

		private void AlterarArquivo(string msg)
		{
			try
			{
				using (FileStream fs = new FileStream(microondas.CaminhoArquivo, FileMode.Create))
				{
					using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
					{
						w.WriteLine(msg);
					}
				}
			}
			catch
			{

			}
		}

		#endregion
	}
}
