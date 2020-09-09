using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_MODULE_BUTTON
    {
        public decimal MODULE_BUTTON_ID { get; set; }
        public decimal? BUTTON_ID { get; set; }
        public decimal? RESPONSE_ID { get; set; }
        public decimal? MODULE_ID { get; set; }
        public decimal? SEQUENCE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
