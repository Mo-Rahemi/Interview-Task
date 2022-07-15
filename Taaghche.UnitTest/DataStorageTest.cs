using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Taaghche.UnitTest
{
    [TestClass]
    public class DataStorageTest
    {//Todo we need mock
        [TestMethod]
        public void NullInputMemoryTest()
        {
            var test = new Infrastructure.Memory.BookMetadataMemoryStorage(new Infrastructure.Memory.MemoryContext());
            var result = test.Add(null);
            Assert.IsFalse(result.Result);
        }
        [TestMethod]
        public void NullInputRedisTest()
        {
            var test = new Infrastructure.Redis.BookMetadataRedisStorage(new Infrastructure.Redis.RedisContext());
            var result = test.Add(null);
            Assert.IsFalse(result.Result);
        }
    }
}
