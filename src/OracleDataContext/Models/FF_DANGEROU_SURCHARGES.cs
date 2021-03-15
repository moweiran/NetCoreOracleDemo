using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_DANGEROU_SURCHARGES
    {
        public decimal FF_DANGEROU_SURCHARGE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public decimal SHIP_SURCHARGE_ID { get; set; }
        public decimal? GP20_ADD { get; set; }
        public decimal? GP40_ADD { get; set; }
        public decimal? HQ40_ADD { get; set; }
        public decimal? GP45_ADD { get; set; }
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
        public DateTime CREATE_DATE_TIME { get; set; }
        public decimal FF_FCLSURCHARGE_DGLEVELL_ID { get; set; }
    }
}
