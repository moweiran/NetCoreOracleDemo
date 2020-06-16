using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_AIR_ORDER_BOOKING
    {
        public decimal FF_AIR_ORDER_BOOKING_ID { get; set; }
        public decimal? AIR_ORDER_ID { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
        public decimal AIRLINE_ID { get; set; }
        public string FLIGHT_NO { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ETA { get; set; }
        public string MAWB_NO { get; set; }
        public decimal? CONFIRM_WEIGHT { get; set; }
        public decimal? CONFIRM_CBM { get; set; }
        public decimal? CONFIRM_CHARGE_WEIGHT { get; set; }
        public decimal? CONFIRM_USERID { get; set; }
        public string CONFIRM_FULLNAME { get; set; }
        public DateTime? CONFIRM_DATE { get; set; }
        public string CONFIRM_REMARK { get; set; }
        public decimal TRACK_STATUS { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }

        public virtual FF_AIR_ORDER AIR_ORDER_ { get; set; }
    }
}
