using System;
using System.Collections.Generic;

namespace CoreBackend.Models
{
    public partial class Comment
    {
        public long Cid { get; set; }
        public long Rid { get; set; }
        public long CommenterUser { get; set; }
        public long ReplyToUser { get; set; }
        public long ReplyToComment { get; set; }
        public DateTimeOffset CreateTime { get; set; }
    }
}
