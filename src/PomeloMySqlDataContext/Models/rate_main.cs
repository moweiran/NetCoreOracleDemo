﻿using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class rate_main
    {
        public long RATE_MAIN_ID { get; set; }
        public long RATE_MAIN_LIST_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public long CARRIER_COMPANY_ID { get; set; }
        public long ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public long WEEK_ID { get; set; }
        public long SCHEDULE_ID { get; set; }
        public string VESSEL_NAME { get; set; }
        public string VOYAGE { get; set; }
        public DateTime? ETD { get; set; }
        public long MAIN_PRODUCT_ID { get; set; }
        public long POL_ID { get; set; }
        public long? VIA_ID { get; set; }
        public long POD_ID { get; set; }
        public string REMARK { get; set; }
        public string CURRENCY { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public int STATUS { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
