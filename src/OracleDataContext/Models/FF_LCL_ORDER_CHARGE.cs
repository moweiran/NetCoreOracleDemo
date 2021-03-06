﻿using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_LCL_ORDER_CHARGE
    {
        public decimal FF_LCL_ORDER_CHARGE_ID { get; set; }
        public decimal PARENT_ORDER_CHARGE_ID { get; set; }
        public decimal LCL_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FEETYPE_ID { get; set; }
        public decimal CHARGE_TYPE { get; set; }
        public decimal REF_ID { get; set; }
        public decimal UNIT { get; set; }
        public decimal PRICE { get; set; }
        public decimal COST { get; set; }
        public decimal? SALES_COST { get; set; }
        public decimal? AMOUNT_APPLY { get; set; }
        public decimal? AMOUNT_REPLY { get; set; }
        public decimal AMOUNT_FINAL { get; set; }
        public decimal QTY { get; set; }
        public string CURRENCY { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal DATA_SOURCE { get; set; }
    }
}
