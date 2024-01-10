using LocalizadorDeEndereco.Models;
using System.Data;
using System.Runtime.ConstrainedExecution;

namespace LocalizadorDeEndereco;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        buttonPesquisar.Enabled = false;
        buttonPesquisaCEP.Enabled = false;
        textBoxLogradouro.TextChanged += TextBox_TextChanged;
        textBoxCidade.TextChanged += TextBox_TextChanged;
        comboBoxUF.TextChanged += TextBox_TextChanged;
    }

    private void TextBox_TextChanged(object sender, EventArgs e)
    {
        buttonPesquisar.Enabled = !string.IsNullOrEmpty(textBoxLogradouro.Text) &&
                                  !string.IsNullOrEmpty(textBoxCidade.Text) &&
                                  !string.IsNullOrEmpty(comboBoxUF.Text);
    }

    private void buttonPesquisar_Click(object sender, EventArgs e)
    {
        string logradouro = textBoxLogradouro.Text;
        string cidade = textBoxCidade.Text;
        string uf = comboBoxUF.Text;
        try
        {

            LocalizaEndereco localizaEndereco = new LocalizaEndereco();
            dataGridViewresultado.DataSource = localizaEndereco.PorNomeCidadeEstado(logradouro, cidade, uf);

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonPesquisaCEP_Click(object sender, EventArgs e)
    {
        string cep = maskedTextBoxCEP.Text;
        try
        {
            LocalizaEndereco localizaEndereco = new LocalizaEndereco();
            dataGridViewresultado.DataSource = localizaEndereco.PorCep(cep);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    private void maskedTextBoxCEP_TextChanged(object sender, EventArgs e)
    {
        buttonPesquisaCEP.Enabled = true;
    }
}