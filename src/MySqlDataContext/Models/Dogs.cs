using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.Models
{
    public partial class dogs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public bool? DeleteMark { get; set; }
    }
}
