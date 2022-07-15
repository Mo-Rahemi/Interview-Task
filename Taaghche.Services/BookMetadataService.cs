using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taaghche.Application;
using Taaghche.Core;

namespace Taaghche.Services
{
    public class BookMetadataService : IDataService<BookMetadata>
    {
        public IReadOnlyCollection<DataProvider<BookMetadata>> DataProviders => _dataProviders;

        public BookMetadataService()
        {
            AddDataProvider(new Infrastructure.Memory.BookMetadataMemoryStorage(new Infrastructure.Memory.MemoryContext()));
            AddDataProvider(new Infrastructure.Redis.BookMetadataRedisStorage(new Infrastructure.Redis.RedisContext()));
            AddDataProvider(new BookMetadataApiProvider());
        }
        public Task<BookMetadata> Get(Dictionary<string, object> Args)
        {
            return _dataProviders.FirstOrDefault()?.GetOrPass(Args);
        }
        public void AddDataProvider<F>(F Provider) where F : DataProvider<BookMetadata>
        {
            _dataProviders.LastOrDefault()?.SetNext(Provider);
            _dataProviders.Add(Provider);
        }

        private readonly List<DataProvider<BookMetadata>> _dataProviders = new List<DataProvider<BookMetadata>>();
    }
}
