using System;
using System.Collections.Generic;

namespace IO_Ders_3___Template.Models
{
    public partial class aspnet_PersonalizationAllUsers
    {
        public System.Guid PathId { get; set; }
        public byte[] PageSettings { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public virtual aspnet_Paths aspnet_Paths { get; set; }
    }
}