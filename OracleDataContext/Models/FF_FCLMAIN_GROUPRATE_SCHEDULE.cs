using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_FCLMAIN_GROUPRATE_SCHEDULE
    {
        public decimal FCLMAIN_GROUPRATE_SCHEDULE_ID { get; set; }
        public decimal? FF_FCLMAIN_GROUPRATE_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public decimal ROUTE_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal SCHEDULE_TYPE { get; set; }
        public decimal SCHEDULE_ID { get; set; }
        public string VESSEL_NAME { get; set; }
        public string VOYAGE { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? ETD { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
