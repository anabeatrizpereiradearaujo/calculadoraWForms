namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textResultado = new TextBox();
            btnVirgula = new Button();
            btnZero = new Button();
            btnAdicao = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnSubtracao = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnMultiplicacao = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnDivisao = new Button();
            btnIgual = new Button();
            btnApagar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textResultado
            // 
            textResultado.BackColor = SystemColors.MenuBar;
            textResultado.Location = new Point(12, 18);
            textResultado.Name = "textResultado";
            textResultado.ReadOnly = true;
            textResultado.Size = new Size(178, 23);
            textResultado.TabIndex = 0;
            textResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(104, 226);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(40, 35);
            btnVirgula.TabIndex = 2;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(12, 226);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(40, 35);
            btnZero.TabIndex = 3;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.BackColor = Color.HotPink;
            btnAdicao.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 255);
            btnAdicao.FlatAppearance.BorderSize = 0;
            btnAdicao.Font = new Font("Segoe UI", 13F);
            btnAdicao.Location = new Point(150, 181);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(40, 80);
            btnAdicao.TabIndex = 4;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = false;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(58, 226);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(40, 35);
            btnUm.TabIndex = 5;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(12, 181);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(40, 35);
            btnDois.TabIndex = 6;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(58, 181);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(40, 35);
            btnTres.TabIndex = 7;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.HotPink;
            btnSubtracao.Font = new Font("Segoe UI", 13F);
            btnSubtracao.Location = new Point(150, 140);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(40, 35);
            btnSubtracao.TabIndex = 8;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(104, 181);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(40, 35);
            btnQuatro.TabIndex = 9;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(12, 140);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(40, 35);
            btnCinco.TabIndex = 10;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(58, 140);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(40, 35);
            btnSeis.TabIndex = 11;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.HotPink;
            btnMultiplicacao.Font = new Font("Segoe UI", 13F);
            btnMultiplicacao.ForeColor = Color.DimGray;
            btnMultiplicacao.Location = new Point(104, 99);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(40, 35);
            btnMultiplicacao.TabIndex = 12;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(104, 140);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(40, 35);
            btnSete.TabIndex = 13;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(12, 99);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(40, 35);
            btnOito.TabIndex = 14;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(58, 99);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(40, 35);
            btnNove.TabIndex = 15;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.HotPink;
            btnDivisao.Font = new Font("Segoe UI", 13F);
            btnDivisao.Location = new Point(150, 99);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(40, 35);
            btnDivisao.TabIndex = 16;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.FromArgb(255, 128, 255);
            btnIgual.FlatAppearance.BorderColor = Color.Black;
            btnIgual.Font = new Font("Segoe UI", 11F);
            btnIgual.ForeColor = Color.DimGray;
            btnIgual.Location = new Point(12, 58);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(86, 35);
            btnIgual.TabIndex = 17;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.FromArgb(255, 128, 255);
            btnApagar.Font = new Font("Segoe UI", 11F);
            btnApagar.Location = new Point(104, 58);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(86, 35);
            btnApagar.TabIndex = 20;
            btnApagar.Text = "c";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(18, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(204, 274);
            Controls.Add(label1);
            Controls.Add(btnApagar);
            Controls.Add(btnIgual);
            Controls.Add(btnDivisao);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnSubtracao);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnAdicao);
            Controls.Add(btnZero);
            Controls.Add(btnVirgula);
            Controls.Add(textResultado);
            ForeColor = Color.DimGray;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textResultado;
        private Button btnVirgula;
        private Button btnZero;
        private Button btnAdicao;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnSubtracao;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnMultiplicacao;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnDivisao;
        private Button btnIgual;
        private Button btnApagar;
        private Label label1;
    }
}
