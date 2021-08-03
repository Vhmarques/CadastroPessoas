using CadastroPessoas.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoas.Controllers
{
    public class PessoasController : Controller
    {
        private readonly PessoaService _pessoaService;

        public PessoasController(PessoaService pessoaService)
        {
            _pessoaService = pessoaService;        
        }
        public IActionResult Index()
        {
            var list = _pessoaService.FindAll();

            return View(list);
        }
    }
}
