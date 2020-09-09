using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_JURISDICTION_CITYS
    {
        public decimal FF_JURISDICTION_CITY_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal? COUNTRY_ID { get; set; }
        public decimal? PROVINCE_ID { get; set; }
        public decimal CITY_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
    }
}
