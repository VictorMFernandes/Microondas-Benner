namespace Microondas.UI
{
	partial class Principal
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TxEntrada = new System.Windows.Forms.TextBox();
			this.BtnAquecer = new System.Windows.Forms.Button();
			this.TxTempo = new System.Windows.Forms.TextBox();
			this.TxPotencia = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.BtnAquecRapido = new System.Windows.Forms.Button();
			this.BtnParar = new System.Windows.Forms.Button();
			this.LblAquecida = new System.Windows.Forms.Label();
			this.TxConsole = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// TxEntrada
			// 
			this.TxEntrada.Location = new System.Drawing.Point(498, 9);
			this.TxEntrada.Name = "TxEntrada";
			this.TxEntrada.Size = new System.Drawing.Size(268, 20);
			this.TxEntrada.TabIndex = 0;
			// 
			// BtnAquecer
			// 
			this.BtnAquecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.BtnAquecer.Location = new System.Drawing.Point(498, 367);
			this.BtnAquecer.Name = "BtnAquecer";
			this.BtnAquecer.Size = new System.Drawing.Size(170, 62);
			this.BtnAquecer.TabIndex = 1;
			this.BtnAquecer.Text = "Aquecer";
			this.BtnAquecer.UseVisualStyleBackColor = true;
			this.BtnAquecer.Click += new System.EventHandler(this.BtnAquecerClick);
			// 
			// TxTempo
			// 
			this.TxTempo.Location = new System.Drawing.Point(637, 267);
			this.TxTempo.Name = "TxTempo";
			this.TxTempo.Size = new System.Drawing.Size(137, 20);
			this.TxTempo.TabIndex = 2;
			// 
			// TxPotencia
			// 
			this.TxPotencia.Location = new System.Drawing.Point(637, 241);
			this.TxPotencia.Name = "TxPotencia";
			this.TxPotencia.Size = new System.Drawing.Size(137, 20);
			this.TxPotencia.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(498, 267);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Tempo de Cozimento:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(498, 241);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Potência:";
			// 
			// BtnAquecRapido
			// 
			this.BtnAquecRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.BtnAquecRapido.Location = new System.Drawing.Point(498, 299);
			this.BtnAquecRapido.Name = "BtnAquecRapido";
			this.BtnAquecRapido.Size = new System.Drawing.Size(268, 62);
			this.BtnAquecRapido.TabIndex = 6;
			this.BtnAquecRapido.Text = "Aquecimento Rápido";
			this.BtnAquecRapido.UseVisualStyleBackColor = true;
			// 
			// BtnParar
			// 
			this.BtnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.BtnParar.Location = new System.Drawing.Point(674, 367);
			this.BtnParar.Name = "BtnParar";
			this.BtnParar.Size = new System.Drawing.Size(92, 62);
			this.BtnParar.TabIndex = 7;
			this.BtnParar.Text = "Parar";
			this.BtnParar.UseVisualStyleBackColor = true;
			// 
			// LblAquecida
			// 
			this.LblAquecida.BackColor = System.Drawing.Color.Black;
			this.LblAquecida.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
			this.LblAquecida.ForeColor = System.Drawing.Color.Red;
			this.LblAquecida.Location = new System.Drawing.Point(12, 9);
			this.LblAquecida.Name = "LblAquecida";
			this.LblAquecida.Size = new System.Drawing.Size(480, 420);
			this.LblAquecida.TabIndex = 8;
			this.LblAquecida.Text = "aquecida";
			this.LblAquecida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TxConsole
			// 
			this.TxConsole.BackColor = System.Drawing.SystemColors.Menu;
			this.TxConsole.Enabled = false;
			this.TxConsole.ForeColor = System.Drawing.Color.Red;
			this.TxConsole.Location = new System.Drawing.Point(498, 36);
			this.TxConsole.Multiline = true;
			this.TxConsole.Name = "TxConsole";
			this.TxConsole.Size = new System.Drawing.Size(268, 129);
			this.TxConsole.TabIndex = 9;
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 441);
			this.Controls.Add(this.TxConsole);
			this.Controls.Add(this.LblAquecida);
			this.Controls.Add(this.BtnParar);
			this.Controls.Add(this.BtnAquecRapido);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxPotencia);
			this.Controls.Add(this.TxTempo);
			this.Controls.Add(this.BtnAquecer);
			this.Controls.Add(this.TxEntrada);
			this.Name = "Principal";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxEntrada;
		private System.Windows.Forms.Button BtnAquecer;
		private System.Windows.Forms.TextBox TxTempo;
		private System.Windows.Forms.TextBox TxPotencia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BtnAquecRapido;
		private System.Windows.Forms.Button BtnParar;
		private System.Windows.Forms.Label LblAquecida;
		private System.Windows.Forms.TextBox TxConsole;
	}
}

