using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_RTLCL_RATE
    {
        public decimal FF_RTLCL_RATE_ID { get; set; }
        public decimal PARENT_RTLCL_RATE_ID { get; set; }
        public decimal FF_RTLCL_RATE_LIST_ID { get; set; }
        public decimal FF_RTLCL_PRODUCT_ID { get; set; }
        public decimal MAIN_RTLCL_RATE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal RATE_SOURCE { get; set; }
        public decimal SUPPLIER_ID { get; set; }
        public decimal TOP_SUPPLIER_ID { get; set; }
        public decimal START_CITY_ID { get; set; }
        public decimal DEST_CITY_ID { get; set; }
        public decimal? MIN_SALE { get; set; }
        public string CURRENCY { get; set; }
        public DateTime? EFFECTIVE_DATE { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
