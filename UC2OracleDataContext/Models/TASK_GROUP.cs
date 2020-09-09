using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class TASK_GROUP
    {
        public decimal TASK_GROUP_ID { get; set; }
        public decimal GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public decimal TASK_CONFIG_ID { get; set; }
        public decimal TASK_ID { get; set; }
        public string TASK_NAME { get; set; }
        public string TASK_REMARK { get; set; }
        public decimal COMPANY_ID { get; set; }
        public string COMPANY_CODE { get; set; }
        public decimal VALID { get; set; }
        public decimal CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }

        public virtual TASK_GROUP_DEFINE GROUP_ { get; set; }
    }
}
