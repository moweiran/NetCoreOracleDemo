using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_PEER_PUSHRATE_JOB
    {
        public decimal PEER_PUSHRATE_JOB_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal PRODUCT_LIST_ID { get; set; }
        public decimal RATE_LIST_ID { get; set; }
        public decimal MAIL_INFO_ID { get; set; }
        public decimal PEER_RATE_PUSH_ID { get; set; }
        public decimal STATUS { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public DateTime? EXEC_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string BATCH_NO { get; set; }
    }
}
