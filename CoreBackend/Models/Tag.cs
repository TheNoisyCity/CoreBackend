using System;
using System.Collections.Generic;

namespace CoreBackend.Models
{
    public partial class Tag
    {
        public long TagId { get; set; }
        public long Uid { get; set; }
        public sbyte TagType { get; set; }
        public string Value { get; set; }
    }
}
