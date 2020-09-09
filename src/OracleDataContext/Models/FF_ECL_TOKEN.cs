using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_ECL_TOKEN
    {
        public decimal FF_ECL_TOKEN_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string SHOP_NAME { get; set; }
        public decimal PLATFORM_TYPE { get; set; }
        public string SITE { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string TOKEN1 { get; set; }
        public string TOKEN2 { get; set; }
        public string TOKEN3 { get; set; }
        public string TOKEN4 { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
