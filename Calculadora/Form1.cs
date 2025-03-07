namespace Calculadora
{
    public partial class Form1 : Form
    {
        private decimal Resultado { get; set; }
        private decimal Valor { get; set; }
        private Operacao OperacaoSelecionada {  get; set; }
        private enum Operacao {


            Multiplicacao,
            Divisao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }
        private void btnDois_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }
        private void btnTres_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }
        private void btnCinco_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }
        private void btnSeis_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }
        private void btnSete_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }
        private void btnOito_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if(!textResultado.Text.Contains(","))
            textResultado.Text = ",";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {

        }



        private void btnSubtracao_Click(object sender, EventArgs e)
        {

        }




        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            lblOperacao.Text = "/";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            lblOperacao.Text = "*";
        }



        private void btnApagar_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Divisao:
                    if (textResultado.Text == "0")
                    {
                        
                        textResultado.Text = "Não é possível dividir por zero";
                        
                        return;                  
                    }               

                        Resultado = Valor / Convert.ToDecimal(textResultado.Text);

                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(textResultado.Text);
                    break;
            }         
            textResultado.Text = Convert.ToString(Resultado);
           
            lblOperacao.Text = "=";
           
        }

    }
}
