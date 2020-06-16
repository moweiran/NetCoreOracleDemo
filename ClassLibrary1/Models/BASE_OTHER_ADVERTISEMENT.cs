using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_OTHER_ADVERTISEMENT
    {
        public decimal BASE_OTHER_ADVERTISEMENT_ID { get; set; }
        public decimal SHOW_INDEX { get; set; }
        public decimal ADVERTISEMENT_TYPE { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public string ADVERTISEMENT_SUBJECT_CN { get; set; }
        public string ADVERTISEMENT_SUBJECT_EN { get; set; }
        public decimal? FILE_CN_ID { get; set; }
        public decimal? FILE_EN_ID { get; set; }
        public string ADVERTISEMENT_CONTENT_CN { get; set; }
        public string ADVERTISEMENT_CONTENT_EN { get; set; }
        public decimal? READ_NUMBER { get; set; }
        public decimal? REPLY_NUMBER { get; set; }
        public decimal? LIKE_NUMBER { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? M_BG_FILE_ID { get; set; }
        public string M_CONTENTC_CN { get; set; }
        public string M_CONTENTC_EN { get; set; }
    }
}
