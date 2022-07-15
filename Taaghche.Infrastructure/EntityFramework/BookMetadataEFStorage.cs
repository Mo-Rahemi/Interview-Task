using Taaghche.Core;
using Taaghche.Application;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;

namespace Taaghche.Infrastructure.EntityFramework
{
    public class BookMetadataEFStorage : DataProvider<BookMetadata>, IDataStorage<BookMetadata>
    {
        public BookMetadataEFStorage(EFContext EFContext)
        {
            throw new NotImplementedException();
            _eFContext = EFContext;
        }
        public async Task<bool> Add(BookMetadata Entity)
        {
            _eFContext.BooksMetadata.Add(Entity);
            await _eFContext.SaveChangesAsync();
            return true;
        }
        public Task<BookMetadata> Get(int Id)
        {
            return _eFContext.BooksMetadata.SingleOrDefaultAsync(x => x.Id == Id);
        }
        public override Task<BookMetadata> Get(Dictionary<string, object> Args)
        {
            return Get((int)Args["id"]);
        }

        private readonly EFContext _eFContext;
    }
}
