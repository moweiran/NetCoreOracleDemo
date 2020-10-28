using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class rate_main_list
    {
        public long RATE_MAIN_LIST_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long CARRIER_COMPANY_ID { get; set; }
        public long ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public long WEEK_ID { get; set; }
        public long POL_ID { get; set; }
        public long SCHEDULE_ID { get; set; }
        public long SCHEDULE_PORT_ID { get; set; }
        public string VESSEL_NAME { get; set; }
        public string VOYAGE { get; set; }
        public DateTime ETD { get; set; }
        public int? TOTAL_TEU { get; set; }
        public int? COMPANY_TEU { get; set; }
        public int? CONFIRM_COMPANY_TEU { get; set; }
        public int? PORT_TEU { get; set; }
        public int? CONFIRM_PORT_TEU { get; set; }
        public int? PREBRANCH_TEU { get; set; }
        public int? CONFIRM_PREBRANCH_TEU { get; set; }
        public int? OW_TEU { get; set; }
        public int? CONFIRM_OW_TEU { get; set; }
        public int? PRESALE_TEU { get; set; }
        public int? BOOKING_TEU { get; set; }
        public int? CONFIRM_TEU { get; set; }
        public bool IS_AUTO_RELEASE { get; set; }
        public int RATE_QTY { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public int STATUS { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public int? BOOKING_QTY { get; set; }
        public int? CONFIRM_PRESALE_TEU { get; set; }
    }
}
