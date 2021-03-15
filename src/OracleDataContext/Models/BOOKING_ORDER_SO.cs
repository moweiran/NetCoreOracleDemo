using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BOOKING_ORDER_SO
    {
        public decimal BOOKING_ORDER_SO_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal BOOKING_ORDER_ID { get; set; }
        public decimal MAIN_BOOKING_ORDER_ID { get; set; }
        public string SONO { get; set; }
        public decimal? FF_FCL_SPACE_SO_ID { get; set; }
        public string YDW_CARRIERCODE { get; set; }
        public string YDW_POLCODE { get; set; }
        public decimal TRACK_STATUS { get; set; }
        public decimal TRACK_QTY { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
    }
}
