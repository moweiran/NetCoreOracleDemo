using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class CUSTOMER_INTEGRAL_DETAIL
    {
        public decimal CUSTOMER_INTEGRAL_DETAIL_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public string CUSTOMER_SHORTNAME { get; set; }
        public decimal INTEGRAL_TYPE { get; set; }
        public decimal INTEGRAL_SOURCE { get; set; }
        public decimal? REF_ID { get; set; }
        public decimal QTY { get; set; }
        public string REMARK { get; set; }
        public bool? VALID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public decimal? CREATE_COMPANY_ID { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
        public decimal FF_ID { get; set; }
    }
}
