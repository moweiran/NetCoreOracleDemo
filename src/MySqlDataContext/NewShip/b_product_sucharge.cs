using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class b_product_sucharge
    {
        public long PRODUCT_SUCHARGE_ID { get; set; }
        public long PRODUCT_ID { get; set; }
        public long RATE_SURCHARGE_ID { get; set; }
        public long CARRIER_ID { get; set; }
    }
}
