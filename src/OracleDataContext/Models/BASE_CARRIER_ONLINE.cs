using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_CARRIER_ONLINE
    {
        public decimal CARRIER_ONLINE_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public decimal SHIP_ROUTE_ID { get; set; }
        public decimal CARRIER_COMPANY_ID { get; set; }
        public string REMARK { get; set; }
        public bool VALID { get; set; }
        public bool DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime? MODIFY_DATETIME { get; set; }
        public decimal CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATE { get; set; }
    }
}
