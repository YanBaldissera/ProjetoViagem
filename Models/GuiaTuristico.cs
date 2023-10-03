using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Viagem.Models
{
    public class GuiaTuristico
    {
        [Key]
        public int DocumentoGuia { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Empresa { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Valor { get; set; }

        [Range(0, 10)]
        public double Nota { get; set; }

        [Required]
        public string Pais {get; set;}

        [Required]

        public string Status {get; set;}

    }
}