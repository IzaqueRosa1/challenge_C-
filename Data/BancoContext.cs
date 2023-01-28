using DesafioEstagio.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioEstagio.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { 
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
