using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_PEER_SENDMAIL_RATE
    {
        public decimal PEER_SENDMAIL_RATE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal PRODUCT_LIST_ID { get; set; }
        public decimal RATE_LIST_ID { get; set; }
        public decimal FF_MAIL_INFO_ID { get; set; }
        public string SEND_MAIL { get; set; }
        public string TO_MAIL { get; set; }
        public DateTime? SEND_DATE { get; set; }
        public string MAIL_SUBJECT { get; set; }
        public string MAIL_CONTENT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public DateTime RATE_EFFECTIVE_DATE { get; set; }
        public DateTime RATE_EXPIRATION_DATE { get; set; }
        public decimal STATUS { get; set; }
        public string REMARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
