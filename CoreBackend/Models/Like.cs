using System;
using System.Collections.Generic;

namespace CoreBackend.Models
{
    public partial class Like
    {
        public long Rid { get; set; }
        public long Uid { get; set; }
        public DateTimeOffset CreateTime { get; set; }
    }
}
