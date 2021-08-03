using CadastroPessoas.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroPessoas.Context
{
    public class CadastroPessoasContext : DbContext
    {
        public CadastroPessoasContext(DbContextOptions<CadastroPessoasContext> options) : base(options)
        {}

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
