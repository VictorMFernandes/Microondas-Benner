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


			microondas.Aquecer(TxTempo.Text, TxPotencia.Text);
		}
	}
}
