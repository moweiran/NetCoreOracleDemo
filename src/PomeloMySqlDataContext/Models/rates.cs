﻿using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class rates
    {
        public long RATE_ID { get; set; }
        public long RATE_MAIN_LIST_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public long CARRIER_COMPANY_ID { get; set; }
        public long ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public long PRODUCT_ID { get; set; }
        public long WEEK_ID { get; set; }
        public int PRODUCT_TYPE { get; set; }
        public long SCHEDULE_ID { get; set; }
        public string VESSEL_NAME { get; set; }
        public string VOYAGE { get; set; }
        public int? CLOSE_TIME { get; set; }
        public int? LEAVE_TIME { get; set; }
        public int TT { get; set; }
        public DateTime? POL_ETD { get; set; }
        public long RECEIPT_ID { get; set; }
        public string RECEIPT_CODE { get; set; }
        public long RECEIPT_CITY_ID { get; set; }
        public long POL_ID { get; set; }
        public string POL_CODE { get; set; }
        public long POL_CITY_ID { get; set; }
        public long? VIA_ID { get; set; }
        public string VIA_CODE { get; set; }
        public long? VIA_CITY_ID { get; set; }
        public long POD_ID { get; set; }
        public string POD_CODE { get; set; }
        public long POD_CITY_ID { get; set; }
        public long DELIVERY_ID { get; set; }
        public string DELIVERY_CODE { get; set; }
        public long DELIVERY_CITY_ID { get; set; }
        public string REMARK { get; set; }
        public string CURRENCY { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public int STATUS { get; set; }
        public long MAIN_PRODUCT_ID { get; set; }
        public string PRE_BRANCH_PRODUCT_ID { get; set; }
        public string AFTER_BRANCH_PRODUCT_ID { get; set; }
        public bool IS_MAIN_PRODUCT { get; set; }
        public long MAIN_RATE_ID { get; set; }
        public long? PRE_BRANCH_RATE_ID { get; set; }
        public long? AFTER_BRANCH_RATE_ID { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
