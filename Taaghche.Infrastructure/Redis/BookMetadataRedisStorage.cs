using Taaghche.Core;
using Taaghche.Application;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;

namespace Taaghche.Infrastructure.Redis
{
    public class BookMetadataRedisStorage : DataProvider<BookMetadata>, IDataStorage<BookMetadata>
    {
        public BookMetadataRedisStorage(RedisContext RedisContext)
        {
            _redisContext = RedisContext;
            //_redisContext.Redis.GetDatabase().StringGetDelete("0");
        }
        public async Task<bool> Add(BookMetadata Entity)
        {
            if (Entity == null) return false;

            return await _redisContext.Redis.GetDatabase().StringSetAsync(Entity.Id.ToString(), Entity.AsJson());
        }
        public async Task<BookMetadata> Get(int Id)
        {
            var result = await _redisContext.Redis.GetDatabase().StringGetAsync(Id.ToString());
            if (!result.HasValue) return null;
            var json = result.ToString();
            return await BookMetadata.FromJson(json);
        }
        /// <summary>
        /// get data from Redis db
        /// </summary>
        /// <param name="Args">Must contain id as Key with integer value</param>
        /// <returns></returns>
        public override async Task<BookMetadata> Get(Dictionary<string, object> Args)
        {
            int id = 0;
            if ((!Args?.ContainsKey("id") ?? true) || !int.TryParse(Args["id"].ToString(), out id))
                return null;

            return await Get(id);
        }

        private readonly RedisContext _redisContext;
    }
}
