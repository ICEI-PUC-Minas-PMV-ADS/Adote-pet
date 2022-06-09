using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static Projeto_Adote_Pet.Models.PetModel;
using Azure.Search.Documents.Indexes;
using Azure.Search.Documents.Indexes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_Adote_Pet.Models;


namespace Projeto_Adote_Pet.Models
{
    public class Ppets    
    {
        [Key]
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
