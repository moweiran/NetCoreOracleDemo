using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_MAIL_INFO
    {
        public decimal FF_MAIL_INFO_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string MAIL_ACCOUNT { get; set; }
        public string MAIL_PASSWORD { get; set; }
        public string SEND_SERVER { get; set; }
        public string SEND_PORT { get; set; }
        public bool? IS_SSL { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
    }
}
