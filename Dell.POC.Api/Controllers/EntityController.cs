using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dell.POC.Repository;
using Dell.POC.Services;
using Dell.POC.Models;
using Json;
using Newtonsoft;
using Newtonsoft.Json;
using Dell.POC.Models;
namespace Dell.POC.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EntityController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<EntityController> _logger;
        private readonly IEntitiyService _entityServices;
        public EntityController(IEntitiyService entityServices)
        {
            _entityServices = entityServices;
        }



        [HttpGet("GetAllEntities")]
        public ActionResult<Root> GetAllEntities()
        {
            string output = _entityServices.GetAllAsync();

            var result = output.TrimStart('[').TrimEnd(']');
            Root dna = new Root();
            dna = JsonConvert.DeserializeObject<Root>(result);


            return dna;
        }

        [HttpGet("InsertEntity")]
        public Task<ResultVM> InsertEntity(string EntityName, string EntityDesc)
        {
            ResultVM result;
            var output = _entityServices.Insert(EntityName, EntityDesc);
            return output;
            
        }
    }
}
