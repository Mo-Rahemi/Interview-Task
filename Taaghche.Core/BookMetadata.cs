using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Taaghche.Core
{
    public class BookMetadata : BaseEntity
    {
        [Key]
        public int Id { get; set; } = 0;
        public Book Book { get; set; }
        public List<Comment> Comments { get; set; }
        public int CommentsCount { get; set; }
        public List<RelatedBook> RelatedBooks { get; set; }
        public string ShareText { get; set; }
        public List<Quote> Quotes { get; set; }
        public int QuotesCount { get; set; }
        public bool HideOffCoupon { get; set; }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
        public static ValueTask<BookMetadata> FromJson(string Json)
        {

            using (var stream = new MemoryStream())
            using (var writer = new StreamWriter(stream))
            {
                writer.Write(Json);
                writer.Flush();
                stream.Position = 0;

                return JsonSerializer.DeserializeAsync<BookMetadata>(stream,
         new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }


        }
        public override string AsJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
