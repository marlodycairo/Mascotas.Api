using Mascotas.Api.Domain;
using Mascotas.Api.Domain.Models;
using Mascotas.Api.Infrastructure.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas.Api.DomainServices
{
    public class PetDomainService : IPetDomain
    {
        private readonly IPetRepository petRepository;

        public PetDomainService(IPetRepository petRepository)
        {
            this.petRepository = petRepository;
        }

        public Task<PetDto> AddPet(PetDto pet)
        {
            throw new NotImplementedException();
        }

        public Task DeletePet(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PetDto>> GetAllPets()
        {
            throw new NotImplementedException();
        }

        public Task<PetDto> GetPetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PetDto> UpdatePet(PetDto pet)
        {
            throw new NotImplementedException();
        }
    }
}
