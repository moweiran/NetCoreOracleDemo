using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_ROLE_PERMISSION_GROUP
    {
        public string ROLE_PERMISSION_GROUP_ID { get; set; }
        public decimal? ROLE_ID { get; set; }
        public string PERMISSION_GROUP_ID { get; set; }
        public decimal? PERMISSION { get; set; }
        public decimal? FF_ID { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
