using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_MEMOS
    {
        public decimal BASE_MEMO_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public string BUSINESS_ID { get; set; }
        public string MEMO_CONTENT { get; set; }
        public decimal? MEMO_LEVEL { get; set; }
        public bool? IS_VIEW_CUSTOMER { get; set; }
        public bool? IS_VIEW_AGENCY { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
