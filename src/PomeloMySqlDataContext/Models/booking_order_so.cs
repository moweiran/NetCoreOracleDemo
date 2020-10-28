using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
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
        public DateTime CREATE_DATETIME { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
    }
}
