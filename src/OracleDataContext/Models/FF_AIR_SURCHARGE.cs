using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_AIR_SURCHARGE
    {
        public decimal FF_AIR_SURCHARGE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? SURCHARGE_TYPE { get; set; }
        public decimal FEETYPE_ID { get; set; }
        public string CURRENCY { get; set; }
        public decimal UNIT { get; set; }
        public decimal AMOUNT { get; set; }
        public DateTime? EFFECTIVE_DATE { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal SERVICE_PROJECT { get; set; }
        public bool? IS_MUST_CHARGE { get; set; }
        public string PPCC { get; set; }
    }
}
