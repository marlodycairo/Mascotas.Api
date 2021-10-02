using Mascotas.Api.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas.Api.Infrastructure.Repositories.IRepositories
{
    public interface IAgendaRepository
    {
        Task<Agenda> AddNewAgenda(Agenda agenda);
    }
}
