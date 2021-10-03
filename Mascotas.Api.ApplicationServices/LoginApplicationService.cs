using Mascotas.Api.Application;
using Mascotas.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mascotas.Api.ApplicationServices
{
    public class LoginApplicationService : ILoginApplication
    {
        public LoginDto AuthenticateUser(LoginDto login)
        {
            throw new NotImplementedException();
        }

        public string GenerateJsonWebToken(LoginDto loginDto)
        {
            throw new NotImplementedException();
        }
    }
}
