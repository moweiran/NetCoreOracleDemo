using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_NEWS_REPLY
    {
        public decimal BASE_NEWS_REPLY_ID { get; set; }
        public decimal NEWS_ID { get; set; }
        public decimal? PARENT_NEWS_REPLY_ID { get; set; }
        public string REPLY_CONTENT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATEUSERID { get; set; }
        public string CREATEUSERNAME { get; set; }
        public string CREATEFULLNAME { get; set; }
        public decimal? CREATECOMPANYID { get; set; }
        public DateTime CREATEDATETIME { get; set; }
        public decimal? REPLY_NUMBER { get; set; }
        public decimal? LIKE_NUMBER { get; set; }
        public string PARENT_REPLY_USERNAME { get; set; }
    }
}
