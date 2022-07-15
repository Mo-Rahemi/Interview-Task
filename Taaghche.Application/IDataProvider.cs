using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Taaghche.Application
{
    public interface IDataProvider<T>
    {
        IDataProvider<T> Next { get; }
        void SetNext(IDataProvider<T> Next);
        Task<T> GetOrPass(Dictionary<string, object> Args);
        Task<T> Get(Dictionary<string, object> Args);
    }
}
