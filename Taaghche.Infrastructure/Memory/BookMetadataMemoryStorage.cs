using Taaghche.Core;
using Taaghche.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taaghche.Infrastructure.Memory
{
    public class BookMetadataMemoryStorage : DataProvider<BookMetadata>, IDataStorage<BookMetadata>
    {
        public BookMetadataMemoryStorage(MemoryContext MemoryContext)
        {
            _memoryContext = MemoryContext;
        }
        public async Task<bool> Add(BookMetadata Entity)
        {
            if (Entity == null) return false;

            return _memoryContext.BooksMetadata.TryAdd(Entity.Id, Entity);
        }
        public async Task<BookMetadata> Get(int Id)
        {
            return _memoryContext.BooksMetadata.ContainsKey(Id) ? _memoryContext.BooksMetadata[Id] : null;
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

        private readonly MemoryContext _memoryContext;
    }
}
