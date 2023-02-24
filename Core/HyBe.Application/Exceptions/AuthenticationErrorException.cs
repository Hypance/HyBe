using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyBe.Application.Exceptions
{
    public class AuthenticationErrorException : Exception
    {
         public AuthenticationErrorException() :base("Kimlik doğrulama hatası!")
        {
        }

        public AuthenticationErrorException(string? message) : base(message)
        {
        }

        public AuthenticationErrorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}