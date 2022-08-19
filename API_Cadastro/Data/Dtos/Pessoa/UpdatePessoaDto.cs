using System.ComponentModel.DataAnnotations;

namespace API_Cadastro.Data.Dtos.Pessoa
{
    public class UpdatePessoaDto
    {
        
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
