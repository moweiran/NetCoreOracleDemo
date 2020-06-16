using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_SPREAD
    {
        public decimal BASE_SPREAD_ID { get; set; }
        public string TITLE_CN { get; set; }
        public string TITLE_EN { get; set; }
        public string SUBTITLE_CN { get; set; }
        public string SUBTITLE_EN { get; set; }
        public string CONTENT_CN { get; set; }
        public string CONTENT_EN { get; set; }
        public decimal? FILE_ID { get; set; }
        public bool? IS_WITHIN { get; set; }
        public bool? IS_BOX { get; set; }
        public bool? IS_EXTERNAL { get; set; }
        public bool VALID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal BOX_TYPE { get; set; }
        public bool? IS_SYNC { get; set; }
        public bool? IS_PUBLISH { get; set; }
        public decimal? M_FILE_ID { get; set; }
        public bool? IS_TO_APP { get; set; }
        public bool? IS_APP_RECOMMENDED_PRIZE { get; set; }
        public bool? IS_PEER_SPREAD { get; set; }
        public decimal STATUS { get; set; }
        public bool? IS_SHOW_MOBILE { get; set; }
        public decimal? SPREAD_TYPE { get; set; }
        public bool? IS_PUSH_MYLIST { get; set; }
        public bool? IS_PUSH_MARKETING { get; set; }
        public decimal? REWARD_TYPE { get; set; }
        public decimal? REWARD_AMOUNT { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public bool? IS_SEND_MESSAGE { get; set; }
    }
}
