using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_LCL_ORDER_BOOKING
    {
        public decimal FF_LCL_ORDER_BOOKING_ID { get; set; }
        public decimal LCL_ORDER_ID { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
        public decimal? CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal? ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public string VESSEL_VOYAGE { get; set; }
        public decimal? TT { get; set; }
        public DateTime? CLOSE_DT { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ETA { get; set; }
        public string MBL_NO { get; set; }
        public string CONTAINER_NO { get; set; }
        public decimal? CONFIRM_WEIGHT { get; set; }
        public decimal? CONFIRM_CBM { get; set; }
        public decimal? CONFIRM_CHARGE_MAINCBM { get; set; }
        public decimal? CONFIRM_CHARGE_PRECBM { get; set; }
        public decimal? CONFIRM_CHARGE_AFTERCBM { get; set; }
        public decimal? CONFIRM_USERID { get; set; }
        public string CONFIRM_FULLNAME { get; set; }
        public DateTime? CONFIRM_DATE { get; set; }
        public string CONFIRM_REMARK { get; set; }
        public decimal TRACK_STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public string CONTAINER_SIZETYPE { get; set; }
        public string MAINLINE_ORDER_ID { get; set; }
        public string MAINLINE_ORDER_NO { get; set; }
    }
}
