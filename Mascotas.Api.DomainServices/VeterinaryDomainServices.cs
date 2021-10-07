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
    public class VeterinaryDomainServices : IVeterinaryDomain
    {
        private readonly IVeterinaryRepository veterinaryRepository;
        private readonly IMapper mapper;

        public VeterinaryDomainServices(IVeterinaryRepository veterinaryRepository, IMapper mapper)
        {
            this.veterinaryRepository = veterinaryRepository;
            this.mapper = mapper;
        }

        public async Task<ResponseEntityDto> AddNewVeterinary(VeterinaryDto veterinary)
        {
            var veterinaryMapper = mapper.Map<Veterinary>(veterinary);

            var returnVeterinaryResponse = await veterinaryRepository.ReturnMessage(veterinaryMapper);

            var veterinaryResponse = mapper.Map<ResponseEntityDto>(returnVeterinaryResponse);

            return veterinaryResponse;
        }

        public async Task DeleteVeterinary(int id)
        {
            var veterinaryDelete = await veterinaryRepository.GetVeterinaryById(id);

            mapper.Map<VeterinaryDto>(veterinaryDelete);
        }

        public async Task<IEnumerable<VeterinaryDto>> GetAllVeterinary()
        {
            var veterinaries = await veterinaryRepository.GetAllVeterinary();

            var allVeterinaries = mapper.Map<IEnumerable<VeterinaryDto>>(veterinaries);

            return allVeterinaries;
        }

        public async Task<VeterinaryDto> GetVeterinaryById(int id)
        {
            var veterinaryById = await veterinaryRepository.GetVeterinaryById(id);

            var veterinary = mapper.Map<VeterinaryDto>(veterinaryById);

            return veterinary;
        }

        public async Task<ResponseEntityDto> UpdateVeterinary(VeterinaryDto veterinary)
        {
            var veterinaryMapper = mapper.Map<Veterinary>(veterinary);

            var returnVeterinaryResponse = await veterinaryRepository.ReturnMessage(veterinaryMapper);

            var veterinaryResponse = mapper.Map<ResponseEntityDto>(returnVeterinaryResponse);

            return veterinaryResponse;
        }
    }
}
