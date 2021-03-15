using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class rate_surcharge_detail
    {
        public long RATE_SURCHARGE_DETAIL_ID { get; set; }
        public long BASE_SURCHARGE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public int SUCHARGE_DETAIL_TYPE { get; set; }
        public long SUCHARGE_DETAIL_ID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string MODIFY_USERNAME { get; set; }

        public virtual rate_surcharge BASE_SURCHARGE { get; set; }
    }
}
