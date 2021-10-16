using Microsoft.AspNetCore.Mvc;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;

namespace ProjectPowerWebApi.Controllers.Areas.CachingService
{
    
    [Route("api/[controller]")]
    public class CachingController : ControllerBase
    {
        private ICachingService _cachingService;

        public CachingController(ICachingService cachingService)
        {
            _cachingService = cachingService;
        }
    }
}
