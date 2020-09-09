using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_AGENCYCHARGE_OVERSEAAGENCY
    {
        public decimal AGENCYCHARGE_OVERSEAAGENCY_ID { get; set; }
        public decimal? AGENCY_CHARGES_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal OVERSEA_AGENCY_ID { get; set; }
        public decimal? BOOKING_SALE { get; set; }
        public decimal? GP20_SALE { get; set; }
        public decimal? GP40_SALE { get; set; }
        public decimal? HQ40_SALE { get; set; }
        public decimal? GP45_SALE { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CONFIRM_USERID { get; set; }
        public string CONFIRM_FULLNAME { get; set; }
        public DateTime? CONFIRM_DATE { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
    }
}
