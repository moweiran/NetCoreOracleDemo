using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_LCL_PRODUCT
    {
        public decimal FF_LCL_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal MAIN_PRODUCT_ID { get; set; }
        public decimal? PRE_PRODUCT_ID { get; set; }
        public decimal? AFTER_PRODUCT_ID { get; set; }
        public decimal PRODUCT_TYPE { get; set; }
        public decimal TT { get; set; }
        public bool? IS_CC { get; set; }
        public decimal RECEIPT_ID { get; set; }
        public decimal RECEIPT_CITY_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal POL_CITY_ID { get; set; }
        public decimal? VIA_ID { get; set; }
        public decimal? VIA_CITY_ID { get; set; }
        public decimal POD_ID { get; set; }
        public decimal POD_CITY_ID { get; set; }
        public decimal DELIVERY_ID { get; set; }
        public decimal DELIVERY_CITY_ID { get; set; }
        public decimal? TOTAL_VOLUME { get; set; }
        public decimal? TOTAL_WEIGHT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? PRE_TT { get; set; }
        public decimal? MAIN_TT { get; set; }
        public decimal? AFTER_TT { get; set; }
        public decimal? TOTAL_ORDER { get; set; }
    }
}
