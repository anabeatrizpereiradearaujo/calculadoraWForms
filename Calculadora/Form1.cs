namespace Calculadora
{
    public partial class Form1 : Form
    {
        private object textResultado;

        private decimal Resultado { get; set; }
        private decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnAdicao_Click(object sender, EventArgs e)
        {





            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            lblOperacao.Text = "+";
        }


        private void btnSubtracao_Click(object sender, EventArgs e)
        {

            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            lblOperacao.Text = "-";



        }
        private void btnIgual_Click(object sender, EventArgs e)
        {

            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(textResultado.Text);
                    break;

                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(textResultado.Text);
                    break;




            }

        }




    }

}

