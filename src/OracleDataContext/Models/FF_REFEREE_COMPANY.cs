using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_REFEREE_COMPANY
    {
        public decimal FF_REFEREE_COMPANY_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal USER_ID { get; set; }
        public decimal REGISTER_USERID { get; set; }
        public decimal REGISTER_COMPANYID { get; set; }
        public decimal? FF_SPREAD_ID { get; set; }
        public decimal? REWARD_TYPE { get; set; }
        public decimal? REWARD_AMOUNT { get; set; }
        public decimal STATUS { get; set; }
        public decimal? RECEIVER_USERID { get; set; }
        public DateTime? RECEIVER_DATE { get; set; }
        public string RECEIVER_FULLNAME { get; set; }
        public string RECEIVER_ACCOUNTNO { get; set; }
        public string RECEIVER_REMARK { get; set; }
        public decimal? PAY_USERID { get; set; }
        public string PAY_FULLNAME { get; set; }
        public string PAY_ACCOUNTNO { get; set; }
        public string PAY_REMARK { get; set; }
        public DateTime? PAY_DATE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public string RECEIVER_NAME { get; set; }
        public string RECEIVER_PHONE { get; set; }
        public string RECEIVER_WECHAT { get; set; }
        public decimal? RECEIVER_FILEID { get; set; }
        public decimal? REWARD_REFEREE_AMOUNT { get; set; }
    }
}
