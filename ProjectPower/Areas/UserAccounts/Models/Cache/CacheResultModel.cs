using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.UserAccounts.Models.Cache
{
    public class CacheResultModel
    {
        public enum CacheStatus
        {
            ResultPending,
            Cached,
            Deleted,
            IsNull,
            NotNull,
            Error
        }
        public CacheResultModel(string key)
        {
            Key = key;
            Value = string.Empty;
            Status = CacheStatus.ResultPending;
            Error = null;
        }
        public string Key { get; set; }
        public string Value { get; set; }
        public CacheStatus Status { get; set; }
        internal Exception Error { get; set; }

    
    }
}
