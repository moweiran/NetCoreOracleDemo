﻿using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_ADVERTISEMENT_LCL
    {
        public decimal FF_ADVERTISEMENT_LCL_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal SHIPROUTE_AREA_ID { get; set; }
        public decimal CITY_ID { get; set; }
        public decimal PRICE { get; set; }
        public decimal QTY { get; set; }
        public decimal AMOUNT { get; set; }
        public string COMPANY_DESCRIBE { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
