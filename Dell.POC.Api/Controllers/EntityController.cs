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
using Microsoft.AspNetCore.Http;

namespace Dell.POC.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EntityController : ControllerBase
    {
        private readonly IEntitiyService _entityServices;
        private readonly IEntitiyAttributeService _entityAttributeServices;
        private readonly IItemService _itemService;
        public EntityController(IEntitiyService entityServices, IEntitiyAttributeService entityAttributeServices, IItemService itemService)
        {
            _entityServices = entityServices;
            _entityAttributeServices = entityAttributeServices;
            _itemService = itemService;
        }



        [HttpGet("getAllEntities")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IEnumerable<Entity>> getAllEntities()
        {
            var output = await _entityServices.GetAllAsync();
            return output;

        }

        [HttpPost("insertEntity")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ResultVM> insertEntity(string EntityName,  string EntityDesc)
        {

            var output = _entityServices.Insert(EntityName, EntityDesc);
            return output;

        }

        [HttpPost("insertEntityAttribute")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ResultVM> insertEntityAttribute(int entityId,string attributeValue,string attributeName)
        {

            var output = _entityAttributeServices.Insert(entityId,attributeValue, attributeName);
            return output;

        }

        [HttpPost("insertItem")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ResultVM> insertItem(string itemName, string itemDescription)
        {

            var output = _itemService.Insert(itemName, itemDescription);
            return output;

        }
    }
}
