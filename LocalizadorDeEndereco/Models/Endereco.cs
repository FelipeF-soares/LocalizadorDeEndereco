﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizadorDeEndereco.Models;

public class Endereco
{
    public string Cep {  get; set; }
    public string Logradouro { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public string Localidade { get; set; }
    public string Uf { get; set; }
    public string Ibge { get; set; }
    public string Gia { get; set; }
    public string Ddd { get; set; }
    public string Siafi { get; set; }

    public override string ToString()
    {
        return $"\ncep: {Cep} \nlogradouro: {Logradouro} \ncomplemento: {Complemento}\nbairro: {Bairro}\ncidade: {Localidade}\nUF: {Uf}";
    }
}
