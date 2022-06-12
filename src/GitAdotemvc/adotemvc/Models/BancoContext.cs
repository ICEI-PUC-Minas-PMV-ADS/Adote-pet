using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adotemvc.Models
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)

        {
        }
        public DbSet<CadastroModel> Cadastros { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

    }
}
