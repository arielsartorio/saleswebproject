using System;

namespace SalesWebProject.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base(message) 
        {
        }
    }
}
