using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class SHIPINFO
    {
        public decimal SHIPINFO_ID { get; set; }
        public decimal? VESSEL_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public string CARRIER_NAME { get; set; }
        public string CARRIER_SHORT_NAME { get; set; }
        public string SHIP_CODE { get; set; }
        public string SHIP_NAME_CN { get; set; }
        public string SHIP_NAME_EN { get; set; }
        public string SHIP_OWNER { get; set; }
        public string CALLSIGN { get; set; }
        public string IMO_CODE { get; set; }
        public decimal? SHIP_TYPE { get; set; }
        public decimal? TEUS { get; set; }
        public decimal? TEU_ONDESK { get; set; }
        public decimal? TEU_INCABIN { get; set; }
        public string TEN_CARGO { get; set; }
        public bool? VALID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
