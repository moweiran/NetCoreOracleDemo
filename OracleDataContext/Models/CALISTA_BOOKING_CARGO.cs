using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class CALISTA_BOOKING_CARGO
    {
        public decimal CALISTA_BOOKING_CARGO_ID { get; set; }
        public decimal CALISTA_FREIGHT_BOOKING_ID { get; set; }
        public string SEQNO { get; set; }
        public string CARGODESC { get; set; }
        public string HSCODE { get; set; }
        public string PACKAGETYPE { get; set; }
        public decimal? GROSSVOLUME { get; set; }
        public decimal? GROSSWEIGHT { get; set; }
        public decimal? NETVOLUME { get; set; }
        public decimal? NETWEIGHT { get; set; }
        public decimal? VGMWEIGHT { get; set; }
        public decimal? QUANTITY { get; set; }
    }
}
