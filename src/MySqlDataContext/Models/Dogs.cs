using System;
using System.Collections.Generic;

namespace MySqlDataContext.Models
{
    public partial class Dogs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
    }
}
