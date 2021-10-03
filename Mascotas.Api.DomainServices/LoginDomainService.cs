using Mascotas.Api.Domain;
using Mascotas.Api.Domain.Models;
using Mascotas.Api.Infrastructure.Context;
using Mascotas.Api.Infrastructure.Repositories.IRepositories;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Mascotas.Api.DomainServices
{
    public class LoginDomainService : ILoginDomain
    {
        private readonly ApplicationDbContext context;
        private readonly IConfiguration configuration;
        private readonly IRolRepository rolRepository;

        public LoginDomainService(ApplicationDbContext context, IConfiguration configuration, IRolRepository rolRepository)
        {
            this.context = context;
            this.configuration = configuration;
            this.rolRepository = rolRepository;
        }

        public LoginDto AuthenticateUser(LoginDto loginDto)
        {
            throw new NotImplementedException();
        }

        public string GenerateJsonWebToken(LoginDto loginDto)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken();

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
