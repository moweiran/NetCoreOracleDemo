using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class base_userinfo
    {
        public long USER_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long COMPANY_ID { get; set; }
        public string COMPANY_SHORTNAME { get; set; }
        public string COMPANY_CLASS { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string FULLNAME { get; set; }
        public string FULLNAME_EN { get; set; }
        public string GENDER { get; set; }
        public string TITLE { get; set; }
        public string TEL { get; set; }
        public string MOBILE { get; set; }
        public string EMAIL { get; set; }
        public string LANGUAGE { get; set; }
        public string THEMES { get; set; }
        public long BASE_ROLE_ID { get; set; }
        public string USER_TYPE { get; set; }
        public string REMARK { get; set; }
        public string LOGIN_MOBILE { get; set; }
        public string WECHAT_APPID { get; set; }
        public string QQ_APPID { get; set; }
        public bool CONFIRM_MOBILE { get; set; }
        public bool CONFIRM_EMAIL { get; set; }
        public bool IS_ADMIN { get; set; }
        public string CAMPAIGN_KEY { get; set; }
        public long? CAMPAIGN_USER_ID { get; set; }
        public int? CAMPAIGN_USER_PLATFORM { get; set; }
        public bool DELETE_MARK { get; set; }
        public int USER_STATUS { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
    }
}
