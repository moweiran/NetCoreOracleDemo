using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_APPLICATION_ROLE_RIGHT
    {
        public decimal APPLICATION_ROLE_RIGHT_ID { get; set; }
        public decimal? APPLICATION_ROLE_ID { get; set; }
        public decimal PERMISSION_TYPE { get; set; }
        public decimal MODULE_ID { get; set; }
        public decimal? BUTTON_ID { get; set; }
        public decimal AUTHORIZE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
