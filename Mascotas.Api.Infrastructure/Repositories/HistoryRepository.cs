using Mascotas.Api.Infrastructure.Entities;
using Mascotas.Api.Infrastructure.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas.Api.Infrastructure.Repositories
{
    public class HistoryRepository : IHistoryRepository
    {
        public Task<History> CreateNewHistory(History history)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<History>> GetAllHistories()
        {
            throw new NotImplementedException();
        }

        public Task<History> GetHistoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<History> SearchHistory()
        {
            throw new NotImplementedException();
        }

        public Task<History> UpdateHistory(int id, History history)
        {
            throw new NotImplementedException();
        }
    }
}
