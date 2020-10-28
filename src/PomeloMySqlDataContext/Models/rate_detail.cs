using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class rate_detail
    {
        public long RATE_DETAIL_ID { get; set; }
        public long RATE_ID { get; set; }
        public int RATE_TYPE { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
        public decimal? GP45 { get; set; }
        public DateTime RATE_UPDATEDATE { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
