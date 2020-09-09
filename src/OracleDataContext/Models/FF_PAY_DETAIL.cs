using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_PAY_DETAIL
    {
        public string FF_PAY_DETAIL_ID { get; set; }
        public string FF_PAY_INFO_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? SUPPLIER_ID { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public decimal ORDER_ID { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
        public string ORDER_NO { get; set; }
        public string BILL_LIST_ID { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal? AMOUNT_BILL { get; set; }
        public decimal? AMOUNT_INSURANCE { get; set; }
        public decimal? AMOUNT_LOAN { get; set; }
        public decimal? AMOUNT_INTEREST { get; set; }
        public decimal? AMOUNT_SERVICEFEE { get; set; }
        public decimal? RATE_COMMISSION { get; set; }
        public decimal? AMOUNT_SUBSIDY { get; set; }
        public decimal? MODE_TYPE { get; set; }
        public string SOURCE_COUNTRY { get; set; }
        public string SOURCE_CURRENCY { get; set; }
        public decimal? SOURCE_AMOUNT { get; set; }
        public string DESTINATION_COUNTRY { get; set; }
        public string DESTINATION_CURRENCY { get; set; }
        public decimal? DESTINATION_AMOUNT { get; set; }
        public decimal? FXRATE { get; set; }
    }
}
