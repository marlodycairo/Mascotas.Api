using Mascotas.Api.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas.Api.Infrastructure.Repositories.IRepositories
{
    public interface IHistoryRepository
    {
        Task<IEnumerable<History>> GetAllHistories();
        Task<History> GetHistoryById(int id);
        Task<History> UpdateHistory(int id, History history);
        Task<History> CreateNewHistory(History history);
        Task<History> SearchHistory();
    }
}
