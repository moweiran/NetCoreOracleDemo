using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_ORDER_SUBSIDY
    {
        public decimal FF_ORDER_SUBSIDY_ID { get; set; }
        public decimal FF_ORDER_SUBSIDY_APPLY_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal SUPPLIER_ID { get; set; }
        public decimal ORDER_TYPE { get; set; }
        public decimal ORDER_ID { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
        public string ORDER_NO { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public DateTime? BOOKING_DATE { get; set; }
        public decimal SUBSIDY_AMOUNT { get; set; }
        public string CURRENCY { get; set; }
        public decimal? CHECK_USERID { get; set; }
        public string CHECK_FULLNAME { get; set; }
        public DateTime? CHECK_DATE { get; set; }
        public string CHECK_REMARK { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? SUBSIDY_GP20 { get; set; }
        public decimal? SUBSIDY_GP40 { get; set; }
        public decimal? SUBSIDY_HQ40 { get; set; }
        public decimal? SUBSIDY_GP45 { get; set; }
        public decimal? SUBSIDY_TEU { get; set; }
        public decimal? USE_TEU { get; set; }
        public decimal? RATE_ID { get; set; }
    }
}
