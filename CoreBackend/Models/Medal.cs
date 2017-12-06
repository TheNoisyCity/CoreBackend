using System;
using System.Collections.Generic;

namespace CoreBackend.Models
{
    public partial class Medal
    {
        public long MedalId { get; set; }
        public long Uid { get; set; }
        public string Title { get; set; }
        public DateTimeOffset AwardTime { get; set; }
        public string Description { get; set; }
    }
}
