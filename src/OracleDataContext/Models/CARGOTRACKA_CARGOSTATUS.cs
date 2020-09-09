using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class CARGOTRACKA_CARGOSTATUS
    {
        public string KEY_ID { get; set; }
        public DateTime? EVENT_TIME { get; set; }
        public string STATION { get; set; }
        public string B_KEY_ID { get; set; }
        public string FLIGHT_NO { get; set; }
        public string PIECES { get; set; }
        public string WEIGHT { get; set; }
        public string VOLUME { get; set; }
        public string STATUS { get; set; }
        public string STATUS_DESC { get; set; }
        public string ULD_INFO { get; set; }
        public DateTime? UPDATE_TIME { get; set; }
    }
}
