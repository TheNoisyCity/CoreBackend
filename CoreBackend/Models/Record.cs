using System;
using System.Collections.Generic;

namespace CoreBackend.Models
{
    public partial class Record
    {
        public long Rid { get; set; }
        public long CreateUser { get; set; }
        public DateTimeOffset CreateTime { get; set; }
        public string Description { get; set; }
        public short Duration { get; set; }
        public double? UploadPositionX { get; set; }
        public double? UploadPositionY { get; set; }
        public sbyte Language { get; set; }
        public double? DialectX { get; set; }
        public double? DialectY { get; set; }
        public string FilePath { get; set; }
    }
}
