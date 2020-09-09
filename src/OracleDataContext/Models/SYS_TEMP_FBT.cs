using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class SYS_TEMP_FBT
    {
        public string SCHEMA { get; set; }
        public string OBJECT_NAME { get; set; }
        public decimal? OBJECT_ { get; set; }
        public string RID { get; set; }
        public string ACTION { get; set; }
    }
}
