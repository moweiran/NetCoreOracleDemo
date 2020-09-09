using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_BUSINESS_CARD
    {
        public string CARD_ID { get; set; }
        public string WECHAT_UNIONID { get; set; }
        public decimal CARD_STATUS { get; set; }
        public string USER_NAME { get; set; }
        public decimal? USER_SEX { get; set; }
        public string USER_JOB { get; set; }
        public string COMPANY_NAME { get; set; }
        public string TEL { get; set; }
        public string EMAIL { get; set; }
        public string QQ_NO { get; set; }
        public string WECHAT_NO { get; set; }
        public string FAX { get; set; }
        public string AREA { get; set; }
        public string BUSINESS { get; set; }
        public string ADVANTAGE { get; set; }
        public decimal? HEAD_ID { get; set; }
        public decimal? LOGO_ID { get; set; }
        public string CARD_COLOR { get; set; }
        public decimal? VIEW_NUMBER { get; set; }
        public decimal? FAVORITE_NUMBER { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public DateTime? MODIFY_DATE { get; set; }
        public bool? IS_COMMEND { get; set; }
        public string MOBILE { get; set; }
        public decimal? QRCODE_ID { get; set; }
    }
}
