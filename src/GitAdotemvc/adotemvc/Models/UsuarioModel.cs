using adotemvc.Enum;
using System;

namespace adotemvc.Models
{
    public class UsuarioModel
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        //Enumerador está na pasta Enum
        public PerfilEnum Perfil { get; set; }
        
        //? campo pode ser nulo
        public DateTime? DataAtualizacao { get; set; }

    }
}
