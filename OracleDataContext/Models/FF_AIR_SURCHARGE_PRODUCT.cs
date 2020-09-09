using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_AIR_SURCHARGE_PRODUCT
    {
        public decimal FF_AIR_SURCHARGE_PRODUCT_ID { get; set; }
        public decimal FF_AIR_SURCHARGE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_AIR_PRODUCT_ID { get; set; }
        public decimal AIRLINE_ID { get; set; }
        public decimal RECEIPT_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal POD_ID { get; set; }
        public decimal DELIVERY_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
