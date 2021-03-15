using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_SCHEDULE
    {
        public decimal FF_SCHEDULE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public decimal SHIP_ROUTE_ID { get; set; }
        public string VESSEL_NAME { get; set; }
        public string VOYAGE { get; set; }
        public decimal PORT_ID { get; set; }
        public DateTime? CUT_BOOKING_DATETIME { get; set; }
        public DateTime? CUT_CUSTOMS_CLEARANCE { get; set; }
        public DateTime? CLOSE_DATETIME { get; set; }
        public DateTime? CUT_MATERIAL_DATETIME { get; set; }
        public DateTime? CUT_VGM_DATETIME { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? ETD { get; set; }
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
