﻿using Mascotas.Api.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mascotas.Api.Domain.Models
{
    public class PetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Photo { get; set; }
        public DateTime Born { get; set; }
        public PetType PetTypes { get; set; }
        public DogRace DogRaces { get; set; }
        public CatRace CatRaces { get; set; }
        //public Owner Owner { get; set; }
    }
}
