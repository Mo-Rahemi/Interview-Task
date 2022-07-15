using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Taaghche.Core
{
    public class Comment 
    {
        [Key]
        public int Id { get; set; } = 0;
        [Required]
        public int AccountId { get; set; } = 0;
        public bool VerifiedAccount { get; set; } = false;
        public string Nickname { get; set; } = "";
        [JsonPropertyName("Comment")]
        public string CommentText { get; set; } = "";
    }
}
