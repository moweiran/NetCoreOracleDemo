using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BOOKING_ORDER_PRESALE
    {
        public decimal BOOKING_ORDER_PRESALE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal BOOKING_ORDER_ID { get; set; }
        public decimal PRESALE_ORDER_ID { get; set; }
        public decimal OR_TEU { get; set; }
        public decimal OW_TEU { get; set; }
        public decimal USE_OR_TEU { get; set; }
        public decimal USE_OW_TEU { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
    }
}
