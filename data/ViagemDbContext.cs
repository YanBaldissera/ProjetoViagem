namespace API_Viagem.Data;
using API_Viagem.Models;
using Microsoft.EntityFrameworkCore;


public class ViagemDbContext: DbContext
{
    public DbSet<Cliente> Cliente {get;set;}
    public DbSet<Hospedagem> Hospedagem {get;set;}
    public DbSet<Cidades> Cidades {get;set;}
    public DbSet<Companhia> Companhia {get;set;}
    public DbSet<Paises> Paises {get;set;}
    public DbSet<Passagem> Passagem {get;set;}
    public DbSet<CarroAluguel> CarrosAluguel { get; set; }

    public DbSet<GuiaTuristico> GuiaTuristico {get;set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(connectionString: "DataSource=Viagem.db;Cache=Shared");
    }
}