using System;
using System.ComponentModel.DataAnnotations;

namespace API_Cadastro.Data.Dtos.Pessoa
{
    public class ReadPessoaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
        
       




    }
}
