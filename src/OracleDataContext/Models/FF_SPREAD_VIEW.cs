using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_SPREAD_VIEW
    {
        public decimal FF_SPREAD_VIEW_ID { get; set; }
        public decimal FF_SPREAD_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string CLIENT_CODE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
