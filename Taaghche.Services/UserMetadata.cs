using System;
using System.Collections.Generic;
using System.Text;
using Taaghche.Application;
using Taaghche.Core;

namespace Taaghche.Services
{
    public class UserMetadata : IDataService<BookMetadata>
    {
        public IReadOnlyCollection<DataProvider<BookMetadata>> DataProviders => throw new NotImplementedException();

        public void AddDataProvider<F>(F Provider) where F : DataProvider<BookMetadata>
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<BookMetadata> Get(Dictionary<string, object> Args)
        {
            throw new NotImplementedException();
        }
    }
}
