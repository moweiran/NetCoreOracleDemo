using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class SAP_FEE_TYPE_MAP
    {
        public decimal ID { get; set; }
        public decimal FEE_TYPE_ID { get; set; }
        public string SAP_MAP { get; set; }
        public decimal? FF_ID { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime? MODIFY_DATETIME { get; set; }
        public string FEETYPECODE { get; set; }
        public string FEETYPENAMEEN { get; set; }
        public string FEETYPENAMECN { get; set; }
    }
}
