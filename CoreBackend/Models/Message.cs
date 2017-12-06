using System;
using System.Collections.Generic;

namespace CoreBackend.Models
{
    public partial class Message
    {
        public long Mid { get; set; }
        public long SenderId { get; set; }
        public long ReceiverId { get; set; }
        public DateTimeOffset CreateTime { get; set; }
        public sbyte IsRead { get; set; }
        public sbyte Type { get; set; }
        public string Content { get; set; }
        public string FilePath { get; set; }
    }
}
