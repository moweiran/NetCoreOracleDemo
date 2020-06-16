using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_CUSTOMER_PRODUCT_TEU
    {
        public decimal CUSTOMER_PRODUCT_TEU_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal? CUSTOMER_COMPANY_ID { get; set; }
        public decimal PRODUCT_ID { get; set; }
        public decimal? LAND_PRODUCT_PATH_ID { get; set; }
        public decimal TEU { get; set; }
        public DateTime MODIFTY_DATE { get; set; }
        public bool DELETE_MARK { get; set; }
    }
}
