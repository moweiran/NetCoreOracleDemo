using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class CARGOTRACKO_CARRIAGE
    {
        public string KEY_ID { get; set; }
        public string B_KEY_ID { get; set; }
        public string V_KEY_ID { get; set; }
        public string VSL_NAME { get; set; }
        public string VOY { get; set; }
        public string BL_NO { get; set; }
        public string POL { get; set; }
        public string POD { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ATA { get; set; }
        public DateTime? ATD { get; set; }
    }
}
