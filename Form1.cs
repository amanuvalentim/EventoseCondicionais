namespace EventoseCondicionais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnoNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnoNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAnoNascimento.Text.Trim().Length < 4)
                {
                    MessageBox.Show("Digite o ano com 4 números!");
                }
                else
                {
                    txtAnoUltimoAniversario.Focus();
                }
            }


        }

        private void txtAnoUltimoAniversario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(txtAnoUltimoAniversario.Text) <
                    Convert.ToInt32(txtAnoNascimento.Text))
                {
                    MessageBox.Show("Ano inválido!");
                }
                else
                {
                    btnIdentificarCategoria.Focus();
                }
            }
        }

        private void btnIdentificarCategoria_Click(object sender, EventArgs e)
        {
            {
                int idade;

                idade = Convert.ToInt32(txtAnoUltimoAniversario.Text) -
                        Convert.ToInt32(txtAnoNascimento.Text);

                if (txtNome.Text == "")
                {
                    MessageBox.Show("Digite o nome do aluno!");
                }
                else if (idade >= 5 && idade <= 7)
                {
                    lblCategoriaDoAluno.Text = "INFANTIL A";
                }
                else if (idade >= 8 && idade <= 10)
                {
                    lblCategoriaDoAluno.Text = "INFANTIL B";
                }
                else if (idade >= 11 && idade <= 13)
                {
                    lblCategoriaDoAluno.Text = "JUVENIL A";
                }
                else if (idade >= 14 && idade <= 17)
                {
                    lblCategoriaDoAluno.Text = "JUVENIL B";
                }
                else if (idade > 18)
                {
                    lblCategoriaDoAluno.Text = "ADULTO";
                }
                else
                {
                    MessageBox.Show("Idade sem categoria!");
                }
            }
        }
    }
}
