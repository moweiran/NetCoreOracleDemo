using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_MAIL_TEMPLATE
    {
        public decimal MAIL_TEMPLATE_ID { get; set; }
        public decimal MAIL_TYPE { get; set; }
        public string MAIL_LANGUAGE { get; set; }
        public string MAIL_SUBJECT { get; set; }
        public string MAIL_CONTENT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime? MODIFY_DATETIME { get; set; }
        public decimal CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATE { get; set; }
    }
}
