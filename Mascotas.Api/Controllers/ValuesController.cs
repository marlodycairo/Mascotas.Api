using Mascotas.Api.Application;
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
    public class ValuesController : ControllerBase
    {
        private readonly IAgendaApplication agendaApplication;
        private readonly IPetApplication petApplication;
        private readonly IOwnerApplication ownerApplication;
        private readonly IVeterinaryApplication veterinaryApplication;

        public ValuesController(IAgendaApplication agendaApplication, IPetApplication petApplication,
            IOwnerApplication ownerApplication, IVeterinaryApplication veterinaryApplication)
        {
            this.agendaApplication = agendaApplication;
            this.petApplication = petApplication;
            this.ownerApplication = ownerApplication;
            this.veterinaryApplication = veterinaryApplication;
        }

        [HttpGet]
        public async Task<IActionResult> ConsultingData()
        {
            var pets = await petApplication.GetAllPets();
            var agendas = await agendaApplication.GetAllAgendas();
            var owners = await ownerApplication.GetAllOwner();
            var veterinaries = await veterinaryApplication.GetAllVeterinary();

            return Ok();
        }
    }
}
