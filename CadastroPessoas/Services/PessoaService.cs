using CadastroPessoas.Context;
using CadastroPessoas.Models;
using CadastroPessoas.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
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

        public void Inserir(Pessoa obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Pessoa FindById(int id)
        {
            return _context.Pessoas.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remover(int id)
        {
            var obj = _context.Pessoas.Find(id);
            _context.Pessoas.Remove(obj);
            _context.SaveChanges();
        }

        public void Atualizar(Pessoa obj)
        {
            if (!_context.Pessoas.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id não encontrado"); 
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

    }
}
