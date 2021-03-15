using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_FEEDBACK
    {
        public decimal FEEDBACK_ID { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public string IP { get; set; }
        public string CONTACT { get; set; }
        public string CONTENT { get; set; }
        public bool? WEBSITE_SHOW { get; set; }
        public decimal? REPLY_USER_ID { get; set; }
        public string REPLY_USER_FULLNAME { get; set; }
        public DateTime? REPLY_DATE { get; set; }
        public string REPLY_CONTENT { get; set; }
        public decimal FEEDBACK_TYPE { get; set; }
        public decimal COMPANY_ID { get; set; }
        public decimal USER_ID { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
    }
}
