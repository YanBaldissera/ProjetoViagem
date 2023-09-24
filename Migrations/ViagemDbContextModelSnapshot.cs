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
#pragma warning restore 612, 618
        }
    }
}
