using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class booking_order_surcharge
    {
        public long BOOKING_ORDER_SURCHARGE_ID { get; set; }
        public long BOOKING_ORDER_ID { get; set; }
        public long BOOKING_ORDER_RATE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long FF_BOOKING_SURCHARGE_ID { get; set; }
        public long FEETYPE_ID { get; set; }
        public short UNIT { get; set; }
        public string CONTA_SIZETYPE_CODE { get; set; }
        public decimal COST { get; set; }
        public decimal PRICE { get; set; }
        public int QTY { get; set; }
        public decimal AMOUNT { get; set; }
        public string CURRENCY { get; set; }
        public string REMARK { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
    }
}
