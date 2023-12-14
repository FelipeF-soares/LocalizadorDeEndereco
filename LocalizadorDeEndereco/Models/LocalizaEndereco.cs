using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaCep;

namespace LocalizadorDeEndereco.Models;

public class LocalizaEndereco
{
    public Endereco PorCep (string cep)
    {
        Endereco endereco = new Endereco();
        ViaCepResult resultadoBusca = new ViaCepClient().Search(cep);
        endereco.Cep = resultadoBusca.ZipCode;
        endereco.Logradouro = resultadoBusca.Street;
        endereco.Complemento = resultadoBusca.Complement;
        endereco.Bairro = resultadoBusca.Neighborhood;
        endereco.Localidade = resultadoBusca.City;
        endereco.Uf = resultadoBusca.StateInitials;
        endereco.Ibge = resultadoBusca.IBGECode.ToString();
        endereco.Gia = resultadoBusca.GIACode.ToString();
        endereco.Ddd = resultadoBusca.Unit;

        return endereco;
    }

}
