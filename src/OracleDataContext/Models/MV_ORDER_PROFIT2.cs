using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class MV_ORDER_PROFIT2
    {
        public decimal BUSINESS_TYPE { get; set; }
        public decimal ORDER_ID { get; set; }
        public string ORDER_NO { get; set; }
        public decimal? FF_ID { get; set; }
        public decimal? CUSTOMER_TYPE { get; set; }
        public decimal? CUSTOMER_ID { get; set; }
        public decimal? SALES_ID { get; set; }
        public DateTime? ETD { get; set; }
        public string CUSTOMER_NAME_EN { get; set; }
        public string CUSTOMER_NAME_CN { get; set; }
        public string SALES_NAME { get; set; }
    }
}
