using LocalizadorDeEndereco.Models;

namespace LocalizadorDeEndereco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                LocalizaEndereco buscar = new LocalizaEndereco();
                string cep = maskedTextBoxCep.Text;
                var endereco = buscar.PorCep(cep);
                richTextBoxResultado.Text = endereco.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cep Inválido");
            }




        }
    }
}