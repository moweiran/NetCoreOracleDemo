using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_MAIL_TEMPLATE
    {
        public decimal FF_MAIL_TEMPLATE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal TEMPLATE_TYPE { get; set; }
        public string TEMPLATE_NAME { get; set; }
        public string TEMPLATE_SUBJECT { get; set; }
        public string TEMPLATE_SIGN { get; set; }
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
