using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class presale_order_cancel
    {
        public long PRESALE_ORDER_CANCEL_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long FF_ID { get; set; }
        public long PRESALE_ORDER_ID { get; set; }
        public long MAIN_ORDER_ID { get; set; }
        public int CANCEL_TEU { get; set; }
        public int OW_CANCEL_TEU { get; set; }
        public int DATE_TYPE { get; set; }
        public string CURRENCY { get; set; }
        public decimal? PRICE { get; set; }
        public decimal? AMOUNT { get; set; }
        public int STATUS { get; set; }
        public long? APPLY_ID { get; set; }
        public string APPLY_NAME { get; set; }
        public DateTime? APPLY_DATE { get; set; }
        public string APPLY_REMARK { get; set; }
        public long? CHECK_ID { get; set; }
        public string CHECK_NAME { get; set; }
        public DateTime? CHECK_DATE { get; set; }
        public string CHECK_REMARK { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
