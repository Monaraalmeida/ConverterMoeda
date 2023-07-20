using APImoeda.Models;
using Microsoft.EntityFrameworkCore;

namespace ConvertendoMoeda.Data
{

    //O DBContext permite configurar as tabelas e as configurações gerais de um banco de dados.
    public class SistemaTarefasDBContext : DbContext
    {

        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> opts) 
            : base(opts) 
        {
        
        }

        public DbSet<MoedasModel> Moedas { get; set; }

    }
}
