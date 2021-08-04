using System;

namespace CadastroPessoas.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base (message)
        { }
    }
}
