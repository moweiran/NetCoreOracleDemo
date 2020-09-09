using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class MV_PAY_SUPPLIER
    {
        public string FF_PAY_INFO_ID { get; set; }
        public decimal? PAY_TYPE { get; set; }
        public DateTime? PAY_DATE { get; set; }
        public string FF_PAY_DETAIL_ID { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public decimal ORDER_ID { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal? AMOUNT_BILL { get; set; }
        public decimal? AMOUNT_SUBSIDY { get; set; }
        public string ORDER_NO { get; set; }
        public decimal SUPPLIER_ID { get; set; }
        public string SUPPLIER_NAME_CN { get; set; }
        public string SUPPLIER_NAME_EN { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public string CUSTOMER_NAME_CN { get; set; }
        public string CUSTOMER_NAME_EN { get; set; }
        public decimal? BASE_PAY_SUPPLIER_ID { get; set; }
        public decimal? PAY_SUPPLIER_AMOUNT { get; set; }
        public decimal? PAY_SUPPLIER_STATUS { get; set; }
        public DateTime? PAY_SUPPLIER_DATE { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime? MODIFY_DATETIME { get; set; }
        public decimal? COMMISSION_RATE { get; set; }
        public decimal? COMMISSION_AMOUNT { get; set; }
    }
}
