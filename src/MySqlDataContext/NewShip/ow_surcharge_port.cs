using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class ow_surcharge_port
    {
        public long OW_SURCHARGE_PORT_ID { get; set; }
        public long OW_SURCHARGE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long POD_ID { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
    }
}
