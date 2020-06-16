using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_ORDER_PROFIT_DETAIL
    {
        public decimal ORDER_PROFIT_DETAIL_ID { get; set; }
        public decimal FF_ORDER_PROFIT_ID { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public decimal ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string CURRENCY { get; set; }
        public decimal PROFIT_AMOUNT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? BILL_LIST_ID { get; set; }

        public virtual FF_ORDER_PROFIT FF_ORDER_PROFIT_ { get; set; }
    }
}
