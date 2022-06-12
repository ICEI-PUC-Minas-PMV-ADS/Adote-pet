using adotemvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace adotemvc.Repositorio
{
    public class CadastroRepositorio : ICadastroRepositorio
    {
        //chama o banco
        private readonly BancoContext _bancoContext;
        
        //BancoContext é do banco de dados em Models
        public CadastroRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        //Tem relação com a busca de idanimal para Editar
        public CadastroModel ListarIdanimal(int idanimal)
        {
            return _bancoContext.Cadastros.FirstOrDefault(x => x.Idanimal == idanimal);
        }

        public List<CadastroModel> BuscarTodos()
        {
            return _bancoContext.Cadastros.ToList();
        }
        public CadastroModel Adicionar(CadastroModel cadastro)
        {
            _bancoContext.Cadastros.Add(cadastro);
            _bancoContext.SaveChanges();
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
            
            _bancoContext.Cadastros.Update(cadastroDB);
            _bancoContext.SaveChanges();
            
            return cadastroDB;

        }
    }
}
