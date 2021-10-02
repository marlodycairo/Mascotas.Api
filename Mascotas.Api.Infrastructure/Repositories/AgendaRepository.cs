using Mascotas.Api.Infrastructure.Context;
using Mascotas.Api.Infrastructure.Entities;
using Mascotas.Api.Infrastructure.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas.Api.Infrastructure.Repositories
{
    public class AgendaRepository : IAgendaRepository
    {
        private readonly ApplicationDbContext context;

        public AgendaRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Agenda> AddOwner(Agenda agenda)
        {
            await context.AddAsync(agenda);

            await context.SaveChangesAsync();

            return agenda;
        }
    }
}
