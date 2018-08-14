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
			this.LblPotencia = new System.Windows.Forms.Label();
			this.BtnEnviar = new System.Windows.Forms.Button();
			this.BtnResetarConsole = new System.Windows.Forms.Button();
			this.TxConsole = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// TxEntrada
			// 
			this.TxEntrada.Location = new System.Drawing.Point(670, 16);
			this.TxEntrada.Name = "TxEntrada";
			this.TxEntrada.Size = new System.Drawing.Size(268, 20);
			this.TxEntrada.TabIndex = 0;
			// 
			// BtnAquecer
			// 
			this.BtnAquecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.BtnAquecer.Location = new System.Drawing.Point(670, 435);
			this.BtnAquecer.Name = "BtnAquecer";
			this.BtnAquecer.Size = new System.Drawing.Size(170, 62);
			this.BtnAquecer.TabIndex = 1;
			this.BtnAquecer.Text = "Aquecer";
			this.BtnAquecer.UseVisualStyleBackColor = true;
			this.BtnAquecer.Click += new System.EventHandler(this.BtnAquecerClick);
			// 
			// TxTempo
			// 
			this.TxTempo.Location = new System.Drawing.Point(799, 325);
			this.TxTempo.Name = "TxTempo";
			this.TxTempo.Size = new System.Drawing.Size(137, 20);
			this.TxTempo.TabIndex = 2;
			// 
			// TxPotencia
			// 
			this.TxPotencia.Location = new System.Drawing.Point(799, 299);
			this.TxPotencia.Name = "TxPotencia";
			this.TxPotencia.Size = new System.Drawing.Size(137, 20);
			this.TxPotencia.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(660, 325);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Tempo de Cozimento:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(660, 299);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Potência:";
			// 
			// BtnAquecRapido
			// 
			this.BtnAquecRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.BtnAquecRapido.Location = new System.Drawing.Point(670, 367);
			this.BtnAquecRapido.Name = "BtnAquecRapido";
			this.BtnAquecRapido.Size = new System.Drawing.Size(268, 62);
			this.BtnAquecRapido.TabIndex = 6;
			this.BtnAquecRapido.Text = "Aquecimento Rápido";
			this.BtnAquecRapido.UseVisualStyleBackColor = true;
			this.BtnAquecRapido.Click += new System.EventHandler(this.BtnAquecerRapidoClick);
			// 
			// BtnParar
			// 
			this.BtnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.BtnParar.Location = new System.Drawing.Point(846, 435);
			this.BtnParar.Name = "BtnParar";
			this.BtnParar.Size = new System.Drawing.Size(92, 62);
			this.BtnParar.TabIndex = 7;
			this.BtnParar.Text = "Parar";
			this.BtnParar.UseVisualStyleBackColor = true;
			this.BtnParar.Click += new System.EventHandler(this.BtnPararClick);
			// 
			// LblPotencia
			// 
			this.LblPotencia.AutoSize = true;
			this.LblPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblPotencia.ForeColor = System.Drawing.Color.DarkRed;
			this.LblPotencia.Location = new System.Drawing.Point(24, 28);
			this.LblPotencia.Name = "LblPotencia";
			this.LblPotencia.Size = new System.Drawing.Size(0, 25);
			this.LblPotencia.TabIndex = 10;
			// 
			// BtnEnviar
			// 
			this.BtnEnviar.Location = new System.Drawing.Point(765, 43);
			this.BtnEnviar.Name = "BtnEnviar";
			this.BtnEnviar.Size = new System.Drawing.Size(75, 23);
			this.BtnEnviar.TabIndex = 11;
			this.BtnEnviar.Text = "Enviar";
			this.BtnEnviar.UseVisualStyleBackColor = true;
			this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviarClick);
			// 
			// BtnResetarConsole
			// 
			this.BtnResetarConsole.Location = new System.Drawing.Point(908, 43);
			this.BtnResetarConsole.Name = "BtnResetarConsole";
			this.BtnResetarConsole.Size = new System.Drawing.Size(27, 23);
			this.BtnResetarConsole.TabIndex = 12;
			this.BtnResetarConsole.Text = "X";
			this.BtnResetarConsole.UseVisualStyleBackColor = true;
			this.BtnResetarConsole.Click += new System.EventHandler(this.BtnResetarConsoleClick);
			// 
			// TxConsole
			// 
			this.TxConsole.BackColor = System.Drawing.Color.Black;
			this.TxConsole.ForeColor = System.Drawing.SystemColors.WindowText;
			this.TxConsole.Location = new System.Drawing.Point(13, 16);
			this.TxConsole.Multiline = true;
			this.TxConsole.Name = "TxConsole";
			this.TxConsole.ReadOnly = true;
			this.TxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TxConsole.Size = new System.Drawing.Size(641, 483);
			this.TxConsole.TabIndex = 13;
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(954, 508);
			this.Controls.Add(this.TxConsole);
			this.Controls.Add(this.BtnResetarConsole);
			this.Controls.Add(this.BtnEnviar);
			this.Controls.Add(this.LblPotencia);
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
		private System.Windows.Forms.Label LblPotencia;
		private System.Windows.Forms.Button BtnEnviar;
		private System.Windows.Forms.Button BtnResetarConsole;
		private System.Windows.Forms.TextBox TxConsole;
	}
}

