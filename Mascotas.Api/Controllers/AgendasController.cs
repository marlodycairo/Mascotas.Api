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
    public class AgendasController : ControllerBase
    {
        private readonly IAgendaApplication agendaApplication;

        public AgendasController(IAgendaApplication agendaApplication)
        {
            this.agendaApplication = agendaApplication;
        }

        [HttpPost]
        public async Task<ActionResult<AgendaDto>> CreateNewOwner(AgendaDto agenda)
        {
            var newAgenda = await agendaApplication.AddNewAgenda(agenda);

            return Ok(newAgenda);
        }
    }
}
