using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class presale_order_change
    {
        public long PRESALE_ORDER_CHANGE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long FF_ID { get; set; }
        public long PRESALE_ORDER_ID { get; set; }
        public long MAIN_ORDER_ID { get; set; }
        public long WEEK_ID { get; set; }
        public long NEW_PRESALE_ORDER_ID { get; set; }
        public long NEW_WEEK_ID { get; set; }
        public int CHANGE_TEU { get; set; }
        public int OW_CHANGE_TEU { get; set; }
        public int STATUS { get; set; }
        public bool IS_FREE { get; set; }
        public string CURRENCY { get; set; }
        public decimal? PRICE { get; set; }
        public decimal? AMOUNT { get; set; }
        public long? APPLY_ID { get; set; }
        public string APPLY_NAME { get; set; }
        public string APPLY_REMARK { get; set; }
        public long? CHECK_ID { get; set; }
        public string CHECK_NAME { get; set; }
        public string CHECK_REMARK { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
    }
}
