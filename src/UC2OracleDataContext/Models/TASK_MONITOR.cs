using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class TASK_MONITOR
    {
        public decimal TASK_MONITOR_ID { get; set; }
        public decimal TASK_LIST_ID { get; set; }
        public string TASK_NAME { get; set; }
        public DateTime LAST_RUN_TIME { get; set; }
        public decimal TIMEOUT { get; set; }
        public decimal COMPANY_ID { get; set; }
        public string COMPANY_CODE { get; set; }
        public string COMPANY_NAME { get; set; }
        public string TASK_GROUPS { get; set; }
        public DateTime PLAN_TIME { get; set; }
        public string TASK_REMARK { get; set; }
        public string MONITOR_NOTES { get; set; }
        public decimal? STATUS { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
