using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BUSINESS_FILTER_CONDITION
    {
        public decimal BUSINESS_FILTER_CONDITION_ID { get; set; }
        public decimal? BUSINESS_FILTER_ID { get; set; }
        public string FILTER_OPERATOR { get; set; }
        public bool? Group { get; set; }
        public string FILTER_FIELD { get; set; }
        public string OPERATOR { get; set; }
        public string FILTER_VALUE { get; set; }
        public decimal? PARENT_ID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime? MODIFY_DATE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
