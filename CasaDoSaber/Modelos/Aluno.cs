using System;
using System.ComponentModel.DataAnnotations;
using CasaDoSaber.Dados;

namespace CasaDoSaber.Modelos
{
    public class Aluno
    {        
        public int Matricula { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Nome { get; set; }
        public int Serie { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}
