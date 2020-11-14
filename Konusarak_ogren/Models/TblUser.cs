using System;
using System.Collections.Generic;

#nullable disable

namespace Konusarak_ogren.Models
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? Role { get; set; }
        public bool? Status { get; set; }
    }
}
