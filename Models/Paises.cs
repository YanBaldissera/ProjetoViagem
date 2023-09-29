using System.ComponentModel.DataAnnotations;

namespace API_Viagem.Models;

public class Paises
{
    private string _NomePais;
    private string _Continente;
    private string _EstacaoAno;

    [Key]
    public string NomePais
    {
        get => _NomePais;
        set => _NomePais = value;
    }

    public string Continente
    {
        get => _Continente;
        set => _Continente = value;
    }

    public string EstacaoAno
    {
        get => _EstacaoAno;
        set => _EstacaoAno = value;
    }


    public Paises()
    {
        _Continente = string.Empty;
        _EstacaoAno = string.Empty;
        _NomePais = string.Empty;
    }

    public Paises(string Continente, string EstacaoAno, string NomePais)
    {
        _Continente = Continente;
        _EstacaoAno = EstacaoAno;
        _NomePais = NomePais;
    }
}