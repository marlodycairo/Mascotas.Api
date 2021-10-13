using Mascotas.Api.Application;
using Mascotas.Api.Domain;
using Mascotas.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas.Api.ApplicationServices
{
    public class HistoryApplicationService : IHistoryApplication
    {
        private readonly IHistoryDomain historyDomain;

        public HistoryApplicationService(IHistoryDomain historyDomain)
        {
            this.historyDomain = historyDomain;
        }

        public async Task<ResponseEntityDto> CreateNewHistory(HistoryDto history)
        {
            return await historyDomain.CreateNewHistory(history);
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
