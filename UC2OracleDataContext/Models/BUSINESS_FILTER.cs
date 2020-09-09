using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BUSINESS_FILTER
    {
        public decimal BUSINESS_FILTER_ID { get; set; }
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_NAME { get; set; }
        public string BUSINESS_FILTER_CODE { get; set; }
        public string BUSINESS_FILTER_NAME { get; set; }
        public decimal ORGANIZATION_ID { get; set; }
        public decimal USER_ROLE_ID { get; set; }
        public decimal USER_GROUP_ID { get; set; }
        public decimal USER_ID { get; set; }
        public string REMARK { get; set; }
        public string SQL { get; set; }
        public bool? STATUS { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime? MODIFY_DATE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
