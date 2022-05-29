using Projeto_Adote_Pet.Models;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_Adote_Pet.Repositorio
{
    public class CadastroRepositorio : ICadastroRepositorio
    {
        //chama o banco
        private readonly ApplicationDbContext _dbContext;
        
        //BancoContext é do banco de dados em Models
        public CadastroRepositorio(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Tem relação com a busca de idanimal para Editar
        public CadastroModel ListarIdanimal(int idanimal)
        {
            return _dbContext.Cadastros.FirstOrDefault(x => x.Idanimal == idanimal);
        }

        public List<CadastroModel> BuscarTodos()
        {
            return _dbContext.Cadastros.ToList();
        }
        public CadastroModel Adicionar(CadastroModel cadastro)
        {
            _dbContext.Cadastros.Add(cadastro);
            _dbContext.SaveChanges();
            return cadastro;
        }

        //cadastroDB é uma variável aleatória
        public CadastroModel Atualizar(CadastroModel cadastro)
        {
            CadastroModel cadastroDB = ListarIdanimal(cadastro.Idanimal);
            
            //para verificar o que não está vazio

            if (cadastroDB == null) throw new System.Exception("Houve um erro na atualização");
            
            cadastroDB.Nome = cadastro.Nome;
            cadastroDB.Especie = cadastro.Especie;
            cadastroDB.Sexo = cadastro.Sexo;

            _dbContext.Cadastros.Update(cadastroDB);
            _dbContext.SaveChanges();
            
            return cadastroDB;

        }
    }
}
