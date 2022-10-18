using System;
using System.Collections.Generic;

namespace DOTNET_ANGULAR_API.Models
{
    public partial class Register
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Useremail { get; set; }
        public string? Password { get; set; }
        public string? Mobile { get; set; }
    }
}
