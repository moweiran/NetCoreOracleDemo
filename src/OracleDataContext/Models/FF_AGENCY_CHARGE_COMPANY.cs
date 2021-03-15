using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_AGENCY_CHARGE_COMPANY
    {
        public decimal AGENCY_CHARGE_COMPANY_ID { get; set; }
        public decimal AGENCY_CHARGE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public decimal? CREATE_COMPANY_ID { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
    }
}
