using System.ComponentModel.DataAnnotations;

namespace API_Viagem.Models;

public class Passagem
{
    private int _NVoo;
    private string _NomePassageiro;
    private string _DataEmbarque;
    private string _Destino;
    private string _LocalEmbarque;
    private string _Classe;
    private int _NConexoes;
    private string _Assento;

    [Key]
    public int NVoo
    {
        get => _NVoo;
        set => _NVoo = value;
    }

    public string NomePassageiro
    {
        get => _NomePassageiro;
        set => _NomePassageiro = value;
    }

    public string DataEmbarque
    {
        get => _DataEmbarque;
        set => _DataEmbarque = value;
    }

    public string Destino
    {
        get => _Destino;
        set => _Destino = value;
    }

    public string LocalEmbarque
    {
        get => _LocalEmbarque;
        set => _LocalEmbarque = value;
    }

    public string Classe
    {
        get => _Classe;
        set => _Classe = value;
    }

    public int NConexoes
    {
        get => _NConexoes;
        set => _NConexoes = value;
    }

    public string Assento
    {
        get => _Assento;
        set => _Assento = value;
    }

    public Passagem()
    {
        _Assento = string.Empty;
        _Classe = string.Empty;
        _DataEmbarque = string.Empty;
        _Destino = string.Empty;
        _NVoo = 0;
        _LocalEmbarque = string.Empty;
        _NConexoes = 0;
        _NomePassageiro = string.Empty;
    }

    public Passagem(string Assento, string Classe, string DataEmbarque, string Destino, int NVoo, string LocalEmbarque, int NConexoes, string NomePassageiro)
    {
        _Assento = Assento;
        _Classe = Classe;
        _DataEmbarque = DataEmbarque;
        _Destino = Destino;
        _NVoo = NVoo;
        _LocalEmbarque = LocalEmbarque;
        _NConexoes = NConexoes;
        _NomePassageiro = NomePassageiro;
    }
}