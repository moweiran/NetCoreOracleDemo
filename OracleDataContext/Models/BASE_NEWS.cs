using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_NEWS
    {
        public decimal NEWS_ID { get; set; }
        public decimal NEWS_TYPE { get; set; }
        public string NEWS_TITLE { get; set; }
        public string SOURCE { get; set; }
        public decimal? FILE_ID { get; set; }
        public string SIMPLE_PICTURE_PATH { get; set; }
        public string NEWS_SUBJECT { get; set; }
        public string KEY_WORD { get; set; }
        public DateTime PUBLIC_DATE { get; set; }
        public string NEWS_CONTENT { get; set; }
        public bool? IS_HOT { get; set; }
        public decimal? READ_NUMBER { get; set; }
        public decimal LANGUAGE_TYPE { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATEUSERID { get; set; }
        public string CREATEUSERNAME { get; set; }
        public string CREATEFULLNAME { get; set; }
        public decimal? CREATECOMPANYID { get; set; }
        public DateTime CREATEDATETIME { get; set; }
        public bool? IS_TEMPLATE { get; set; }
        public string WECHAT_TITLE { get; set; }
        public string WECHAT_DESC { get; set; }
        public decimal? WECHAT_FILE_ID { get; set; }
        public decimal? LIKE_NUMBER { get; set; }
        public decimal? REPLY_NUMBER { get; set; }
        public DateTime? BEGIN_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public string ADDRESS { get; set; }
    }
}
