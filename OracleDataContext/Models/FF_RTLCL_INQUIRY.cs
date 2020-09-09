using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_RTLCL_INQUIRY
    {
        public decimal FF_RTLCL_INQUIRY_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string INQUIRY_NO { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal CARGO_TYPE { get; set; }
        public decimal START_CITY_ID { get; set; }
        public decimal DEST_CITY_ID { get; set; }
        public DateTime? PLAN_DATE { get; set; }
        public decimal? CARGO_WEIGHT { get; set; }
        public decimal? CARGO_VOLUME { get; set; }
        public string CARGO_DESC { get; set; }
        public decimal STATUS { get; set; }
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
