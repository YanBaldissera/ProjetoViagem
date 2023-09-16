
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace API_Viagem.Models;
public class Cliente
{
    
    private string _Cpf;
    private string _Nome;
    private string _Sobrenome;
    private string _DataDeNascimento;
    private string _Email;
    private string _Senha;

    [Key]
    public string Cpf 
    {
        get => _Cpf;
        set => _Cpf = value;
    }

    public string Nome  
    {
        get => _Nome;
        set => _Nome = value;
    }

    public string Sobrenome 
    {
        get => _Sobrenome;
        set => _Sobrenome = value;
    }

    public string DataDeNascimento  
    {
        get => _DataDeNascimento;
        set => _DataDeNascimento = value;
    }

    public string Email  
    {
        get => _Email;
        set => _Email = value;
    }

    public string Senha 
    {
        get => _Senha;
        set => _Senha = value;
    }

    public Cliente()
    {
        _Cpf = string.Empty;
        _Nome = string.Empty;
        _Sobrenome = string.Empty;
        _DataDeNascimento = string.Empty;
        _Email = string.Empty;
        _Senha = string.Empty;
    }

    public Cliente(string cpf, string nome, string sobrenome, string data, string email, string senha)
    {
        _Cpf = cpf;
        _Nome = nome;
        _Sobrenome = sobrenome;
        _DataDeNascimento = data;
        _Email = email;
        _Senha = senha;
    }
}