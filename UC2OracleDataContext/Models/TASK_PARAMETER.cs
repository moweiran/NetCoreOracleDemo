using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class TASK_PARAMETER
    {
        public decimal TASK_PARAMETER_ID { get; set; }
        public decimal TASK_DEFINE_ID { get; set; }
        public string PARAMETER_CODE { get; set; }
        public string PARAMETER_NAME { get; set; }
        public string PARAMETER_REMARK { get; set; }
        public decimal? PARAMETER_DATATYPE { get; set; }
        public string PARAMETER_DATASOURCE { get; set; }
        public decimal PARAMETER_MIN { get; set; }
        public decimal PARAMETER_MAX { get; set; }
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

        public virtual TASK_DEFINE TASK_DEFINE_ { get; set; }
    }
}
