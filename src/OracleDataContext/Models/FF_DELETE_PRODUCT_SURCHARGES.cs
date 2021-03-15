using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_DELETE_PRODUCT_SURCHARGES
    {
        public decimal FF_DELETE_PRODUCT_SURCHARGE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal SURCHARGE_TYPE { get; set; }
        public decimal PRODUCT_ID { get; set; }
        public decimal? SHIP_SURCHARGE_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
        public decimal DATA_SOURCE { get; set; }
    }
}
