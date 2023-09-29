using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace API_Viagem.Models;
public class Companhia
{
    
    private string _Nome;
    private string _CNPJ;
    private string _Aviões;
    private string _Destinos;
    private string _Pacotes;
    private string _Hospedagens;
    private string _Seguros;
    private string _Carro;

    
    public string Nome 
    {
        get => _Nome;
        set => _Nome = value;
    }

    [Key]
    public string CNPJ  
    {
        get => _CNPJ;
        set => _CNPJ = value;
    }

    public string Aviões 
    {
        get => _Aviões;
        set => _Aviões = value;
    }

    public string Destinos  
    {
        get => _Destinos;
        set => _Destinos = value;
    }

    public string Pacotes  
    {
        get => _Pacotes;
        set => _Pacotes = value;
    }

    public string Hospedagens  
    {
        get => _Hospedagens;
        set => _Hospedagens = value;
    }

     public string Seguros  
    {
        get => _Seguros;
        set => _Seguros = value;
    }

     public string Carro  
    {
        get => _Carro;
        set => _Carro = value;
    }
    public Companhia()
    {
        _Nome = string.Empty;
        _CNPJ = string.Empty;
        _Aviões = string.Empty;
        _Destinos = string.Empty;
        _Pacotes = string.Empty;
        _Hospedagens = string.Empty;
        _Seguros = string.Empty;
        _Carro = string.Empty;
    }

    public Conpanhia(string nome, string cnpj, string avioes, string destinos, string pacotes, string hospedagens, string seguros, string carro)
    {
        _Nome = nome;
        _CNPJ = cnpj;
        _Aviões = avioes;
        _Destinos = destinos;
        _Pacotes = pacotes;
        _Hospedagens = hospedagens;
        _Seguros = seguros;
        _Carro = carro;
    }
}