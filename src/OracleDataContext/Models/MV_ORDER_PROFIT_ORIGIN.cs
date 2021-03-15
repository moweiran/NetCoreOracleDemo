using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class MV_ORDER_PROFIT_ORIGIN
    {
        public decimal FF_ORDER_PROFIT_ID { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public decimal ORDER_ID { get; set; }
        public string ORDER_NO { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? FF_COMPANY_ID { get; set; }
        public decimal? SHIP_COMPANY_CLASS { get; set; }
        public decimal? SHIP_COMPANY_ID { get; set; }
        public decimal? SHIP_ROUTE_AREA_ID { get; set; }
        public decimal? CUSTOMER_TYPE { get; set; }
        public decimal? CUSTOMER_ID { get; set; }
        public decimal? SALES_ID { get; set; }
        public decimal? RECEIPT_ID { get; set; }
        public decimal? POL_ID { get; set; }
        public decimal? POD_ID { get; set; }
        public decimal? DELIVERY_ID { get; set; }
        public DateTime? ETD { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public string CUSTOMER_NAME_CN { get; set; }
        public string CUSTOMER_NAME_EN { get; set; }
        public string SALES_NAME { get; set; }
        public string SAP_CUSTOMER_NO { get; set; }
        public string SAP_CONTRACT_NO { get; set; }
    }
}
