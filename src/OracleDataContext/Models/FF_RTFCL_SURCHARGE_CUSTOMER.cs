﻿using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_RTFCL_SURCHARGE_CUSTOMER
    {
        public decimal FF_RTFCL_SURCHARGE_CUSTOMER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal FF_RTFCL_PRODUCT_ID { get; set; }
        public decimal DATA_SOURCE { get; set; }
        public decimal? FF_RTFCL_SURCHARGE_ID { get; set; }
        public string PPCC { get; set; }
        public bool? IS_MUST_CHARGE { get; set; }
        public decimal FEETYPE_ID { get; set; }
        public decimal UNIT { get; set; }
        public string CURRENCY { get; set; }
        public decimal? AMOUNT_BOOKING { get; set; }
        public decimal? AMOUNT_GP20 { get; set; }
        public decimal? AMOUNT_GP40 { get; set; }
        public decimal? AMOUNT_HQ40 { get; set; }
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
