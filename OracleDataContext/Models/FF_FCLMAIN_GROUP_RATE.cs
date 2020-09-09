using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_FCLMAIN_GROUP_RATE
    {
        public decimal FF_FCLMAIN_GROUP_RATE_ID { get; set; }
        public decimal FF_FCLMAIN_PRODUCT_GROUP_ID { get; set; }
        public decimal? FF_FCLMAIN_GROUPRATE_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal? VIA_ID { get; set; }
        public decimal POD_ID { get; set; }
        public string CURRENCY { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
