using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class CALISTA_BOOKING_CONTAINER
    {
        public decimal CALISTA_BOOKING_CONTAINER_ID { get; set; }
        public decimal CALISTA_FREIGHT_BOOKING_ID { get; set; }
        public decimal CONTAINERQTY { get; set; }
        public string CONTAINERTYPE { get; set; }
        public string CONTAINERSIZE { get; set; }
        public string CONTAINERHEIGHTTYPE { get; set; }
        public string CONTAINERSTATUS { get; set; }
        public bool? SHIPPEROWNED { get; set; }
        public bool? HAZARDOUS { get; set; }
        public decimal? SEQNO { get; set; }
    }
}
