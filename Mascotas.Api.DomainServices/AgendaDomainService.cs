using AutoMapper;
using Mascotas.Api.Domain;
using Mascotas.Api.Domain.Models;
using Mascotas.Api.Infrastructure.Entities;
using Mascotas.Api.Infrastructure.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas.Api.DomainServices
{
    public class AgendaDomainService : IAgendaDomain
    {
        private readonly IAgendaRepository agendaRepository;
        private readonly IMapper mapper;

        public AgendaDomainService(IAgendaRepository agendaRepository, IMapper mapper)
        {
            this.agendaRepository = agendaRepository;
            this.mapper = mapper;
        }

        public async Task<AgendaDto> AddAgenda(AgendaDto agenda)
        {
            var agendaMapper = mapper.Map<Agenda>(agenda);

            await agendaRepository.AddNewAgenda(agendaMapper);

            return agenda;
        }
    }
}
