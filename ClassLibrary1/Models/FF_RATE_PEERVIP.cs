using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_RATE_PEERVIP
    {
        public decimal FF_RATE_PEERVIP_ID { get; set; }
        public decimal FF_RATE_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal CUSTOMER_COMPNAY_ID { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
        public decimal? GP45 { get; set; }
        public DateTime RATE_UPDATEDATE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
