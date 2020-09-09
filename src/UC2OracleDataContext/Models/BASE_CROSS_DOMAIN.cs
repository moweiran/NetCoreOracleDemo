using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_CROSS_DOMAIN
    {
        public decimal CROSS_DOMAIN_ID { get; set; }
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_NAME { get; set; }
        public decimal COMPANY_ID { get; set; }
        public string CROSS_OBJECT { get; set; }
        public string APPLY_TO { get; set; }
        public string CROSS_SCOPE { get; set; }
        public string REMARK { get; set; }
        public bool? STATUS { get; set; }
        public decimal? DELETE_MARK { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
