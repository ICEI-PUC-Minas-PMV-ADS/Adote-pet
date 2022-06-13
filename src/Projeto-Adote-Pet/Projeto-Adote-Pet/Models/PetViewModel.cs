using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Adote_Pet.Models
{
    [Table("Pets")] //Nome da tabela
    public class PetModel
    {
        [Key]
        public int Idanimal { get; set; }

        [Required(ErrorMessage = "Escolha uma opção")]
        [Display(Name = "Espécie")]
        public EspecieEnum Especie { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public SexoEnum Sexo { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Raça")]
        public string Raca { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Idade { get; set; }

        [Required(ErrorMessage = "Escolha uma opção")]
        public PorteEnum Porte { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Escolha uma opção")]
        public EstadoEnum Estado { get; set; }
        
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Escolha uma opção")]
        [Display(Name = "Status")]
        public PstatusEnum Pstatus { get; set; }

        public string ImagePet { get; set; }

        //Foreignkey
        
        [ForeignKey("UsuarioCpf")]
        public string UsuarioCpf { get; set; }
        public Usuario Usuario { get; set; }

        //Enumerações
        public enum EspecieEnum
        {
            Cachorro,
            Gato
        }
        public enum SexoEnum
        {
            Macho,
            Fêmea
        }
        public enum PorteEnum
        {
            Pequeno,
            Médio,
            Grande
        }
        public enum PstatusEnum
        {
            Adotado,
            Disponível
        }

        public enum EstadoEnum
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
        //Fabio
        public class PetViewModel
        {
            public IFormFile ImagemPet { get; set; }
        }
    }
}
