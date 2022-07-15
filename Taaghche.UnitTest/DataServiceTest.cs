using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Taaghche.UnitTest
{
    [TestClass]
    public class DataServiceTest
    {//Todo we need mock
        [TestMethod]
        public void NullInputTest()
        {
            var metadataService = new Services.BookMetadataService();
            var result = metadataService.Get(null);
            Assert.IsNull(result.Result);
        }
        [TestMethod]
        public void WithOutKeyInputTest()
        {
            var metadataService = new Services.BookMetadataService();
            var result = metadataService.Get(new Dictionary<string, object>() { ["IID"] = 10 });
            Assert.IsNull(result.Result);
        }
        [TestMethod]
        public void StringInputTest()
        {
            var metadataService = new Services.BookMetadataService();
            var result = metadataService.Get(new Dictionary<string, object>() { ["id"] = "salam" });
            Assert.IsNull(result.Result);
        }
    }
}
