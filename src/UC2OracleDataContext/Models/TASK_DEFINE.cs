using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class TASK_DEFINE
    {
        public TASK_DEFINE()
        {
            TASK_PARAMETER = new HashSet<TASK_PARAMETER>();
        }

        public decimal TASK_DEFINE_ID { get; set; }
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_KEY { get; set; }
        public string TASK_CODE { get; set; }
        public string TASK_NAME { get; set; }
        public string TASK_REMARK { get; set; }
        public string TASK_TYPE { get; set; }
        public string TASK_OBJECT { get; set; }
        public decimal EXECUTE_METHOD { get; set; }
        public decimal? MULTI { get; set; }
        public bool? VALID { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime? MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }

        public virtual ICollection<TASK_PARAMETER> TASK_PARAMETER { get; set; }
    }
}
