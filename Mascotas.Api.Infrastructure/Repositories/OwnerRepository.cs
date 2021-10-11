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
    public class OwnerRepository : IOwnerRepository
    {
        private readonly ApplicationDbContext context;

        public OwnerRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Owner> AddOwner(Owner owner)
        {
            await context.Owners.AddAsync(owner);

            await context.SaveChangesAsync();

            return owner;
        }

        public async Task DeleteOwner(int id)
        {
            //var owner = await context.Owners.FindAsync(id);
            IQueryable<Owner> owner = context.Owners;

            var oneOwner = await owner.Where(o => o.Id == id).FirstOrDefaultAsync();

            context.Remove(oneOwner);

            await context.SaveChangesAsync();

            owner.Load();
        }

        public async Task<IEnumerable<Owner>> GetAllOwners()
        {
            //IQueryable<Owner> owners = context.Owners.Where(p => p.FirstName.StartsWith("m"));

            //owners.Load();
            //return await owners.ToListAsync();

            return await context.Owners
                .Include(p => p.Pets)
                .ToListAsync();
        }

        public async Task<Owner> GetOwnerById(int id)
        {
            //var owner = await context.Owners.FirstOrDefaultAsync(p => p.Id == id);
            //return owner;

            IQueryable<Owner> owner = context.Owners;

            return await owner.SingleAsync(p => p.Id == id);
        }

        public async Task<ResponseEntity> ReturnMessage(Owner owner)
        {
            var ownerExist = await context.Owners.AnyAsync(p => p.Id == owner.Id);

            if (ownerExist)
            {
                return new ResponseEntity
                {
                    Id = owner.Id,
                    PropertyName = owner.FirstName + " " + owner.LastName,
                    Message = ResponseMessage.RecordExist
                };
            }
            await context.Owners.AddAsync(owner);

            await context.SaveChangesAsync();

            return new ResponseEntity
            {
                Id = owner.Id,
                PropertyName = owner.FirstName + " " + owner.LastName,
                Message = ResponseMessage.RecordSuccessfullSaved
            };
        }

        public async Task<ResponseEntity> ReturnMessageUpdateOwner(Owner owner)
        {
            var ownerExist = await context.Owners.AnyAsync(p => p.Id == owner.Id);

            if (!ownerExist)
            {
                return new ResponseEntity
                {
                    Id = owner.Id,
                    PropertyName = owner.FirstName + " " + owner.LastName,
                    Message = ResponseMessage.RecordNotExist
                };
            }
            await context.Owners.AddAsync(owner);

            await context.SaveChangesAsync();

            return new ResponseEntity
            {
                Id = owner.Id,
                PropertyName = owner.FirstName + " " + owner.LastName,
                Message = ResponseMessage.RecordUpdated
            };
        }

        public async Task<ResponseEntity> UpdateOwner(Owner owner)
        {
            var result = await ReturnMessageUpdateOwner(owner);

            return result;
        }
    }
}
