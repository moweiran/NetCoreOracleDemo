using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_FCLMAIN_CRS
    {
        public decimal FF_FCLMAIN_CRS_ID { get; set; }
        public decimal? FF_FCLMAIN_CPL_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal RATE_QTY { get; set; }
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
        public decimal? PUBLIC_GP20 { get; set; }
        public decimal? PUBLIC_GP40 { get; set; }
        public decimal? PUBLIC_HQ40 { get; set; }
        public decimal? PUBLIC_GP45 { get; set; }
        public decimal? SUBSIDY_TEU { get; set; }
        public decimal? SUBSIDY_SALE_TEU { get; set; }
        public decimal? SUBSIDY_GP20 { get; set; }
        public decimal? SUBSIDY_GP40 { get; set; }
        public decimal? SUBSIDY_HQ40 { get; set; }
        public decimal? SUBSIDY_GP45 { get; set; }
    }
}
