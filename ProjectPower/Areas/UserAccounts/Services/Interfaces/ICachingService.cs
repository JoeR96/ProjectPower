using ProjectPower.Areas.UserAccounts.Models.Cache;
using System.Threading.Tasks;

namespace ProjectPower.Areas.UserAccounts.Services.Interfaces
{
    public interface ICachingService
    {
        CacheResultModel SaveToCache<T>(string key, int expHours, int expMinutes, int expSeconds, T toCache, bool forceOverwrite);

        Task<CacheResultModel> SaveToCacheAsync<T>(string key, int expHours, int expMinutes, int expSeconds, T toCache, bool forceOverwrite);

        Task<CacheResultModel> RetrieveFromCacheAsync(string key);

        CacheResultModel RetrieveFromCache(string key);

        Task<CacheResultModel> DeleteFromCacheAsync(string key);

        CacheResultModel DeleteFromCache(string key);

    }
}
