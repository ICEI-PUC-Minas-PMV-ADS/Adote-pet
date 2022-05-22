using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Adote_Pet.Models
{
    [Table("Usuarios")]//tabela de usuário 
    public class Usuario
    {
        [Key]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        
        [DataType(DataType.Password)] // Configuração para a senha do usuário não aparecer 
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]

        [DataType(DataType.Password)] // Configuração para a senha do usuário não aparecer 
        public string ConfirmeSenha { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Física,
        Jurídica

    }

}
