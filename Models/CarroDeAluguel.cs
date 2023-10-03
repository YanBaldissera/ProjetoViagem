using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;


namespace API_Viagem.Models;

    public class CarroAluguel
    {
        [Key]
        public string Placa { get; set; } // Definindo a placa como chave primária

        [Required]
        public string Modelo { get; set; }

        [Required]
        public string Marca { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal ValorDiaria { get; set; }

        public string Disponivel { get; set; } 
    }
