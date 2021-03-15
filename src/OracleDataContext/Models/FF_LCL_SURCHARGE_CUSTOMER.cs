using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_LCL_SURCHARGE_CUSTOMER
    {
        public decimal FF_LCL_SURCHARGE_CUSTOMER_ID { get; set; }
        public decimal? SURCHARGE_SOURCE { get; set; }
        public decimal? FF_LCL_SURCHARGE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal LCL_PRODUCT_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal SURCHARGE_TYPE { get; set; }
        public decimal SERVICE_PROJECT { get; set; }
        public bool? IS_MUST_CHARGE { get; set; }
        public string PPCC { get; set; }
        public decimal FEETYPE_ID { get; set; }
        public string CURRENCY { get; set; }
        public decimal UNIT { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal? DIRECT_AMOUNT { get; set; }
        public bool? IS_ALLIN_INCLUDE { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
