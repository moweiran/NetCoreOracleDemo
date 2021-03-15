using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_FCLMAIN_RATE_DETAIL
    {
        public decimal FF_FCLMAIN_RATE_DETAIL_ID { get; set; }
        public decimal FF_FCLMAIN_RATE_ID { get; set; }
        public decimal RATE_TYPE { get; set; }
        public decimal? GP20_ADD { get; set; }
        public decimal? GP40_ADD { get; set; }
        public decimal? HQ40_ADD { get; set; }
        public decimal? GP45_ADD { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
        public decimal? GP45 { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
