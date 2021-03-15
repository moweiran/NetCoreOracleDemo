using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_ECL_ZONE_COUNTRY
    {
        public decimal FF_ECL_ZONE_COUNTRY_ID { get; set; }
        public decimal FF_ECL_ZONE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal BASE_COUNTRY_ID { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
