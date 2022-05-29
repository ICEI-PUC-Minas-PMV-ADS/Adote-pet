using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Adote_Pet.Models
{
    [Table("Pet")]
    public class CadastroModel
    {
        [Key]
        public int Idanimal { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Sexo { get; set; }
        public string Raca { get; set; }
        public string Idade { get; set; }
        public string Porte { get; set; }
        public string Cor { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Descricao { get; set; }
        public string Pstatus { get; set; }
        public string Cpf { get; set; }






    }
}
