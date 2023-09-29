using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace API_Viagem.Models;
public class Cidades
{
    
    private string _Cidade;
    private string _País;
    private string _NHabitantes;
    private string _Continente;
    private string _PTuristico;

    [Key]
    public int IDCidade 
    {
        get => _IDCidade;
        set => _IDCidade = value;
    }

    public string País  
    {
        get => _País;
        set => _País = value;
    }

    public string NHabitantes 
    {
        get => _NHabitantes;
        set => _NHabitantes = value;
    }

    public string Continente  
    {
        get => _Continente;
        set => _Continente = value;
    }

    public string PTuristico  
    {
        get => _PTuristico;
        set => _PTuristico = value;
    }

    public Cidades()
    {
        _IDCidade = int.Empty;
        _País = string.Empty;
        _NHabitantes = string.Empty;
        _Continente = string.Empty;
        _PTuristico = string.Empty;
    }

    public Cidades(int idCidade, string país, string nhabitantes, string continente, string pturistico)
    {
        _IDCidade = idCidade;
        _País = país;
        _NHabitantes = nhabitantes;
        _Continente = continente;
        _PTuristico = pturistico;
    }
}