﻿using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_EXCHANGE_RATE
    {
        public decimal FF_EXCHANGE_RATE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string SOURCE_CURRENCY { get; set; }
        public string TARGET_CURRENCY_CODE { get; set; }
        public decimal RATE { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public decimal PAY_RATE { get; set; }
        public decimal MIDDLE_RATE { get; set; }
    }
}
