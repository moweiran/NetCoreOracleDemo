using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_ROLE_PERMISSION
    {
        public string BASE_ROLE_PERMISSION_ID { get; set; }
        public decimal BASE_ROLE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string PERMISSION_KEY { get; set; }
        public decimal PERMISSION { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
