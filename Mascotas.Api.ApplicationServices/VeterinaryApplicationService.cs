﻿using Mascotas.Api.Application;
using Mascotas.Api.Domain;
using Mascotas.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas.Api.ApplicationServices
{
    public class VeterinaryApplicationService : IVeterinaryApplication
    {
        private readonly IVeterinaryDomain veterinaryDomain;

        public VeterinaryApplicationService(IVeterinaryDomain veterinaryDomain)
        {
            this.veterinaryDomain = veterinaryDomain;
        }

        public async Task<ResponseEntityDto> AddNewVeterinary(VeterinaryDto veterinary)
        {
            return await veterinaryDomain.AddNewVeterinary(veterinary);
        }

        public async Task DeleteVeterinary(int id)
        {
            await veterinaryDomain.DeleteVeterinary(id);
        }

        public async Task<IEnumerable<VeterinaryDto>> GetAllVeterinary()
        {
            return await veterinaryDomain.GetAllVeterinary();
        }

        public async Task<VeterinaryDto> GetVeterinaryById(int id)
        {
            return await veterinaryDomain.GetVeterinaryById(id);
        }

        public async Task<ResponseEntityDto> UpdateVeterinary(VeterinaryDto veterinary)
        {
            return await veterinaryDomain.UpdateVeterinary(veterinary); 
        }
    }
}
