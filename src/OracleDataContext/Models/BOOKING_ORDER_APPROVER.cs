using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BOOKING_ORDER_APPROVER
    {
        public decimal BOOKING_ORDER_APPROVER_ID { get; set; }
        public decimal MAIN_BOOKING_ORDER_ID { get; set; }
        public decimal BOOKING_ORDER_ID { get; set; }
        public string BOOKING_NO { get; set; }
        public decimal? PU_ID { get; set; }
        public string PU_NAME { get; set; }
        public decimal? PR_ID { get; set; }
        public string PR_NAME { get; set; }
        public string PAY_LOCATION { get; set; }
        public string SPECIAL_LOAD { get; set; }
        public string SPECIAL_REMARK { get; set; }
        public decimal? FIRST_SCHEDULE_ID { get; set; }
        public string FIRST_VESSEL_NAME { get; set; }
        public string FIRST_VOYAGE { get; set; }
        public decimal? STATUS { get; set; }
        public decimal APPROVER_ID { get; set; }
        public string APPROVER_NAME { get; set; }
        public DateTime APPROVED_DATE { get; set; }
        public string APPROVED_DESC { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
