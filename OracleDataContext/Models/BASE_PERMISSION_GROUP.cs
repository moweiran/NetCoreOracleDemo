using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_PERMISSION_GROUP
    {
        public string PERMISSION_GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public string REMARK { get; set; }
        public string CATEGORY { get; set; }
        public decimal? DISPLAY_INDEX { get; set; }
        public string DEFAULTTOROLEIDS { get; set; }
        public string PERMISSION_KEYS { get; set; }
    }
}
