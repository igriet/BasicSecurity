using BasicSecurity.Models;
using BasicSecurity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicSecurity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BikeController : ControllerBase
    {
        private readonly IBikeService _bikeService;

        public BikeController(IBikeService bikeService)
        {
            _bikeService = bikeService;
        }

        [HttpGet]
        public async Task<IEnumerable<Bike>> Get() => await _bikeService.Get();
    }
}
