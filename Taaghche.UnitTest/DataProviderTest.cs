using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Taaghche.UnitTest
{
    [TestClass]
    public class DataProviderTest
    {
        //Todo we need mock
        [TestMethod]
        public void NullInputApiTest()
        {
            var metadataService = new Services.BookMetadataApiProvider();
            var result = metadataService.Get(null);
            Assert.IsNull(result.Result);
        }
        [TestMethod]
        public void WithOutKeyInputApiTest()
        {
            var metadataService = new Services.BookMetadataApiProvider();
            var result = metadataService.Get(new Dictionary<string, object>() { ["IID"] = 10 });
            Assert.IsNull(result.Result);
        }
        [TestMethod]
        public void StringInputApiTest()
        {
            var metadataService = new Services.BookMetadataApiProvider();
            var result = metadataService.Get(new Dictionary<string, object>() { ["id"] = "salam" });
            Assert.IsNull(result.Result);
        }
        [TestMethod]
        public void BadInputApiTest()
        {
            var metadataService = new Services.BookMetadataApiProvider();
            var result = metadataService.Get(new Dictionary<string, object>() { ["id"] = 12404 });
            Assert.IsNull(result.Result);
        }

        [TestMethod]
        public void NullInputRedisTest()
        {
            var test = new Infrastructure.Redis.BookMetadataRedisStorage(new Infrastructure.Redis.RedisContext());
            var result = test.Get(null);
            Assert.IsNull(result.Result);
        }
        [TestMethod]
        public void WithOutKeyInputRedisTest()
        {
            var test = new Infrastructure.Redis.BookMetadataRedisStorage(new Infrastructure.Redis.RedisContext());
            var result = test.Get(new Dictionary<string, object>() { ["IID"] = 10 });
            Assert.IsNull(result.Result);
        }
        [TestMethod]
        public void StringInputRedisTest()
        {
            var test = new Infrastructure.Redis.BookMetadataRedisStorage(new Infrastructure.Redis.RedisContext());
            var result = test.Get(new Dictionary<string, object>() { ["id"] = "salam" });
            Assert.IsNull(result.Result);
        }

        [TestMethod]
        public void NullInputMemoryTest()
        {
            var metadataService = new Infrastructure.Memory.BookMetadataMemoryStorage(new Infrastructure.Memory.MemoryContext());
            var result = metadataService.Get(null);
            Assert.IsNull(result.Result);
        }
        [TestMethod]
        public void WithOutKeyInputMemoryTest()
        {
            var metadataService = new Infrastructure.Memory.BookMetadataMemoryStorage(new Infrastructure.Memory.MemoryContext());
            var result = metadataService.Get(new Dictionary<string, object>() { ["IID"] = 10 });
            Assert.IsNull(result.Result);
        }
        [TestMethod]
        public void StringInputMemoryTest()
        {
            var metadataService = new Infrastructure.Memory.BookMetadataMemoryStorage(new Infrastructure.Memory.MemoryContext());
            var result = metadataService.Get(new Dictionary<string, object>() { ["id"] = "salam" });
            Assert.IsNull(result.Result);
        }
    }
}
