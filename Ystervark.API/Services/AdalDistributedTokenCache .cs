using System;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace Ystervark.API.Services
{
    /// <summary>
    /// ADAL Distributed Token Cache Class
    /// </summary>
    /// <seealso cref="Microsoft.IdentityModel.Clients.ActiveDirectory.TokenCache" />
    public class AdalDistributedTokenCache : TokenCache
    {
        private readonly IDistributedCache _cache;
        private readonly string _userId;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdalDistributedTokenCache"/> class.
        /// </summary>
        /// <param name="cache">The cache.</param>
        /// <param name="userId">The user identifier.</param>
        public AdalDistributedTokenCache(IDistributedCache cache, string userId)
        {
            _cache = cache;
            _userId = userId;
            BeforeAccess = BeforeAccessNotification;
            AfterAccess = AfterAccessNotification;
        }

        /// <summary>
        /// Gets the cache key.
        /// </summary>
        /// <returns></returns>
        private string GetCacheKey()
        {
            return $"{_userId}_TokenCache";
        }

        /// <summary>
        /// Fires before the access notification.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private void BeforeAccessNotification(TokenCacheNotificationArgs args)
        {
            Deserialize(_cache.Get(GetCacheKey()));
        }

        /// <summary>
        /// Afters the access notification.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private void AfterAccessNotification(TokenCacheNotificationArgs args)
        {
            if (!HasStateChanged) return;
            _cache.Set(GetCacheKey(), Serialize(), new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(1)
            });
            HasStateChanged = false;
        }
    }
}