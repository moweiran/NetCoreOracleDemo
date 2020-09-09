using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class MV_BOOKING_ORDER
    {
        public decimal BOOKING_ORDER_ID { get; set; }
        public string ORDER_NO { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
        public string CUSTOMER_NAME_CN { get; set; }
        public string CUSTOMER_NAME_EN { get; set; }
        public decimal? SHIP_ROUTE_AREA_ID { get; set; }
        public decimal SCHEDULE_ID { get; set; }
        public string VESSEL_NAME_EN { get; set; }
        public string VOYAGE { get; set; }
        public DateTime? ETD { get; set; }
        public decimal? LOAD_TEU { get; set; }
        public decimal? SALES_ID { get; set; }
        public string SALES_NAME { get; set; }
        public decimal? RECEIPT_ID { get; set; }
        public decimal? POL_ID { get; set; }
        public decimal? POD_ID { get; set; }
        public decimal? DELIVERY_ID { get; set; }
    }
}
