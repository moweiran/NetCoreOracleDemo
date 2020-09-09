using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_PUSH_RATE_JOB
    {
        public decimal PUSH_RATE_JOB_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal RATE_ID { get; set; }
        public decimal RATE_CUSTOMER_ID { get; set; }
        public decimal STATUS { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public DateTime? EXEC_DATETIME { get; set; }
        public decimal MAIL_INFO_ID { get; set; }
        public decimal CUSTOMER_RATE_PUSH_ID { get; set; }
        public string BATCH_NO { get; set; }
    }
}
