using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dell.POC.Repository;
using Dell.POC.Services;
using Dell.POC.Models;
namespace Dell.POC.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntityController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<EntityController> _logger;
        private readonly  IEntitiyService<Entity> _entityServices;
        public EntityController(IEntitiyService<Entity> entityServices)
        {
            _entityServices = entityServices;
        }

        //[HttpGet]
        //public async Task< IEnumerable<Entity>> Get()
        //{
        //    //await _itemServices.InsertAsync(new Item()
        //    //{
        //    //    ItemName="SRavan",
        //    //    ItemDescription = "desc"
        //    //});

        //    IEnumerable<Entity> output = await _entityServices.GetAllAsync();
        //    return output;
        //}

        [HttpGet]
        public  IEnumerable<Entity> Get()
        {
            //await _itemServices.InsertAsync(new Item()
            //{
            //    ItemName="SRavan",
            //    ItemDescription = "desc"
            //});

           var output =  _entityServices.GetAll();
            return output;
        }
    }
}
