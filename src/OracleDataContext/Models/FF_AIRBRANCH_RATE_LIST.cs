using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_AIRBRANCH_RATE_LIST
    {
        public decimal FF_AIRBRANCH_RATE_LIST_ID { get; set; }
        public decimal FF_AIRBRANCH_PRODUCT_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal RATE_QTY { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public decimal STATUS { get; set; }
        public DateTime RATE_UPDATEDATE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
