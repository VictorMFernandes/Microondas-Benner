using System;
using System.Windows.Forms;

namespace Microondas.UI
{
	public partial class Principal : Form
	{
		private BLL.Microondas microondas;

		public Principal()
		{
			InitializeComponent();
			Inicializacao();
		}

		private void Inicializacao()
		{
			microondas = BLL.Microondas.PegarInstancia();
		}

		private void BtnAquecerClick(object sender, System.EventArgs e)
		{
			ExecutarMicroondas(microondas.Aquecer(TxTempo.Text, TxPotencia.Text));
		}

		private void ExecutarMicroondas(BLL.Configuracao configuracao)
		{
			TxConsole.Text = string.Empty;

			if (microondas.LogErros.Count > 0)
			{
				TxConsole.Text = string.Join("\r\n", microondas.LogErros);
				microondas.Resetar();
			}



			AcionarInterface(configuracao);
		}

		private void AcionarInterface(BLL.Configuracao configuracao)
		{

		}
	}
}
