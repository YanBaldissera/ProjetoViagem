namespace API_Viagem.Data;
using API_Viagem.Models;
using Microsoft.EntityFrameworkCore;


public class ViagemDbContext: DbContext
{
    public DbSet<Cliente> Cliente {get;set;}
    public DbSet<Hospedagem> Hospedagem {get;set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(connectionString: "DataSource=Viagem.db;Cache=Shared");
    }
}