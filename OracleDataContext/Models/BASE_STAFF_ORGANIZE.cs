using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_STAFF_ORGANIZE
    {
        public decimal STAFF_ORGANIZE_ID { get; set; }
        public decimal? ORGANIZATION_ID { get; set; }
        public decimal? USER_ID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
