using System.ComponentModel.DataAnnotations;

namespace API_Cadastro.Models
{
    public class Pessoa
    {
        [Key]
        
        public int Id { get; set; }
        
        public string Cpf { get; set; }
        
        public string Nome { get; set; }
        
        public string Email { get; set; }
        
        public string Telefone { get; set; }
    }
}
