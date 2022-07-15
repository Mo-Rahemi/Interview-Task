using System;
using System.Collections.Generic;
using System.Text;

namespace Taaghche.Core
{
    public class QuoteData
    {
        public string Quote { get; set; }
        public int StartAtomId { get; set; }
        public int EndAtomId { get; set; }
        public int ChapterIndex { get; set; }
        public int EndOffset { get; set; }
        public int StartOffset { get; set; }
    }
}
