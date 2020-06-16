using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_MESSAGE
    {
        public decimal MESSAGE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal MESSAGE_GROUP { get; set; }
        public decimal MESSAGE_TYPE { get; set; }
        public decimal SEND_COMPANY_TYPE { get; set; }
        public decimal SEND_COMPANY_ID { get; set; }
        public string SEND_COMPANY_CNAME { get; set; }
        public string SEND_COMPANY_ENAME { get; set; }
        public decimal SEND_USER_ID { get; set; }
        public string SEND_USER_CNAME { get; set; }
        public string SEND_USER_ENAME { get; set; }
        public decimal RECEIVE_COMPANY_TYPE { get; set; }
        public decimal RECEIVE_COMPANY_ID { get; set; }
        public decimal RECEIVE_USER_ID { get; set; }
        public string TITLE_CN { get; set; }
        public string TITLE_EN { get; set; }
        public string CONTENT_CN { get; set; }
        public string CONTENT_EN { get; set; }
        public string PARAMETER1 { get; set; }
        public string PARAMETER2 { get; set; }
        public string PARAMETER3 { get; set; }
        public string PARAMETER4 { get; set; }
        public string PARAMETER5 { get; set; }
        public string RESPONSE { get; set; }
        public decimal STATUS { get; set; }
        public DateTime? READ_DATE { get; set; }
        public DateTime? CONFIRM_DATE { get; set; }
        public bool? CONFIRM { get; set; }
        public decimal? MSG_ORDER { get; set; }
        public bool? DELETE_MARK { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
