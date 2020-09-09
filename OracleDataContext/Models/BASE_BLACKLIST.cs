﻿using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_BLACKLIST
    {
        public decimal BASE_BLACKLIST_ID { get; set; }
        public decimal COMPANY_TYPE { get; set; }
        public decimal COMPANY_ID { get; set; }
        public string COMPANY_KEY { get; set; }
        public string LEGALREP_ID { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
    }
}
