using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_OVERSEA_AGENCYS
    {
        public decimal OVERSEA_AGENCY_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal AGENCY_ID { get; set; }
        public decimal? COUNTRY_ID { get; set; }
        public decimal CITY_ID { get; set; }
        public string CONTACTS { get; set; }
        public string CONTACT_PHONE { get; set; }
        public string EMAIL { get; set; }
        public string FAX { get; set; }
        public string POSTCODE { get; set; }
        public string ADDRESS { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public decimal? CREATE_COMPANY_ID { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
        public bool? IS_FIRST_SELECT { get; set; }
    }
}
