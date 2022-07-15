using System;
using System.Collections.Generic;
using System.Text;

namespace Taaghche.Core
{
    public class RelatedBook
    {
        public int Type { get; set; }
        public string Title { get; set; }
        public int BackgroundStyle { get; set; }
        public BookData BookData { get; set; }
    }
}
