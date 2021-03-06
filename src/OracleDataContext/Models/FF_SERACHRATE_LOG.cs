﻿using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_SERACHRATE_LOG
    {
        public decimal FF_SERACHRATE_LOG_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? RECEIPT_ID { get; set; }
        public decimal? DELIVERY_ID { get; set; }
        public decimal? CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
