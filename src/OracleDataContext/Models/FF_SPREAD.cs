using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_SPREAD
    {
        public decimal FF_SPREAD_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string TITLE_CN { get; set; }
        public string TITLE_EN { get; set; }
        public string SUBTITLE_CN { get; set; }
        public string SUBTITLE_EN { get; set; }
        public string CONTENT_CN { get; set; }
        public string CONTENT_EN { get; set; }
        public decimal? FILE_ID { get; set; }
        public bool? VALID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public bool? IS_SHOW_MOBILE { get; set; }
        public decimal? SPREAD_TYPE { get; set; }
        public bool? IS_PUSH_MYLIST { get; set; }
        public bool? IS_PUSH_MARKETING { get; set; }
        public decimal? REWARD_TYPE { get; set; }
        public decimal? REWARD_AMOUNT { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public decimal STATUS { get; set; }
        public string WECHAT_NO { get; set; }
    }
}
