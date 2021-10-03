using Mascotas.Api.Infrastructure.Context;
using Mascotas.Api.Infrastructure.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mascotas.Api.Infrastructure.Repositories
{
    public class RolRepository : IRolRepository
    {
        private readonly ApplicationDbContext context;

        public RolRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<string> GetRolsByUsers(int userId)
        {
            var list = new List<string>();

            return list;
        }
    }
}
