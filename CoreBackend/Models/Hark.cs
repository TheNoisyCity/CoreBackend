using System;
using System.Collections.Generic;

namespace CoreBackend.Models
{
    public partial class Hark
    {
        public long ListenerId { get; set; }
        public long ListeneeId { get; set; }
        public long Rid { get; set; }
        public int Duration { get; set; }
    }
}
