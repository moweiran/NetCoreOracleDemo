using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_FCL_CARRIER_SUBSCRIBE
    {
        public decimal FF_FCL_CARRIER_SUBSCRIBE_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public decimal ROUTE_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal FF_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
