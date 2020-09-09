using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_FCLSURCHARGE_DG
    {
        public decimal FF_FCLSURCHARGE_DG_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal SURCHARGE_MODE { get; set; }
        public string GROUP_CODE { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
