using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_ROLE
    {
        public decimal BASE_ROLE_ID { get; set; }
        public string ROLENAMECN { get; set; }
        public string ROLENAMEEN { get; set; }
        public decimal FF_ID { get; set; }
        public bool? USE_DEFAULT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
