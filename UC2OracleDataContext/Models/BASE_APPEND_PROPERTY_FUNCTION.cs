using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_APPEND_PROPERTY_FUNCTION
    {
        public decimal PROPERTY_FUNCTION_ID { get; set; }
        public string PROPERTY_FUNCTION_CODE { get; set; }
        public string PROPERTY_FUNCTION_NAME { get; set; }
        public string PROPERTY_FUNCTION_URL { get; set; }
        public decimal SEQUENCE { get; set; }
        public decimal? DELETE_MARK { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATE { get; set; }
    }
}
