using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_CARRIERDATA_LACK
    {
        public decimal CARRIERDATA_LACK_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal DATE_TYPE { get; set; }
        public string CARRIER_CODE { get; set; }
        public string ROUTE_CODE { get; set; }
        public decimal STATUS { get; set; }
        public string REMARK { get; set; }
        public string CREATE_EMAIL { get; set; }
        public string FILE_IDS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public decimal? CREATE_COMPANY_ID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
