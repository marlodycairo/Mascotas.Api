using Mascotas.Api.Infrastructure.Context;
using Mascotas.Api.Infrastructure.Entities;
using Mascotas.Api.Infrastructure.Repositories.IRepositories;
using Mascotas.Api.Infrastructure.Responses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas.Api.Infrastructure.Repositories
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly ApplicationDbContext context;

        public HistoryRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<ResponseEntity> CreateNewHistory(History history)
        {
            IQueryable<History> histories = context.Histories;

            var historyExist = await context.Histories.AnyAsync(h => h.Id == history.Id);

            if (historyExist)
            {
                return new ResponseEntity { Message = ResponseMessage.RecordExist };
            }
            else if (history == null)
            {
                return new ResponseEntity { Message = ResponseMessage.RecordIsNull };
            }

            context.Histories.Add(history);

            context.ChangeTracker.DetectChanges();

            await context.SaveChangesAsync();

            return new ResponseEntity { Id = history.Id, Message = ResponseMessage.RecordSuccessfullSaved };
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

        public Task<ResponseEntity> UpdateHistory(int id, History history)
        {
            throw new NotImplementedException();
        }
    }
}
