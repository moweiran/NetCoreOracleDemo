using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_LCLMAIN_PRODUCT_SCHEDULE
    {
        public decimal FF_LCLMAIN_PRODUCT_SCHEDULE_ID { get; set; }
        public decimal FF_LCLMAIN_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal? CLOSE_CFS { get; set; }
        public decimal CLOSING { get; set; }
        public decimal DEPARTURE { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? TT { get; set; }
    }
}
