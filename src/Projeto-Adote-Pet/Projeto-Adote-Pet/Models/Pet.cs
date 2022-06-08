using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static Projeto_Adote_Pet.Models.PetModel;
using System.Text.Json.Serialization;
using Azure.Search.Documents.Indexes;
using Azure.Search.Documents.Indexes.Models;


namespace Projeto_Adote_Pet.Models
{
    public partial class Pet    
    {
        [SimpleField(IsKey = true, IsFilterable = True)]
        public int Idanimal { get; set; }

        public EspecieEnum Especie { get; set; }

        public SexoEnum Sexo { get; set; }
        
        public string Raca { get; set; }

        public string Idade { get; set; }

        public PorteEnum Porte { get; set; }
        
        public string Nome { get; set; }

        public string Cor { get; set; }

        public string Cidade { get; set; }

        public EstadoEnum Estado { get; set; }
        
        public string Descricao { get; set; }

        public PstatusEnum Pstatus { get; set; }

        public string ImagePet { get; set; }

        
       
    }
}
