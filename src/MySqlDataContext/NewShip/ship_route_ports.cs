using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class ship_route_ports
    {
        public long SHIP_ROUTE_PORT_ID { get; set; }
        public long? SHIP_ROUTE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long? PORT_COUNTRY_ID { get; set; }
        public long? PORT_CITY_ID { get; set; }
        public long PORT_ID { get; set; }
        public int SEQUENCE { get; set; }
        public int? OPEN_TIME { get; set; }
        public int? PACK_TIME { get; set; }
        public int? CUT_VIA_DATE { get; set; }
        public int? CUT_BOOKING_DATE { get; set; }
        public int? CLOSE_TIME { get; set; }
        public int? CUT_MATERIAL_DATE { get; set; }
        public int? CUT_OFF_DATE { get; set; }
        public int? CUT_VGM_DATE { get; set; }
        public int? LEAVE_TIME { get; set; }
        public bool DELETE_MARK { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string MODIFY_USERNAME { get; set; }

        public virtual ship_route SHIP_ROUTE { get; set; }
    }
}
