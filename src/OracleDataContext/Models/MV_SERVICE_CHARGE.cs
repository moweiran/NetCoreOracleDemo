using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class MV_SERVICE_CHARGE
    {
        public decimal BASE_SERVICE_CHARGE_ID { get; set; }
        public decimal SERVICE_TYPE { get; set; }
        public string SERVICE_TYPE_DESC { get; set; }
        public string DESC_C1 { get; set; }
        public string DESC_C2 { get; set; }
        public string DESC_C3 { get; set; }
        public string DESC_C4 { get; set; }
        public string DESC_C5 { get; set; }
    }
}
