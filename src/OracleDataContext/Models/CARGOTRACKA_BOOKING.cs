using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class CARGOTRACKA_BOOKING
    {
        public string KEY_ID { get; set; }
        public string AWB_NO { get; set; }
        public string ORG { get; set; }
        public string DST { get; set; }
        public string PRICES { get; set; }
        public string WEIGHT { get; set; }
        public string CARRIER_CD { get; set; }
        public string CARRIER { get; set; }
        public DateTime? UPDATE_TIME { get; set; }
        public string IS_COMPLETED { get; set; }
        public string CARGOSTATUSLISTJSONSTR { get; set; }
        public string FLIGHTLISTJSONSTR { get; set; }
    }
}
