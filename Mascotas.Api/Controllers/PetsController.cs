using Mascotas.Api.Application;
using Mascotas.Api.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascotas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetApplication petApplication;

        public PetsController(IPetApplication petApplication)
        {
            this.petApplication = petApplication;
        }

        [HttpPost]
        public async Task<ActionResult<ResponseEntityDto>> CreatePet(PetDto pet)
        {
            var petResult = await petApplication.AddPet(pet);

            return petResult;
        }
    }
}
