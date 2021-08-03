using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoas.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Necessário")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "{0} tamanho mínimo de 6 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} Necessário")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DtNascimento { get; set; }

        [Required(ErrorMessage ="{0} Deve ser preenchido com M para masculino ou F para feminino")]
        [StringLength(1)]
        public string Sexo { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(int id, string nome, DateTime dtNascimento, string sexo)
        {
            Id = id;
            Nome = nome;
            DtNascimento = dtNascimento;
            Sexo = sexo;
        } 
    }    
}
