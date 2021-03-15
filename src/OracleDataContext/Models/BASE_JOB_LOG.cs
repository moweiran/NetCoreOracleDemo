using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_JOB_LOG
    {
        public decimal BASE_JOB_LOG_ID { get; set; }
        public decimal JOB_TYPE { get; set; }
        public string JOB_KEY1 { get; set; }
        public string JOB_KEY2 { get; set; }
        public string JOB_KEY3 { get; set; }
        public string JOB_KEY4 { get; set; }
        public string JOB_KEY5 { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public decimal? STATUS { get; set; }
        public string REMARK { get; set; }
    }
}
