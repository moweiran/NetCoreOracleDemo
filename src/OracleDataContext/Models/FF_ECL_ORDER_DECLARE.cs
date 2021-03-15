using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_ECL_ORDER_DECLARE
    {
        public decimal FF_ECL_ORDER_DECLARE_ID { get; set; }
        public decimal FF_ECL_ORDER_ID { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string HSCODE { get; set; }
        public string CARGO_CNAME { get; set; }
        public string CARGO_ENAME { get; set; }
        public decimal? NET_WEIGHT { get; set; }
        public decimal? QTY { get; set; }
        public string CURRENCY { get; set; }
        public decimal? DECLARE_AMOUNT { get; set; }
        public string MATERIAL { get; set; }
        public string PURPOSE { get; set; }
        public string BRAND { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? PRICE { get; set; }
        public string SKU { get; set; }
    }
}
