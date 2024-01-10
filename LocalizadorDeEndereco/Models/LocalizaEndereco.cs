using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaCep;

namespace LocalizadorDeEndereco.Models;

public class LocalizaEndereco
{ 
    public DataTable PorCep (string cep)
    {
        DataTable dataTable = new DataTable();
        ViaCepResult resultadoBusca = new ViaCepClient().Search(cep);
        if(resultadoBusca == null )
        {
            return dataTable;
        }
        foreach(var propriedade in typeof(ViaCepResult).GetProperties())
        {
            Type propType = propriedade.PropertyType;

            if (propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                propType = Nullable.GetUnderlyingType(propType);
            }
            dataTable.Columns.Add(propriedade.Name, propType);
        }

        DataRow row = dataTable.NewRow();

        foreach(var propriedade in typeof (ViaCepResult).GetProperties()) 
        {
            
            row[propriedade.Name] = propriedade.GetValue(resultadoBusca);
        }
        
        dataTable.Rows.Add(row);
        return dataTable;
    }
    

    public DataTable PorNomeCidadeEstado(string logradouro, string cidade, string estado)
    {
        
        DataTable dataTable = new DataTable();
        var result = new ViaCepClient().Search(estado, cidade, logradouro);
        
        foreach ( var propriedade in result.First().GetType().GetProperties()) 
        {
            Type propType = propriedade.PropertyType;

            if(propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {

                propType = Nullable.GetUnderlyingType(propType);
            }

            dataTable.Columns.Add(propriedade.Name, propType);
        }

        foreach(var endereco in result)
        {
            DataRow row = dataTable.NewRow();

            foreach(var propriedade in endereco.GetType().GetProperties())
            {
                object propValue = propriedade.GetValue(endereco);
                if(propValue == null) propValue = DBNull.Value;

                row[propriedade.Name] = propriedade.GetValue(endereco);
            }
            dataTable.Rows.Add(row);
        }
       
       return dataTable;
    }

}
