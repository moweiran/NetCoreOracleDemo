using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class TASK_GROUP_DEFINE
    {
        public TASK_GROUP_DEFINE()
        {
            TASK_GROUP = new HashSet<TASK_GROUP>();
        }

        public decimal GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public string GROUP_REMARK { get; set; }
        public decimal COMPANY_ID { get; set; }
        public string COMPANY_NAME { get; set; }
        public decimal? STATUS { get; set; }
        public bool? VALID { get; set; }
        public DateTime? CREATE_DATETIME { get; set; }

        public virtual ICollection<TASK_GROUP> TASK_GROUP { get; set; }
    }
}
