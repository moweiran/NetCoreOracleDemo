using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_FEE_STANDARD
    {
        public decimal BASE_FEE_STANDARD_ID { get; set; }
        public decimal COMPANY_LEVEL { get; set; }
        public decimal? TEU { get; set; }
        public decimal SCHEDULE_FEE { get; set; }
        public decimal MAIL_PUSHRATE_FEE { get; set; }
        public decimal PEER_CUSTOMER_FEE { get; set; }
        public decimal DIRECT_CUSTOMER_FEE { get; set; }
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
    }
}
