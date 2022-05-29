using Projeto_Adote_Pet.Models;
using System.Collections.Generic;

namespace Projeto_Adote_Pet.Repositorio
{
    public interface ICadastroRepositorio
    {
        CadastroModel ListarIdanimal(int idanimal);

        //lista o cadastro
        List<CadastroModel> BuscarTodos();

        CadastroModel Adicionar(CadastroModel cadastro);

        CadastroModel Atualizar(CadastroModel cadastro);
    }
}
