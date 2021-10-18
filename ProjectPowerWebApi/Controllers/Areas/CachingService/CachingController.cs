using Microsoft.AspNetCore.Mvc;
using ProjectPower.Areas.UserAccounts.Models.Cache;
using ProjectPower.Areas.UserAccounts.Models.UserAccounts;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPower.Areas.UserAccounts.Services.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ProjectPowerWebApi.Controllers.Areas.CachingService
{

    [Route("api/[controller]")]
    public class CachingController : ControllerBase
    {
        public class CacheDummyObject
        {
            public int Week { get; set; }
            public int Day { get; set; }
            public string Username { get; set; }
            public CacheDummyObject(int currentWeek, int currentDay, string username)
            {
                Week = currentWeek;
                Day = currentDay;
                Username = username;

            }
    }
        private ICachingService _cachingService; 
        public CachingController(ICachingService cachingService)
        {
            _cachingService = cachingService;
        }

        [Route("storeasync")]
        [HttpGet]
        public async Task<IActionResult> CacheObjectAsync(string key)
        {
            CacheDummyObject objectToStore = new CacheDummyObject(1, 1, "bzzt");
            CacheResultModel result = await _cachingService.SaveToCacheAsync(key, 0, 5, 30, objectToStore, true);

            return Ok(result);
        }

        [Route("store")]
        [HttpGet]
        public IActionResult CacheObject(string key, UserCacheInformationModel model)
        {
            var x = Request.Body;
            var y = Url;
            var yz = User;
            CacheDummyObject objectToStore = new CacheDummyObject(model.CurrentWeek, model.CurrentDay, model.UserName);
            CacheResultModel result = _cachingService.SaveToCache(model.UserName, 0, 5, 30, objectToStore, true);

            return Ok(result);
        }

        [Route("fetchasync")]
        [HttpGet]
        public async Task<IActionResult> FetchAsync(string key)
        {
            CacheResultModel result = await _cachingService.RetrieveFromCacheAsync(key);
            return Ok(result);
        }

        [Route("fetch")]
        [HttpGet]
        public IActionResult Fetch(string key)
        {
            CacheResultModel result = _cachingService.RetrieveFromCache(key);
            return Ok(result);
        }
        
        [Route("deleteasync")]
        [HttpGet]
        public async Task<IActionResult> DeleteAsync(string key)
        {
            CacheResultModel result = await _cachingService.DeleteFromCacheAsync(key);
            return Ok(result);
        }

        [Route("delete")]
        [HttpGet]
        public async Task<IActionResult> Delete(string key)
        {
            CacheResultModel result = _cachingService.DeleteFromCache(key);
            return Ok(result);
        }
    }
}
