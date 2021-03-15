using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class base_zone
    {
        public base_zone()
        {
            base_zone_detail = new HashSet<base_zone_detail>();
        }

        public long BASE_ZONE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public string ZONE_NAME { get; set; }
        public int VALID { get; set; }
        public string REMARK { get; set; }
        public bool DELETE_MARK { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string MODIFY_USERNAME { get; set; }

        public virtual ICollection<base_zone_detail> base_zone_detail { get; set; }
    }
}
