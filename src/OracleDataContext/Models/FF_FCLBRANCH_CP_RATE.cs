using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_FCLBRANCH_CP_RATE
    {
        public decimal FF_FCLBRANCH_CP_RATE_ID { get; set; }
        public decimal FF_FCLBRANCH_CP_ID { get; set; }
        public decimal? FF_FCLBRANCH_CRS_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public decimal MAIN_PORT_ID { get; set; }
        public decimal BRANCH_PORT_ID { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
        public decimal? GP45 { get; set; }
        public string CURRENCY { get; set; }
        public string REMARK { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
