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
        private readonly IEntitiyService _entityServices;
        public EntityController(IEntitiyService entityServices)
        {
            _entityServices = entityServices;
        }



        [HttpGet("getAllEntities")]
        public async Task<IEnumerable<Entity>> getAllEntities()
        {
            var output = await _entityServices.GetAllAsync();
            return output;

        }

        [HttpPost("insertEntity")]
        public Task<ResultVM> insertEntity(string EntityName,  string EntityDesc)
        {

            var output = _entityServices.Insert(EntityName, EntityDesc);
            return output;

        }
    }
}
