using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_DELETE_AREA_SURCHARGES
    {
        public decimal FF_DELETE_AREA_SURCHARGE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? SHIP_SURCHARGE_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
    }
}
