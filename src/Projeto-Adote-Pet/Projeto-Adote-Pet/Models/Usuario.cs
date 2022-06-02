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
        //public int IdUser { get; set; }
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
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Escolha uma opção")]
        public EstadoEnumU Estado { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        
        [DataType(DataType.Password)] // Configuração para a senha do usuário não aparecer 
        public string Senha { get; set; }

        //[Required(ErrorMessage = "Campo Obrigatório!")]

        [DataType(DataType.Password)] // Configuração para a senha do usuário não aparecer 
        public string ConfirmeSenha { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        
        public PerfilEnum Perfil { get; set; }

        //link virtualmente com FK dos Pets

        public PetModel Pet { get; set; }
        //public ICollection<PetModel> Pets { get; set; }
    }

    public enum PerfilEnum
    {
        Física,
        Jurídica
    }
    public enum EstadoEnumU
    {
        AC,
        AL,
        AP,
        AM,
        BA,
        CE,
        DF,
        ES,
        GO,
        MA,
        MT,
        MS,
        MG,
        PA,
        PB,
        PR,
        PE,
        PI,
        RJ,
        RN,
        RS,
        RO,
        RR,
        SC,
        SP,
        SE,
        TO
    }

}
