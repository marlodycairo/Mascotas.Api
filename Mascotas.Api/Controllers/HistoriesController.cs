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
    public class HistoriesController : ControllerBase
    {
        private readonly IHistoryApplication historyApplication;

        public HistoriesController(IHistoryApplication historyApplication)
        {
            this.historyApplication = historyApplication;
        }

        [HttpPost]
        public async Task<ActionResult<ResponseEntityDto>> AddNewHistory(HistoryDto historyDto)
        {
            var history = await historyApplication.CreateNewHistory(historyDto);

            return Ok(history);
        }
    }
}
