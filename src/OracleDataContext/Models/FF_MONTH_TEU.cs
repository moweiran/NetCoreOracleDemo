using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_MONTH_TEU
    {
        public string FF_MONTH_TEU_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal YEARS { get; set; }
        public decimal MONTHS { get; set; }
        public decimal DIRECT_CUSTOMER_TEU { get; set; }
        public decimal PEER_CUSTOMER_TEU { get; set; }
        public decimal TOTAL_TEU { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
    }
}
