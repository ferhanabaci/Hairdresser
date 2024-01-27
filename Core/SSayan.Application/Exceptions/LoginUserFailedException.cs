using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SSayan.Application.Exceptions
{
    public class LoginUserFailedException : Exception
    {
        public LoginUserFailedException() : base("Kullanıcı bulanamadı lütfen tekrar dene") 
        {
        }

        public LoginUserFailedException(string? message) : base(message)
        {
        }

        public LoginUserFailedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

    }
}
