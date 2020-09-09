using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_RTFCL_PRODUCT_SUPPLIER
    {
        public decimal FF_RTFCL_PRODUCT_SUPPLIER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_RTFCL_PRODUCT_ID { get; set; }
        public decimal SUPPLIER_ID { get; set; }
        public decimal? SALES_GP20_ADD { get; set; }
        public decimal? SALES_GP40_ADD { get; set; }
        public decimal? SALES_HQ40_ADD { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
    }
}
