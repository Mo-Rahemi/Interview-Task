using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Taaghche.Application
{
    public interface IDataStorage<T>
    {
        Task<bool> Add(T Entity);
        Task<T> Get(int Id);
    }
}
