using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_FCLSURCHARGE_OWP
    {
        public decimal FF_FCLSURCHARGE_OWP_ID { get; set; }
        public decimal FF_FCLSURCHARGE_OW_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal RECEIPT_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal POD_ID { get; set; }
        public decimal DELIVERY_ID { get; set; }
        public string GROUP_CODE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal PRODUCT_ID { get; set; }
    }
}
