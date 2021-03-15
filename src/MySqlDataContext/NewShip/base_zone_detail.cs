using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class base_zone_detail
    {
        public long BASE_ZONE_DETAIL_ID { get; set; }
        public long BASE_ZONE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public int LOCAL_TYPE { get; set; }
        public long LOCAL_ID { get; set; }
        public string REMARK { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string MODIFY_USERNAME { get; set; }

        public virtual base_zone BASE_ZONE { get; set; }
    }
}
