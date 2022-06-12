using adotemvc.Models;
using System.Collections.Generic;

namespace adotemvc.Repositorio
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
