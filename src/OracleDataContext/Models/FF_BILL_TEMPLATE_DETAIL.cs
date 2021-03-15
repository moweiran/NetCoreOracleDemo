using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_BILL_TEMPLATE_DETAIL
    {
        public decimal FF_BILL_TEMPLATE_DETAIL_ID { get; set; }
        public decimal FF_BILL_TEMPLATE_ID { get; set; }
        public decimal FEETYPE_ID { get; set; }
        public decimal PRICE { get; set; }
        public decimal QTY { get; set; }
        public string CURRENCY { get; set; }
        public string PAYMENT_CURRENCY { get; set; }
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
