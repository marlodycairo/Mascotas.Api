using Mascotas.Api.Application;
using Mascotas.Api.Domain;
using Mascotas.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas.Api.ApplicationServices
{
    public class AgendaApplicationService : IAgendaApplication
    {
        private readonly IAgendaDomain agendaDomain;

        public AgendaApplicationService(IAgendaDomain agendaDomain)
        {
            this.agendaDomain = agendaDomain;
        }

        public async Task<AgendaDto> AddNewAgenda(AgendaDto agenda)
        {
            return await agendaDomain.AddAgenda(agenda);
        }
    }
}
