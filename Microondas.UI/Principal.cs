using MicroondasBenner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Microondas.UI
{
	public partial class Principal : Form
	{
		private BLL.Microondas microondas;
		private Timer timer;
		private string textoEntrada;

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
		}

		#region Métodos de controle dos botões
		private void BtnAquecerClick(object sender, System.EventArgs e)
		{
			PrepararInterface(microondas.Aquecer(TxTempo.Text, TxPotencia.Text, TxEntrada.Text));
		}

		private void BtnAquecerRapidoClick(object sender, System.EventArgs e)
		{
			PrepararInterface(microondas.Aquecer(BLL.Microondas.tempoPadrao.ToString(), BLL.Microondas.potenciaPadrao.ToString()));
		}
		private void BtnEnviarClick(object sender, EventArgs e)
		{

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
			if (int.TryParse(LblConsole.Text, out int res))
			{
				if (res <= 0)
				{
					MostrarMsgConsole("Aquecida", MicroondasConst.modoAquecimento);
					ResetarInterface();
					timer.Stop();
					return;
				}

				StringBuilder sb = new StringBuilder(TxEntrada.Text);

				for (int i = 0; i < microondas.Programa.Configuracao.Potencia; i++)
				{
					sb.Append(microondas.Programa.Caracter);
				}
				sb.Append(" ");

				TxEntrada.Text = sb.ToString();

				MostrarMsgConsole((--res).ToString(), MicroondasConst.modoAquecimento);
			}
		}

		private void ResetarInterface()
		{
			TxEntrada.Text = microondas.TextoEntrada;
		}
		#endregion
		
		#region Métodos do console
		private void MostrarMsgConsole(string mensagem, char? modo = null)
		{
			LblConsole.Text = string.Empty;

			modo = modo ?? MicroondasConst.modoConsole;

			var texto = string.Join("\r\n", mensagem);

			if (modo == MicroondasConst.modoConsole)
			{
				LblConsole.Font = new System.Drawing.Font(MensagensConst.fontePrincipal, 14f);
				LblConsole.ForeColor = System.Drawing.Color.White;
				LblConsole.TextAlign = System.Drawing.ContentAlignment.TopLeft;
				LblConsole.Text = texto;
			}
			else if (modo == MicroondasConst.modoAquecimento)
			{
				LblConsole.Font = new System.Drawing.Font(MensagensConst.fontePrincipal, 70f);
				LblConsole.ForeColor = System.Drawing.Color.Red;
				LblConsole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				LblConsole.Text = texto;
			}
			else if (modo == MicroondasConst.modoErro)
			{
				LblConsole.Font = new System.Drawing.Font(MensagensConst.fontePrincipal, 20f);
				LblConsole.ForeColor = System.Drawing.Color.Red;
				LblConsole.TextAlign = System.Drawing.ContentAlignment.TopLeft;
				LblConsole.Text = texto;
			}
		}

		private void MostrarMsgConsole(List<string> mensagem, char? modo = null)
		{
			var texto = string.Join("\r\n", mensagem);

			MostrarMsgConsole(texto, modo);
		}

		private void LimparMsgConsole()
		{
			LblConsole.Text = string.Empty;
		}
		#endregion
	}
}
