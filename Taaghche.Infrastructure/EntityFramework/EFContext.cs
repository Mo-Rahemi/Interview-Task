using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Taaghche.Infrastructure.EntityFramework
{
    public class EFContext : DbContext
    {
        public DbSet<Core.BookMetadata> BooksMetadata { get; set; }

        public EFContext()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
