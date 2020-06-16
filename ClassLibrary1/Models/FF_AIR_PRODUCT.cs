using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_AIR_PRODUCT
    {
        public decimal FF_AIR_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal AIRLINE_ID { get; set; }
        public decimal? PRE_PRODUCT_ID { get; set; }
        public decimal MAIN_PRODUCT_ID { get; set; }
        public decimal? AFTER_PRODUCT_ID { get; set; }
        public decimal PRODUCT_TYPE { get; set; }
        public decimal RECEIPT_ID { get; set; }
        public decimal RECEIPT_CITY_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal POL_CITY_ID { get; set; }
        public decimal POD_ID { get; set; }
        public decimal POD_CITY_ID { get; set; }
        public decimal DELIVERY_ID { get; set; }
        public decimal DELIVER_CITY_ID { get; set; }
        public decimal? VIA_ID { get; set; }
        public decimal? TOTAL_ORDER { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
