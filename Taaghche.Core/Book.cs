using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Taaghche.Core
{
    public class Book
    {
        [Key]
        public int Id { get; set; } = 0;
        [Required]
        public string Title { get; set; } = "";
        public int SourceBookId { get; set; } = 0;
        public int CanonicalId { get; set; } = 0;
        public string Description { get; set; } = "";
        public string HtmlDescription { get; set; } = "";
        public string JsonDescription { get; set; } = "";
        public string Faqs { get; set; }
        public int PublisherID { get; set; } = 0;
        public string PublisherSlug { get; set; } = "";
        public float Price { get; set; } = 0;
        public int NumberOfPages { get; set; } = 0;
        public float Rating { get; set; } = 0;
        public List<Rate> Rates { get; set; }
        public List<RateDetail> RateDetails { get; set; }
        public string Sticker { get; set; }
        public bool HasTemporaryOff { get; set; }
        public float BeforeOffPrice { get; set; }
        public string OffText { get; set; }
        public string PriceColor { get; set; }
        public bool IsRtl { get; set; }
        public bool ShowOverlay { get; set; }
        public float PhysicalPrice { get; set; }
        public string ISBNISBN { get; set; }
        public string PublishDate { get; set; }
        public int Destination { get; set; }
        public string Type { get; set; }
        public string RefId { get; set; }
        public string CoverUri { get; set; }
        public string ShareUri { get; set; }
        public string ShareText { get; set; }
        public string Publisher { get; set; }
        public List<Author> Authors { get; set; }

    }
}