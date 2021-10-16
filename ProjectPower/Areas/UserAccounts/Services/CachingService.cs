using Microsoft.Extensions.Caching.Memory;
using ProjectPower.Areas.UserAccounts.Models.Cache;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace ProjectPower.Areas.UserAccounts.Services
{
    public class CachingService : ICachingService
    {
        private IMemoryCache _cache;

        public CachingService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public CacheResultModel SaveToCache<T>(string key, int expHours, int expMinutes,int expSeconds,T toCache,bool forceOverwrite)
        {
            CacheResultModel result = new CacheResultModel(key);
            try
            {
                string cachedObject = string.Empty;

                    if(!_cache.TryGetValue<string>(key, out cachedObject))
                    {
                        TimeSpan time = new TimeSpan(expHours, expMinutes, expSeconds);
                        cachedObject = Newtonsoft.Json.JsonConvert.SerializeObject(toCache);
                        _cache.Set<string>(key, cachedObject, time);
                        result.Value = cachedObject;
                        result.Status = CacheResultModel.CacheStatus.Cached;
                    }
                    else
                    {
                        if(!forceOverwrite)
                        {
                            result.Status = CacheResultModel.CacheStatus.NotNull;
                        }

                        else
                        {
                            TimeSpan time = new TimeSpan(expHours, expMinutes, expSeconds);
                            cachedObject = Newtonsoft.Json.JsonConvert.SerializeObject(toCache);
                            _cache.Set<string>(key, cachedObject, time);
                            result.Value = cachedObject;
                            result.Status = CacheResultModel.CacheStatus.Cached;
                        }
                    }
            }
            catch(Exception error)
            {
                result.Status = CacheResultModel.CacheStatus.Error;
                result.Error = error;
            }
            return result;
        }
        public async Task<CacheResultModel> SaveToCacheAsync<T>(string key, int expHours, int expMinutes, int expSeconds, T toCache, bool forceOverwrite)
        {
            CacheResultModel result = new CacheResultModel(key);
            try
            {
                string cachedObject = string.Empty;
                await Task.Run(() =>
                {
                    if (!_cache.TryGetValue<string>(key, out cachedObject))
                    {
                        TimeSpan time = new TimeSpan(expHours, expMinutes, expSeconds);
                        cachedObject = Newtonsoft.Json.JsonConvert.SerializeObject(toCache);
                        _cache.Set<string>(key, cachedObject, time);
                        result.Value = cachedObject;
                        result.Status = CacheResultModel.CacheStatus.Cached;
                    }
                    else
                    {
                        if (!forceOverwrite)
                        {
                            result.Status = CacheResultModel.CacheStatus.NotNull;
                        }
                        else
                        {
                            TimeSpan time = new TimeSpan(expHours, expMinutes, expSeconds);
                            cachedObject = Newtonsoft.Json.JsonConvert.SerializeObject(toCache);
                            _cache.Set<string>(key, cachedObject, time);
                            result.Value = cachedObject;
                            result.Status = CacheResultModel.CacheStatus.Cached;
                        }
                    }
                });
            }
            catch (Exception error)
            {
                result.Status = CacheResultModel.CacheStatus.Error;
                result.Error = error;
            }
            return result;
        }
        public async Task<CacheResultModel> RetrieveFromCacheAsync(string key)
        {
            CacheResultModel result = new CacheResultModel(key);
            try
            {
                string cachedObject = string.Empty;
                await Task.Run(() =>
                {
                    if (!_cache.TryGetValue<string>(key, out cachedObject))
                    {
                        result.Status = CacheResultModel.CacheStatus.IsNull;
                    }
                    else
                    {
                        result.Status = CacheResultModel.CacheStatus.NotNull;
                        result.Value = cachedObject;
                    }
                });
            }
            catch (Exception error)
            {
                result.Status = CacheResultModel.CacheStatus.Error;
                result.Error = error;
            }
            return result;
        }
        public CacheResultModel RetrieveFromCache(string key)
        {
            CacheResultModel result = new CacheResultModel(key);
            try
            {
                string cachedObject = string.Empty;

                    if (!_cache.TryGetValue<string>(key, out cachedObject))
                    {
                        result.Status = CacheResultModel.CacheStatus.IsNull;
                    }
                    else
                    {
                        result.Status = CacheResultModel.CacheStatus.NotNull;
                        result.Value = cachedObject;
                    }
            }
            catch (Exception error)
            {
                result.Status = CacheResultModel.CacheStatus.Error;
                result.Error = error;
            }
            return result;
        }
        public async Task<CacheResultModel> DeleteFromCacheAsync(string key)
        {
            CacheResultModel result = new CacheResultModel(key);
            try
            {
                await Task.Run(() =>
                {
                    string cachedObject = string.Empty;
                    if (!_cache.TryGetValue<string>(key, out cachedObject))
                    {
                        result.Status = CacheResultModel.CacheStatus.IsNull;
                    }
                    else
                    {
                        _cache.Remove(key);
                        result.Status = CacheResultModel.CacheStatus.Deleted;
                    }
                });              
            }
            catch(Exception error)
            {
                result.Status = CacheResultModel.CacheStatus.Error;
                result.Error = error;
            }

            return result;
        }
        public CacheResultModel DeleteFromCache(string key)
        {
            CacheResultModel result = new CacheResultModel(key);
            try
            {
                string cachedObject = string.Empty;
                if (!_cache.TryGetValue<string>(key, out cachedObject))
                {
                    result.Status = CacheResultModel.CacheStatus.IsNull;
                }
                else
                {
                    _cache.Remove(key);
                    result.Status = CacheResultModel.CacheStatus.Deleted;
                }
            }
            catch (Exception error)
            {
                result.Status = CacheResultModel.CacheStatus.Error;
                result.Error = error;
            }

            return result;
        }
    }
}
