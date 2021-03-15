using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_RTLCL_ORDER_DESTFEE
    {
        public decimal FF_RTLCL_ORDER_DESTFEE_ID { get; set; }
        public decimal FF_RTLCL_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FEETYPE_ID { get; set; }
        public decimal CHARGE_TYPE { get; set; }
        public decimal REF_ID { get; set; }
        public decimal UNIT { get; set; }
        public decimal? PRICE { get; set; }
        public decimal? AMOUNT { get; set; }
        public decimal QTY { get; set; }
        public string CURRENCY { get; set; }
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
