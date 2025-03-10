namespace LoginRetirement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string hardcodedEmail = "rm550702@fiap.com.br";
            string hardcodedSenha = "rm550702";

            if (textBoxEmail.Text == hardcodedEmail && textBoxSenha.Text == hardcodedSenha)
            {
                Aposentadoria Aposentadoria = new Aposentadoria();
                Aposentadoria.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("E-mail ou senha inválidos.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


