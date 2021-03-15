using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_USERINFO
    {
        public decimal USER_ID { get; set; }
        public decimal COMPANY_ID { get; set; }
        public string COMPANY_SHORTNAME { get; set; }
        public decimal? FF_ID { get; set; }
        public string COMPANY_CLASS { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string FULLNAME { get; set; }
        public string GENDER { get; set; }
        public string TITLE { get; set; }
        public string TEL { get; set; }
        public string MOBILE { get; set; }
        public string EMAIL { get; set; }
        public string LANGUAGE { get; set; }
        public string THEMES { get; set; }
        public decimal? USER_TYPE { get; set; }
        public string REMARK { get; set; }
        public bool? CONFIRM_MOBILE { get; set; }
        public bool? CONFIRM_EMAIL { get; set; }
        public bool? IS_ADMIN { get; set; }
        public decimal DELETE_MARK { get; set; }
        public decimal USER_STATUS { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? CAMPAIGN_USER_ID { get; set; }
        public decimal? CAMPAIGN_USER_PLATFORM { get; set; }
        public string CAMPAIGN_KEY { get; set; }
        public string LOGIN_MOBILE { get; set; }
        public string WECHAT_APPID { get; set; }
        public string QQ_APPID { get; set; }
        public decimal? FF_SPREAD_ID { get; set; }
        public string WECHAT_NO { get; set; }
        public string WECHAT_OPENID { get; set; }
        public string WECHAT_UNIONID { get; set; }
        public string QQ_NO { get; set; }
        public string KEYCLOAKSUBJECT { get; set; }
        public DateTime? LATEST_LOGINTIME { get; set; }
        public string MOBILE_COUNTRY_CODE { get; set; }
    }
}
