using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_FCL_SPACE
    {
        public decimal FF_FCL_SPACE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public decimal SCHEDULE_TYPE { get; set; }
        public decimal SCHEDULE_ID { get; set; }
        public string VESSEL_VOYAGE { get; set; }
        public decimal POL_ID { get; set; }
        public decimal? POL2_ID { get; set; }
        public decimal? POL3_ID { get; set; }
        public decimal? POL4_ID { get; set; }
        public decimal? POL5_ID { get; set; }
        public decimal SPACE_QTY { get; set; }
        public decimal USE_QTY { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
        public string REMARK { get; set; }
        public decimal? POD_ID { get; set; }
    }
}
