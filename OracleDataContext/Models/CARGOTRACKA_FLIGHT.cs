using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class CARGOTRACKA_FLIGHT
    {
        public string KEY_ID { get; set; }
        public string B_KEY_ID { get; set; }
        public string FLIGHT_NO { get; set; }
        public DateTime? FLIGHT_DATE { get; set; }
        public string ORG { get; set; }
        public string DST { get; set; }
        public DateTime? ATD { get; set; }
        public DateTime? ATA { get; set; }
        public string PIECES { get; set; }
        public string WEIGHT { get; set; }
        public string VOLUME { get; set; }
        public string GOODS_NAME { get; set; }
        public string STATUS { get; set; }
        public string STATUS_DESC { get; set; }
        public string ULD { get; set; }
        public DateTime? UPDATE_TIME { get; set; }
    }
}
