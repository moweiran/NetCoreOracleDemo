﻿using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_FCLMAIN_RATE
    {
        public decimal FF_FCLMAIN_RATE_ID { get; set; }
        public decimal? MAIN_PRODUCT_ID { get; set; }
        public decimal? FF_RATE_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public decimal SCHEDULE_TYPE { get; set; }
        public decimal SCHEDULE_ID { get; set; }
        public string VESSEL_CODE { get; set; }
        public string VESSEL_NAME_EN { get; set; }
        public string VOYAGE { get; set; }
        public decimal POL_ID { get; set; }
        public decimal? VIA_ID { get; set; }
        public decimal POD_ID { get; set; }
        public DateTime? ETD { get; set; }
        public string REMARK { get; set; }
        public string CURRENCY { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal FF_FCLMAIN_GROUP_RATE_ID { get; set; }
    }
}
