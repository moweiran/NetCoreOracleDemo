using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_AIRMAIN_RATE
    {
        public decimal FF_AIRMAIN_RATE_ID { get; set; }
        public decimal? FF_AIRMAIN_RATE_LIST_ID { get; set; }
        public decimal FF_AIRMAIN_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal POL_CITY_ID { get; set; }
        public decimal POD_ID { get; set; }
        public decimal POD_CITY_ID { get; set; }
        public string CURRENCY { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public string REMARK { get; set; }
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
