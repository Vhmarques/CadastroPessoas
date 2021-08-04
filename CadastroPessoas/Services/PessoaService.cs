using CadastroPessoas.Context;
using CadastroPessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoas.Services
{
    public class PessoaService
    {
        private readonly CadastroPessoasContext _context;

        public PessoaService(CadastroPessoasContext context)
        {
            _context = context;        
        }

        public List<Pessoa> FindAll()
        {
            return _context.Pessoas.ToList();        
        }

        public void Insert(Pessoa obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
