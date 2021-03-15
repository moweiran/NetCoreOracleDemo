using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class booking_order_so
    {
        public long BOOKING_ORDER_SO_ID { get; set; }
        public long BOOKING_ORDER_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public string SONO { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
    }
}
