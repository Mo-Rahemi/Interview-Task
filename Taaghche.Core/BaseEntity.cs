using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Taaghche.Core
{
    public abstract class BaseEntity
    {
        public DateTime Created { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = "";
        public DateTime? LastModified { get; set; } = null;
        public string LastModifiedBy { get; set; } = "";
        public abstract bool Validate();
        public abstract string AsJson();
    }
}
