using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_PRODUCT_SUPPLIER_LOG
    {
        public decimal FF_PRODUCT_SUPPLIER_LOG_ID { get; set; }
        public decimal PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal OPER_TYPE { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal PRODUCT_SOURCE { get; set; }
    }
}
