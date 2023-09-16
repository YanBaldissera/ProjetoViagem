using System.ComponentModel.DataAnnotations;

namespace API_Viagem.Models;

public class Hospedagem 
{
    
    private string _Cnpj;

    private string _Nome;

    private string _Alimentacao;

    private float _ValorDiaria;

    private int _Estrelas;

    [Key]
    public string Cnpj
    {
        get => _Cnpj;
        set => _Cnpj = value;
    }

    public string Nome
    {
        get => _Nome;
        set  => _Nome = value;
    }

    public string Alimentacao 
    {
        get => _Alimentacao;
        set => _Alimentacao = value;
    }

    public float ValorDiaria
    {
        get => _ValorDiaria;
        set => _ValorDiaria = value;
    }

    public int Estrelas 
    {
        get => _Estrelas;
        set=> _Estrelas=value;
    }

    public Hospedagem()
    {
        _Cnpj = string.Empty;

        _Nome = string.Empty;

        _Alimentacao = string.Empty;

        _ValorDiaria = 0.0f;

        _Estrelas = 0;

    }

    public Hospedagem(string cnpj, string nome, string alimentacao, float valor, int estrela)
    {
        _Cnpj = cnpj;
        _Nome = nome;
        _Alimentacao = alimentacao;
        _ValorDiaria = valor;
        _Estrelas = estrela;
    }


}