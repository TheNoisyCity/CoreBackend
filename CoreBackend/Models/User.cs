using System;
using System.Collections.Generic;

namespace CoreBackend.Models
{
    public partial class User
    {
        public long Uid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public sbyte EmailConfirmed { get; set; }
        public string Phone { get; set; }
        public sbyte PhoneConfirmed { get; set; }
        public string Bio { get; set; }
        public string AvatarPath { get; set; }
        public DateTimeOffset CreateTime { get; set; }
        public DateTimeOffset LastTimeUsernameChanged { get; set; }
        public sbyte LanguageFirst { get; set; }
        public sbyte LanguageSecond { get; set; }
        public double? DialectFirstX { get; set; }
        public double? DialectFirstY { get; set; }
        public double? DialectSecondX { get; set; }
        public double? DialectSecondY { get; set; }
    }
}
