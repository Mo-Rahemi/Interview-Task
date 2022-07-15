using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Taaghche.Application
{
    public interface IDataService<T>
    {
        public IReadOnlyCollection<DataProvider<T>> DataProviders { get; }

        Task<T> Get(Dictionary<string, object> Args);
        void AddDataProvider<F>(F Provider) where F : DataProvider<T>;
    }
}
