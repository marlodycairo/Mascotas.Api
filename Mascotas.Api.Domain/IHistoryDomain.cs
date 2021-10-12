using Mascotas.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas.Api.Domain
{
    public interface IHistoryDomain
    {
        Task<IEnumerable<HistoryDto>> GetAllHistories();
        Task<HistoryDto> GetHistoryById(int id);
        Task<HistoryDto> UpdateHistory(int id, HistoryDto history);
        Task<HistoryDto> CreateNewHistory(HistoryDto history);
        Task<HistoryDto> SearchHistory();
    }
}
