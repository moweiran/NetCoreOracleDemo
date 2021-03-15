using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_FEETYPE
    {
        public decimal FF_FEETYPE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string FEE_CODE { get; set; }
        public string FEE_NAME_CN { get; set; }
        public string FEE_NAME_EN { get; set; }
        public string REMARK { get; set; }
        public bool? VALID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public string CREATE_USERNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public bool? IS_OCEAN { get; set; }
        public bool? IS_AIR { get; set; }
        public bool? IS_ECL { get; set; }
        public bool? IS_RAILWAY { get; set; }
        public bool? IS_WAREHOUSE { get; set; }
        public bool? IS_TRAILER { get; set; }
        public bool? IS_CUSTOMS { get; set; }
        public decimal? TAX_PERCENT { get; set; }
    }
}
