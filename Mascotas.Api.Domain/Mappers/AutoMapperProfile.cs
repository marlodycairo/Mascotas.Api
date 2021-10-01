using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Mascotas.Api.Domain.Models;
using Mascotas.Api.Infrastructure.Entities;

namespace Mascotas.Api.Domain.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Pet, PetDto>();
            CreateMap<PetDto, Pet>();
        }
    }
}
