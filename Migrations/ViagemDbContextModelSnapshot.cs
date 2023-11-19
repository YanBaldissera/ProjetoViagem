﻿// <auto-generated />
using API_Viagem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmpresaDeViagem.Migrations
{
    [DbContext(typeof(ViagemDbContext))]
    partial class ViagemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("API_Viagem.Models.CarroAluguel", b =>
                {
                    b.Property<string>("Placa")
                        .HasColumnType("TEXT");

                    b.Property<string>("Disponivel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorDiaria")
                        .HasColumnType("TEXT");

                    b.HasKey("Placa");

                    b.ToTable("CarrosAluguel");
                });

            modelBuilder.Entity("API_Viagem.Models.Cidades", b =>
                {
                    b.Property<string>("Cidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Continente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NHabitantes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PTuristico")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("País")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Cidade");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("API_Viagem.Models.Cliente", b =>
                {
                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataDeNascimento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Cpf");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("API_Viagem.Models.Companhia", b =>
                {
                    b.Property<string>("CNPJ")
                        .HasColumnType("TEXT");

                    b.Property<string>("Aviões")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Destinos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pacotes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Seguros")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CNPJ");

                    b.ToTable("Companhia");
                });

            modelBuilder.Entity("API_Viagem.Models.GuiaTuristico", b =>
                {
                    b.Property<int>("DocumentoGuia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Empresa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Nota")
                        .HasColumnType("REAL");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT");

                    b.HasKey("DocumentoGuia");

                    b.ToTable("GuiaTuristico");
                });

            modelBuilder.Entity("API_Viagem.Models.Hospedagem", b =>
                {
                    b.Property<string>("Cnpj")
                        .HasColumnType("TEXT");

                    b.Property<string>("Alimentacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Estrelas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("ValorDiaria")
                        .HasColumnType("REAL");

                    b.HasKey("Cnpj");

                    b.ToTable("Hospedagem");
                });

            modelBuilder.Entity("API_Viagem.Models.Paises", b =>
                {
                    b.Property<string>("NomePais")
                        .HasColumnType("TEXT");

                    b.Property<string>("Continente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EstacaoAno")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NomePais");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("API_Viagem.Models.Passagem", b =>
                {
                    b.Property<int>("NVoo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Assento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Classe")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DataEmbarque")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LocalEmbarque")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NConexoes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomePassageiro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NVoo");

                    b.ToTable("Passagem");
                });
#pragma warning restore 612, 618
        }
    }
}
