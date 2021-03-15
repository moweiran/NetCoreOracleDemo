using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class ow_surcharge_schedule
    {
        public long OW_SURCHARGE_SCHEDULEL_ID { get; set; }
        public long OW_SURCHARGE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long SCHEDULE_ID { get; set; }
        public string VESSELVOY { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
    }
}
