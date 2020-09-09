using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_FCLRATE_MODE
    {
        public decimal FF_FCLRATE_MODE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public decimal ROUTE_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal RATE_MODE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
    }
}
