﻿using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_AIRBRANCH_PRODUCT_LIST
    {
        public decimal FF_AIRBRANCH_PRODUCT_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal AIRLINE_ID { get; set; }
        public decimal POL_ID { get; set; }
        public string PRODUCT_NAME { get; set; }
        public decimal? PRODUCT_QTY { get; set; }
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
