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
        public string Especie { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Sexo { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Raça")]
        public string Raca { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Idade { get; set; }

        [Required(ErrorMessage = "Escolha uma opção")]
        public string Porte { get; set; }
        public string Nome { get; set; }

        public string Cor { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Escolha uma opção")]
        public string Estado { get; set; }
        
        [Display(Name = "Descrição (Opcional")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Escolha uma opção")]
        [Display(Name = "Status")]
        public string Pstatus { get; set; }

        //public int UsuarioCpf { get; set; }
        
        //[ForeignKey("UsuarioCpf")]
        //public Usuario Usuario { get; set; }
        
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
    }
}
