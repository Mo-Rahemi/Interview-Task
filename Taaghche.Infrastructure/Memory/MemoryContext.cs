using Taaghche.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Collections.Concurrent;

namespace Taaghche.Infrastructure.Memory
{
    public class MemoryContext
    {
        public ConcurrentDictionary<int, BookMetadata> BooksMetadata { get; set; } = new ConcurrentDictionary<int, BookMetadata>();
    }
}
