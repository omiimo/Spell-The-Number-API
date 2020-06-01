using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SpellTheNumberAPI.Models;
using SpellTheNumberAPI.Services;
using Swashbuckle.Swagger.Annotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpellTheNumberAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpellTheWordController : ControllerBase
    {    
        /// <summary>
        /// Converts the number into words (Indian Standard)
        /// </summary>
        /// <param name="number">Number which you want to spell</param>
        /// <returns></returns>
        [HttpGet("{number}")]
        [SwaggerResponse(System.Net.HttpStatusCode.OK,"",typeof(SpellModel))]
        public string Get(string number)
        {
            return JsonConvert.SerializeObject(new SpellModel { Response = new SpellTheNumber().SpellIt(number) });
        }
       
    }
}
