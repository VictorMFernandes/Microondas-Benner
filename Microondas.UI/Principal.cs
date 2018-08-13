using System;
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
			microondas = BLL.Microondas.PegarInstancia();
			timer = new Timer();
			timer.Tick += new EventHandler(AtualizarInterface);
			timer.Interval = 1000;
		}

		private void BtnAquecerClick(object sender, System.EventArgs e)
		{
			PrepararMicroondas(microondas.Aquecer(TxTempo.Text, TxPotencia.Text, TxEntrada.Text));
		}

		private void BtnAquecerRapidoClick(object sender, System.EventArgs e)
		{
			PrepararMicroondas(microondas.Aquecer(BLL.Microondas.tempoPadrao.ToString(), BLL.Microondas.potenciaPadrao.ToString()));
		}

		private void PrepararMicroondas(BLL.Estrategias.Programa programa)
		{
			TxConsole.Text = string.Empty;

			if (microondas.LogErros.Count > 0)
			{
				TxConsole.Text = string.Join("\r\n", microondas.LogErros);
				microondas.Resetar();
				return;
			}

			LigarMicroondas(programa);
		}

		private void LigarMicroondas(BLL.Estrategias.Programa programa)
		{
			timer.Start();
			LblAquecida.Text = programa.Configuracao.Tempo.ToString();
			LblPotencia.Text = $"Potência: {programa.Configuracao.Potencia.ToString()}";
		}

		private void AtualizarInterface(Object sender, EventArgs e)
		{
			if (int.TryParse(LblAquecida.Text, out int res))
			{
				if (res <= 0)
				{
					LblAquecida.Text = "Aquecida";
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
				LblAquecida.Text = (--res).ToString();
			}
		}

		private void ResetarInterface()
		{
			TxEntrada.Text = microondas.TextoEntrada;
		}

	}
}
