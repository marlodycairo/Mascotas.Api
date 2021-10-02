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
            CreateMap<Pet, PetDto>()
                .ForMember(dest => dest.CatRaces, opt => opt.MapFrom(src => src.CatRaces))
                .ForMember(dest => dest.DogRaces, opt => opt.MapFrom(src => src.DogRaces))
                .ForMember(dest => dest.OwnerDto, opt => opt.MapFrom(src => src.Owner));

            CreateMap<PetDto, Pet>();

            CreateMap<Owner, OwnerDto>()
                .ForMember(dest => dest.PetDtos, opt => opt.MapFrom(src => src.Pets));

            CreateMap<OwnerDto, Owner>();
        }
    }
}
