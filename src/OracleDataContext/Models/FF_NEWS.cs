using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_NEWS
    {
        public decimal FF_NEWS_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string NEWS_TITLE { get; set; }
        public decimal? FILE_ID { get; set; }
        public string NEWS_CONTENT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? READ_NUMBER { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public DateTime? PUBLISH_DATE { get; set; }
        public decimal LANGUAGE_TYPE { get; set; }
        public bool? IS_HOT { get; set; }
        public string WECHAT_TITLE { get; set; }
        public string WECHAT_DESC { get; set; }
        public decimal? WECHAT_FILE_ID { get; set; }
        public decimal? REPLY_NUMBER { get; set; }
        public decimal? LIKE_NUMBER { get; set; }
    }
}
