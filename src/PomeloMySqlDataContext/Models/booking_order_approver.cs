using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class booking_order_approver
    {
        public long BOOKING_ORDER_APPROVER_ID { get; set; }
        public long BOOKING_ORDER_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long? PU_ID { get; set; }
        public string PU_NAME { get; set; }
        public long? PR_ID { get; set; }
        public string PR_NAME { get; set; }
        public string PAY_LOCATION { get; set; }
        public string SPECIAL_LOAD { get; set; }
        public string SPECIAL_REMARK { get; set; }
        public long? FIRST_SCHEDULE_ID { get; set; }
        public string FIRST_VESSEL_NAME { get; set; }
        public string FIRST_VOYAGE { get; set; }
        public int? TEU { get; set; }
        public int? OW_TEU { get; set; }
        public int? STATUS { get; set; }
        public long APPROVER_ID { get; set; }
        public string APPROVER_NAME { get; set; }
        public DateTime APPROVED_DATE { get; set; }
        public string APPROVED_DESC { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
