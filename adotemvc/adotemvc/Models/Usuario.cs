using System.ComponentModel.DataAnnotations;

namespace adotemvc.Models
{
    public class Usuario
    {
        [Key] //chave primária
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Campo de preenchimento obrigatório")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public string Cidade { get; set; }
        
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public string Estado { get; set; }
        public double telefone { get; set; }
        
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public double senha { get; set; }
        
    }
}
