using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BOOKING_ORDER_BL_CONTAINER
    {
        public decimal BOOKING_ORDER_BL_CONTAINER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal BOOKING_ORDER_BL_ID { get; set; }
        public decimal BOOKING_ORDER_CONTAINER_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
