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
    public class HistoryDomainService : IHistoryDomain
    {
        private readonly IHistoryRepository historyRepository;
        private readonly IMapper mapper;

        public HistoryDomainService(IHistoryRepository historyRepository, IMapper mapper)
        {
            this.historyRepository = historyRepository;
            this.mapper = mapper;
        }

        public async Task<ResponseEntityDto> CreateNewHistory(HistoryDto historyDto)
        {
            var historyMap = mapper.Map<History>(historyDto);

            var history = await historyRepository.CreateNewHistory(historyMap);

            var response = mapper.Map<ResponseEntityDto>(history);

            return response;
        }

        public Task<IEnumerable<HistoryDto>> GetAllHistories()
        {
            throw new NotImplementedException();
        }

        public Task<HistoryDto> GetHistoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<HistoryDto> SearchHistory()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseEntityDto> UpdateHistory(int id, HistoryDto history)
        {
            throw new NotImplementedException();
        }
    }
}
