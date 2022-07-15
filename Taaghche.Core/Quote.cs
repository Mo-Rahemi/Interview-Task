using System;
using System.Collections.Generic;
using System.Text;

namespace Taaghche.Core
{
    public class Quote
    {
        public string Id { get; set; }
        public QuoteData Data { get; set; }
        public int LikeCount { get; set; }
        public int BookId { get; set; }
        public int AccountId { get; set; }
        public int CommentCount { get; set; }
        public DateTime Date { get; set; }
        public string Nickname { get; set; }
    }
}
