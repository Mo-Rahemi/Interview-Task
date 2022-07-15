using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Taaghche.Core;

namespace Taaghche.Application
{
    public abstract class DataProvider<T> : IDataProvider<T>
    {
        public IDataProvider<T> Next { get; private set; }

        public async Task<T> GetOrPass(Dictionary<string, object> Args)
        {
            var result = await Get(Args);
            if (result == null && Next != null)
            {
                result = await Next.GetOrPass(Args);
                if (result != null && this is IDataStorage<T> DataStorage)
                {
                    _ = DataStorage.Add(result);
                }
            }
            return result;
        }
        public abstract Task<T> Get(Dictionary<string, object> Args);
        public void SetNext(IDataProvider<T> Next)
        {
            this.Next = Next;
        }
    }
}
