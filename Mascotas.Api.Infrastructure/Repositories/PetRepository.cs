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
    public class PetRepository : IPetRepository
    {
        private readonly ApplicationDbContext _context;

        public PetRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseEntity> AddPet(Pet pet)
        {
            var result = await ReturnMessage(pet);

            return result;
        }

        public async Task<ResponseEntity> ReturnMessage(Pet pet)
        {
            var petExist = await _context.Pets.AnyAsync(p => p.Id == pet.Id);
 
            if (petExist)
            {
                return new ResponseEntity 
                {
                    Id = pet.Id,
                    PropertyName = pet.Name,
                    Message = ResponseMessage.RecordExist
                };
            }
            await _context.Pets.AddAsync(pet);

            await _context.SaveChangesAsync();

            return new ResponseEntity
            {
                Id = pet.Id,
                PropertyName = pet.Name,
                Message = ResponseMessage.RecordSuccessfullSaved
            };
        }

        public async Task DeletePet(int id)
        {
            var petById = _context.Pets.FindAsync(id);

            _context.Remove(petById);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Pet>> GetAllPets()
        {
            return await _context.Pets.ToListAsync();
        }

        public async Task<Pet> GetPetById(int id)
        {
            var findPetById = await _context.Pets.FirstOrDefaultAsync(p => p.Id == id);

            return findPetById;
        }

        public async Task<ResponseEntity> UpdatePet(Pet pet)
        {
            var result = await ReturnMessageUpdatePet(pet);

            return result;
        }

        public async Task<ResponseEntity> ReturnMessageUpdatePet(Pet pet)
        {
            var petExist = await _context.Pets.AnyAsync(p => p.Id == pet.Id);

            if (!petExist)
            {
                return new ResponseEntity
                {
                    Id = pet.Id,
                    PropertyName = pet.Name,
                    Message = ResponseMessage.RecordNotExist
                };
            }
            await _context.Pets.AddAsync(pet);

            await _context.SaveChangesAsync();

            return new ResponseEntity
            {
                Id = pet.Id,
                PropertyName = pet.Name,
                Message = ResponseMessage.RecordUpdated
            };
        }
    }
}
