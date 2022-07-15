using Taaghche.Core;
using Taaghche.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiteDB;

namespace Taaghche.Infrastructure.LiteDB
{
    public class BookLiteDBStorage : DataProvider<BookMetadata>, IDataStorage<BookMetadata>
    {
        public BookLiteDBStorage()
        {
            throw new NotImplementedException();
        }
        public Task<bool> Add(BookMetadata Entity)
        {
            return Task.Run(() =>
            {
                using (var db = new LiteDatabase("Filename=litedb.db;Connection=shared"))
                {
                    db.GetCollection<BookMetadata>("BookMetadata").Insert(Entity);
                }
                return true;
            });
        }
        public Task<BookMetadata> Get(int Id)
        {
            return Task.Run(() =>
              {
                  using (var db = new LiteDatabase("Filename=litedb.db;ReadOnly=true"))
                  {
                      var meta = db.GetCollection<BookMetadata>();
                      meta.EnsureIndex(x => x.Id);
                      return db.GetCollection<BookMetadata>().FindOne(x => x.Id == Id);
                  }
              });
        }
        public override Task<BookMetadata> Get(Dictionary<string, object> Args)
        {
            return Get((int)Args["id"]);
        }
    }
}
