using System.ComponentModel.DataAnnotations;

namespace adotemvc.Models
{
    public class CadastroModel
    {
        [Key]
        public int Idanimal { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Sexo { get; set; }
        public string Raça { get; set; }
        public string Idade { get; set; }
        public string Porte { get; set; }
        public string Cor { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Descrição { get; set; }
        public string Pstatus { get; set; }






    }
}
