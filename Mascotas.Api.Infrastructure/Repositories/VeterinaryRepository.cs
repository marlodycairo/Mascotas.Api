using Mascotas.Api.Infrastructure.Context;
using Mascotas.Api.Infrastructure.Entities;
using Mascotas.Api.Infrastructure.Repositories.IRepositories;
using Mascotas.Api.Infrastructure.Responses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Mascotas.Api.Infrastructure.Repositories
{
    public class VeterinaryRepository : IVeterinaryRepository
    {
        private readonly ApplicationDbContext context;

        public VeterinaryRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<ResponseEntity> AddNewVeterinary(Veterinary veterinary)
        {
            var result = await ReturnMessage(veterinary);

            return result;
        }

        public async Task DeleteVeterinary(int id)
        {
            var veterinayById = context.Veterinaries.FindAsync(id);

            context.Remove(veterinayById);

            await context.SaveChangesAsync();
        }

        public async Task<Veterinary> GetVeterinaryById(int id)
        {
            var findVeterinaryById = await context.Veterinaries.FirstOrDefaultAsync(p => p.Id == id);

            return findVeterinaryById;
        }

        public async Task<IEnumerable<Veterinary>> GetAllVeterinary()
        {
            return await context.Veterinaries
                .Include(p => p.Speciality)
                .ToListAsync();
        }

        public async Task<ResponseEntity> UpdateVeterinary(Veterinary veterinary)
        {
            var result = await ReturnMessageUpdateVeterinary(veterinary);

            return result;
        }

        public async Task<ResponseEntity> ReturnMessage(Veterinary veterinary)
        {
            var veterinaryExist = await context.Veterinaries.AnyAsync(p => p.Id == veterinary.Id);

            if (veterinaryExist)
            {
                return new ResponseEntity
                {
                    Id = veterinary.Id,
                    PropertyName = veterinary.FullName,
                    Message = ResponseMessage.RecordExist
                };
            }
            IQueryable<Veterinary> veterinaries = context.Veterinaries;

            var newVeterinary = context.Veterinaries.AddAsync(veterinary);

            await context.SaveChangesAsync();

            var lstVeterinaries = new List<Veterinary>();

            await veterinaries.ForEachAsync(v => lstVeterinaries.ToList());

            return new ResponseEntity
            {
                Id = veterinary.Id,
                PropertyName = veterinary.FullName,
                Message = ResponseMessage.RecordSuccessfullSaved
            };
        }

        public async Task<ResponseEntity> ReturnMessageUpdateVeterinary(Veterinary veterinary)
        {
            var veterinaryExist = await context.Veterinaries.AnyAsync(p => p.Id == veterinary.Id);

            if (!veterinaryExist)
            {
                return new ResponseEntity
                {
                    Id = veterinary.Id,
                    PropertyName = veterinary.FullName,
                    Message = ResponseMessage.RecordNotExist
                };
            }
            await context.Veterinaries.AddAsync(veterinary);

            await context.SaveChangesAsync();

            return new ResponseEntity
            {
                Id = veterinary.Id,
                PropertyName = veterinary.FullName,
                Message = ResponseMessage.RecordUpdated
            };
        }
    }
}
