using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BOOKING_ORDER_OTHER
    {
        public decimal BOOKING_ORDER_OTHER_ID { get; set; }
        public decimal BOOKING_ORDER_ID { get; set; }
        public bool? OUT_TRUCK { get; set; }
        public bool? OUT_CUSTOMS { get; set; }
        public bool? OUT_VGM { get; set; }
        public bool? OUT_FUMIGATION { get; set; }
        public bool? OUT_INSPECTION { get; set; }
        public bool? OUT_INSURANCE { get; set; }
        public bool? OUT_AMS { get; set; }
        public bool? IN_TRUCK { get; set; }
        public bool? IN_CUSTOMS { get; set; }
        public decimal? OUTTRUCK_TRAILER_ID { get; set; }
        public decimal? OUTTRUCK_FF_ID { get; set; }
        public decimal? OUTTRUCK_PRICE_DETAIL_ID { get; set; }
        public decimal? OUTTRUCK_TRAILER_ORDER_ID { get; set; }
        public decimal? OUTTRUCK_LOCATION_ID { get; set; }
        public string OUTTRUCK_ADDRESS { get; set; }
        public string OUTTRUCK_CONTACTS { get; set; }
        public string OUTTRUCK_TEL { get; set; }
        public DateTime? OUTTRUCK_DATE { get; set; }
        public decimal? INTRUCK_TRAILER_ID { get; set; }
        public decimal? INTRUACK_FF_ID { get; set; }
        public decimal? INTRUCK_PRICE_DETAIL_ID { get; set; }
        public decimal? INTRUCK_LOCATION_ID { get; set; }
        public string INTRUCK_ADDRESS { get; set; }
        public string INTRUCK_CONTACTS { get; set; }
        public string INTRUCK_TEL { get; set; }
        public DateTime? INTRUCK_DATE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public bool? OUT_ISF { get; set; }
        public bool? OUT_VAT { get; set; }
        public bool? OUT_PERMIT { get; set; }
        public bool? OUT_PURCHASE { get; set; }
        public bool? IN_INSPECTION { get; set; }
        public bool? IN_TAX { get; set; }
        public decimal? OUTTRUCK_CITY_ID { get; set; }
        public decimal? INTRUCK_CITY_ID { get; set; }

        public virtual BOOKING_ORDER BOOKING_ORDER_ { get; set; }
    }
}
