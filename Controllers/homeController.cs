using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Guid;

namespace WeatherAPI.Controllers
{
    [ApiController]
    {Route("[controller]")}
    public class homeController : ControllerBase
    {
        public async Task<string> GetNewId(CancellationToken CancellationToken)
        {
            var tokenId = Guid.NewGuid().ToString();

            return Ok(tokenId);
        }         
    }
}