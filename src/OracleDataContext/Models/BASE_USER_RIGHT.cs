using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_USER_RIGHT
    {
        public decimal USER_RIGHT_ID { get; set; }
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_NAME { get; set; }
        public decimal? PLATFORM { get; set; }
        public decimal? USER_ID { get; set; }
        public decimal? MENU_ID { get; set; }
        public decimal PERMISSION_TYPE { get; set; }
        public decimal MODULE_ID { get; set; }
        public decimal? AUTHORIZE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
